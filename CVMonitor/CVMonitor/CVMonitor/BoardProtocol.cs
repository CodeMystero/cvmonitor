using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CVMonitorExample
{
    public class ReceiveProtocol
    {
        public DateTime DateTime { get; set; }
        private int length;
        private byte[] bytes;

        protected ReceiveProtocol(byte[] bytes, int length)
        {
            DateTime = DateTime.Now;
            this.bytes = bytes;
            this.length = length;
        }

        public override string ToString()
        {
            return GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(this, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
        }
    }

    class ReceiveProtocol_GatheringData_Response : ReceiveProtocol
    {
        public bool IsRun { get; set; }
        public ReceiveProtocol_GatheringData_Response(byte[] bytes, int length) : base(bytes, length)
        {
            byte[] ack = new byte[1];
            Array.Copy(bytes, 0, ack, 0, 1);
            IsRun = ack[0] == 0x53 ? true : false;
        }
    }

    class ReceiveProtocol_LogData : ReceiveProtocol
    {
        public int GroupCount { get; set; }
        public int DataCount { get; set; }
        public List<DeviceLog> Datas { get; set; }
        public ReceiveProtocol_LogData(byte[] bytes, int length) : base(bytes, length)
        {
            try
            {
                Datas = new List<DeviceLog> ();
                DataCount = bytes[1];
                int startIdx = 2;
                int dateCount = 6;
                int dummyCount = 5;
                int clientIPCount = 4;
                int errorCodeCount = 1;
                int dateLength = dateCount + dummyCount + clientIPCount + errorCodeCount;
                for (int i = 0; i < DataCount; i++)
                {
                    DeviceLog deviceLog = new DeviceLog();

                    byte[] date = new byte[dateCount];
                    byte[] dummy = new byte[dummyCount];
                    byte[] ip = new byte[clientIPCount];
                    byte[] errorCode = new byte[errorCodeCount];

                    Array.Copy(bytes, startIdx + (dateLength * i), date, 0, dateCount);
                    Array.Copy(bytes, startIdx + (dateLength * i) + dateCount, dummy, 0, dummyCount);
                    Array.Copy(bytes, startIdx + (dateLength * i) + dateCount + dummyCount, ip, 0, clientIPCount);
                    Array.Copy(bytes, startIdx + (dateLength * i) + dateCount + dummyCount + clientIPCount, errorCode, 0, errorCodeCount);


                    string year = 20 + date[0].ToString("00");
                    deviceLog.DateTime = new DateTime(Convert.ToInt16(year), date[1], date[2], date[3], date[4], date[5]);
                    deviceLog.Dummy = dummy.ToString();
                    deviceLog.ClientIPAddress = new IPAddress(ip);
                    deviceLog.ErrorCode = (ErrorCode)Enum.Parse(typeof(ErrorCode), errorCode[0].ToString());

                    Datas.Add(deviceLog);
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
    
    class ReceiveProtocol_GatheringData : ReceiveProtocol
    {
        public int GroupCount { get; set; }
        public int DataCount { get; set; }
        public List<float[]> Datas { get; set; }
        public ReceiveProtocol_GatheringData(byte[] bytes, int length) : base(bytes, length)
        {
            try
            {
                Datas = new List<float[]>();
                DataCount = bytes[3];
                int headerSize = 4;
                int offset = 8;

                for (int i = 0; i < DataCount; i++)
                {
                    byte[] byteData1 = new byte[2];
                    byte[] byteData2 = new byte[2];
                    byte[] byteData3 = new byte[2];
                    byte[] byteData4 = new byte[2];

                    if (headerSize + (offset * i) > length)
                        break;
                    Array.Copy(bytes, headerSize + (offset * i), byteData1, 0, 2);
                    Array.Copy(bytes, headerSize + (offset * i) + 2, byteData2, 0, 2);
                    Array.Copy(bytes, headerSize + (offset * i) + 4, byteData3, 0, 2);
                    Array.Copy(bytes, headerSize + (offset * i) + 6, byteData4, 0, 2);

                    Array.Reverse(byteData1);
                    Array.Reverse(byteData2);
                    Array.Reverse(byteData3);
                    Array.Reverse(byteData4);

                    float ch0 = BitConverter.ToUInt16(byteData1, 0) * ((float)4 / 65536);
                    float ch1 = BitConverter.ToUInt16(byteData2, 0) * ((float)4 / 65536);
                    ch0 = (float)((ch0 - 2.214) * 10 / 0.887);
                    ch1 = (float)((ch1 - 2.214) * 10 / 0.887);
                    float ch2 = BitConverter.ToUInt16(byteData3, 0) * ((float)50 / 65536);
                    float ch3 = BitConverter.ToUInt16(byteData4, 0) * ((float)50 / 65536);

                    Datas.Add(new float[] { ch0, ch1, ch2, ch3 });
                }


                string log = string.Format("DataCount [{0}] : ListCount {1}", DataCount, Datas.Count);

                if (DataCount > Datas.Count)
                {
                    DataCount = Datas.Count;
                    throw new Exception("Less data than data counters.");
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }

    class ReceiveProtocol_Version: ReceiveProtocol
    {
        public DateTime VersionTime { get; set; }
        public int SequenceNumber { get; set; }
        public bool ACK { get; set; }
        public ReceiveProtocol_Version(byte[] bytes, int length) : base(bytes, length)
        {
            byte[] data = new byte[4];
            Array.Copy(bytes, 1, data, 0, 4);

            string year = 20 + data[0].ToString("00");
            VersionTime = new DateTime(Convert.ToInt16(year), data[1], data[2]);
            SequenceNumber = data[3];
        }
    }

    class ReceiveProtocol_TimeAndSamplingTime : ReceiveProtocol
    {
        public DateTime DeviceTime { get; set; }
        public int SamplingTime { get; set; }
        public ReceiveProtocol_TimeAndSamplingTime(byte[] bytes, int length) : base(bytes, length)
        {
            byte[] bytes1 = new byte[length - 1];
            Array.Copy(bytes, 1, bytes1, 0, length - 1);
            string year = 20 + bytes1[0].ToString("00");
            DeviceTime = new DateTime(Convert.ToInt16(year), bytes1[1], bytes1[2], bytes1[3], bytes1[4], bytes1[5]);
            SamplingTime = bytes1[6];
        }
    }

    class ReceiveProtocol_IP : ReceiveProtocol
    {
        public IPAddress IPAddress { get; set; }
        public ReceiveProtocol_IP(byte[] bytes, int length) : base(bytes, length)
        {
            byte[] bytes1 = new byte[length - 1];
            Array.Copy(bytes, 1, bytes1, 0, length - 1);
            IPAddress = new IPAddress(bytes1);
        }
    }

    enum ErrorCode
    {
        Connected = 0x01, //CLIENT IP Field에 접속 된 CLIENT IP 같이 전송
        CloseWait = 0x02,
        ServerStart = 0x03,
        FailSocket = 0x04,
        ListenWait = 0x05,
        SendOKProblem = 0x06, //송/수신 중 문제 발생
        ReConnection = 0x07
    }

    class DeviceLog
    {
        public DateTime DateTime { get; set; }
        public string Dummy { get; set; }
        public IPAddress ClientIPAddress { get; set; }
        public ErrorCode ErrorCode { get; set; }
    }
}
