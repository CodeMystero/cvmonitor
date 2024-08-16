using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace CVMonitorExample
{
    enum ControlCharacter 
    {
        STX = 0x02,
        ETX = 0x03
    }

    public class GatheringData
    {
        public DateTime DateTime { get; set; }
        public string Data { get; set; }

        public GatheringData(string data)
        {
            DateTime = DateTime.Now;
            Data = data;
        }
    }

    public class BoardComm
    {
        private TcpClient _tcpClient;
        private byte[] _receiveBuffer = new byte[4096];
        private bool _connected;
        int _port;
        private IPAddress _iPAddress;
        private List<GatheringData> _gatheringDatas = new List<GatheringData>();
        private ProtocolFactory _protocolFactory = new ProtocolFactory();

        public delegate void OnCallback(ReceiveProtocol receive);
        public delegate void OnCallbackConnect();
        public delegate void OnCallbackWrite();
        public OnCallback OnCallbackMethod;
        public OnCallbackConnect OnCallbackConnectMethod;
        public OnCallbackWrite OnCallbackWriteMethod;
        public BoardComm()
        {
        }

        public void Connect(string ip, int port)
        {
            try
            {
                if (_tcpClient != null || _connected)
                {
                    Disconnect();
                }

                _iPAddress = IPAddress.Parse(ip);
                _port = port;
                _tcpClient = new TcpClient();
                _tcpClient.ReceiveBufferSize = 4096;
                int size = sizeof(UInt32);
                UInt32 on = 1;
                UInt32 keepAliveInterval = 1000;   // Send a packet once every 10 seconds.
                UInt32 retryInterval = 1000;        // If no response, resend every second.
                byte[] inArray = new byte[size * 3];
                Array.Copy(BitConverter.GetBytes(on), 0, inArray, 0, size);
                Array.Copy(BitConverter.GetBytes(keepAliveInterval), 0, inArray, size, size);
                Array.Copy(BitConverter.GetBytes(retryInterval), 0, inArray, size * 2, size);

                _tcpClient.Client.IOControl(IOControlCode.KeepAliveValues, inArray, null); //TCP 연결이 비활성 상태일 때에도 연결을 유지하기 위해 주기적으로 Keep-Alive패캣이르 보내는 기능을 설정
                _tcpClient.BeginConnect(_iPAddress, _port, onCompleteConnect, _tcpClient);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public void Disconnect()
        {
            if(_tcpClient != null)
            {
                _tcpClient.Close();
                _tcpClient.Dispose();
                _tcpClient = null;
            }
            
            LogManager.Instance.StopTimer();
            FileManager.Instance.StopTimer();
        }

        public bool StartGathering()
        {
            byte[] sendBuffer = new byte[3];
            sendBuffer[0] = (byte)ControlCharacter.STX;
            sendBuffer[1] = (byte)'S';
            sendBuffer[2] = (byte)ControlCharacter.ETX;

            return Send(sendBuffer);
        }

        public bool StopGathering()
        {
            byte[] sendBuffer = new byte[3];
            sendBuffer[0] = (byte)ControlCharacter.STX;
            sendBuffer[1] = (byte)'P';
            sendBuffer[2] = (byte)ControlCharacter.ETX;

            return Send(sendBuffer);
        }

        public bool CheckIPAddress()
        {
            byte[] sendBuffer = new byte[3];
            sendBuffer[0] = (byte)ControlCharacter.STX;
            sendBuffer[1] = (byte)'B';
            sendBuffer[2] = (byte)ControlCharacter.ETX;

            return Send(sendBuffer);
        }

        public bool SetTimeAndSamplingTime(DateTime dateTime, int samplingTime)
        {
            byte[] sendBuffer = new byte[11];
            sendBuffer[0] = (byte)ControlCharacter.STX;
            sendBuffer[1] = (byte)'T';
            sendBuffer[2] = (byte)(dateTime.Year - 2000);
            sendBuffer[3] = (byte)dateTime.Month;
            sendBuffer[4] = (byte)dateTime.Day;
            sendBuffer[5] = (byte)dateTime.Hour;
            sendBuffer[6] = (byte)dateTime.Minute;
            sendBuffer[7] = (byte)dateTime.Second;
            sendBuffer[8] = (byte)samplingTime;
            sendBuffer[9] = (byte)0x00;
            sendBuffer[10] = (byte)ControlCharacter.ETX;

            return Send(sendBuffer);
        }

        public bool CheckTimeAndSamplingTime()
        {
            byte[] sendBuffer = new byte[3];
            sendBuffer[0] = (byte)ControlCharacter.STX;
            sendBuffer[1] = (byte)'A';
            sendBuffer[2] = (byte)ControlCharacter.ETX;

            return Send(sendBuffer);
        }

        public bool CheckVersion()
        {
            byte[] sendBuffer = new byte[3];
            sendBuffer[0] = (byte)ControlCharacter.STX;
            sendBuffer[1] = (byte)'V';
            sendBuffer[2] = (byte)ControlCharacter.ETX;

            return Send(sendBuffer);
        }

        public bool ReceiveLogData()
        {
            byte[] sendBuffer = new byte[3];
            sendBuffer[0] = (byte)ControlCharacter.STX;
            sendBuffer[1] = (byte)'L';
            sendBuffer[2] = (byte)ControlCharacter.ETX;

            return Send(sendBuffer);
        }

        public bool SetIP(IPAddress iPAddress)
        {
            byte[] sendBuffer = new byte[8];
            byte[] ip = iPAddress.GetAddressBytes();
            sendBuffer[0] = (byte)ControlCharacter.STX;
            sendBuffer[1] = (byte)'I';
            sendBuffer[2] = ip[0];
            sendBuffer[3] = ip[1];
            sendBuffer[4] = ip[2];
            sendBuffer[5] = ip[3];
            sendBuffer[6] = 0x00; //패딩으로 예상됨
            sendBuffer[7] = (byte)ControlCharacter.ETX;

            return Send(sendBuffer);
        }

        public List<GatheringData> GetGatheringDatas()
        {
            return _gatheringDatas;
        }

        private bool Send(byte[] sendBuffer)
        {
            try
            {
                if (_tcpClient == null || !_tcpClient.Connected)
                {
                    return false;
                }
                else
                {
                    if (_tcpClient.Client.Connected)
                    {
                        _tcpClient.GetStream().BeginWrite(sendBuffer, 0, sendBuffer.Length, onCompleteWriteToServer, _tcpClient);

                        LogManager.Instance.AddLog(true, sendBuffer);

                        return true;
                    }

                    return false;
                }

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Connection이 시작되면 비동기 데이터 받고, LogManager(10분마다 생성),
        //Filemanager(DeletePeriod안에 생성된 것 제외 전부 삭제)타이머 스타트 
        private void onCompleteConnect(IAsyncResult iar)
        {
            try
            {
                if (_tcpClient == null) return;

                if (((TcpClient)iar.AsyncState).Client != null)
                {
                    TcpClient tcpc = (TcpClient)iar.AsyncState;
                    if (tcpc.Client.Connected)
                    {
                        tcpc.EndConnect(iar); //tcp연결작업을 종료하고, 연결이 성공적으로 이루어졌는지 확인
                        tcpc.GetStream().BeginRead(_receiveBuffer, 0, _receiveBuffer.Length, onCompleteReadFromServer, tcpc);
                        _connected = true;
                        LogManager.Instance.StartTimer();
                        FileManager.Instance.StartTimer();
                        OnCallbackConnectMethod();
                    }
                }
            }
            catch (Exception ex)
            {
                _connected = false;
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void onCompleteWriteToServer(IAsyncResult iar)
        {
            TcpClient tcpc;

            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                tcpc.GetStream().EndWrite(iar);
                OnCallbackWriteMethod();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void onCompleteReadFromServer(IAsyncResult iar) //비동기로 서버로부터 데이터를 읽는 메서드
        {
            TcpClient tcpc;
            int nCountBytesReceivedFromServer;

            try
            {
                if (_tcpClient == null) return;  //_tcpClient = new TcpClient(); -> Connect() 하면 !null
                tcpc = (TcpClient)iar.AsyncState; //비동기 작업이 완료되면 객체를 전달 
                nCountBytesReceivedFromServer = tcpc.GetStream().EndRead(iar); //비동기 읽기 작업 마무리 -> 읽은 바이트 수 가져옴 

                if (nCountBytesReceivedFromServer == 0)
                {
                    //MessageBox.Show("Connection broken.");
                    return;
                }

                ////프로토콜 문자에 따라 메모리 할당
                //ReceiveProtocol receiveProtocol = ParsingProtocol(_receiveBuffer, nCountBytesReceivedFromServer);

                // 프로토콜을 식별하고 팩토리를 통해 객체 생성
                char protocol = (char)_receiveBuffer[0];
                ReceiveProtocol receiveProtocol = _protocolFactory.CreateProtocol(protocol, _receiveBuffer, nCountBytesReceivedFromServer);


                OnCallbackMethod(receiveProtocol); //파싱된 데이터를 OnCallbackMethod로 보내서 처리, 구현-> MainForm.cs, Deligate 멀티캐스팅 

                byte[] receive = new byte[nCountBytesReceivedFromServer];
                Array.Copy(_receiveBuffer, receive, nCountBytesReceivedFromServer);
                LogManager.Instance.AddLog(false, receive); //데이터 로깅
                Array.Clear(_receiveBuffer, 0, _receiveBuffer.Length); // _receiveBuffer 전체 초기화

                tcpc.GetStream().BeginRead(_receiveBuffer, 0, _receiveBuffer.Length, onCompleteReadFromServer, tcpc);
                //데이터읽어올버퍼, 데이터 시작위치, 읽어올 최대 바이트수, 비동기 읽기 완료 됐을 때 호출될 콜백 메서드, 상태객체 
                _connected = true; //연결 성공
            }
            catch (Exception ex)
            {
                _connected = false; //연결 실패
                //System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //private ReceiveProtocol ParsingProtocol(byte[] bytes, int receiveCount)
        //{
        //    ReceiveProtocol receiveProtocol = null;
        //    char protocol = (char)bytes[0];
        //    switch(protocol)
        //    {
        //        case 'T':
        //            receiveProtocol = new ReceiveProtocol_TimeAndSamplingTime(bytes, receiveCount);
        //            break;
        //        case 'L':
        //            receiveProtocol = new ReceiveProtocol_LogData(bytes, receiveCount);
        //            break;
        //        case 'S':
        //            receiveProtocol = new ReceiveProtocol_GatheringData_Response(bytes, receiveCount);
        //            break;
        //        case 'P':
        //            receiveProtocol = new ReceiveProtocol_GatheringData_Response(bytes, receiveCount);
        //            break;
        //        case 'D':
        //            receiveProtocol = new ReceiveProtocol_GatheringData(bytes, receiveCount);
        //            break;
        //        case 'V':
        //            receiveProtocol = new ReceiveProtocol_Version(bytes, receiveCount);
        //            break;
        //        case 'I':
        //            receiveProtocol = new ReceiveProtocol_IP(bytes, receiveCount);
        //            break;
        //    }

        //    return receiveProtocol;
        //}
    }
}
