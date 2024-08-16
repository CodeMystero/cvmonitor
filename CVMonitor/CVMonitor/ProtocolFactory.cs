using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CVMonitorExample
{
    internal class ProtocolFactory
    {
        public ReceiveProtocol CreateProtocol(char protocol, byte[] bytes, int length)
        {
            switch (protocol)
            {
                case 'T':
                    return new ReceiveProtocol_TimeAndSamplingTime(bytes, length);
                case 'L':
                    return new ReceiveProtocol_LogData(bytes, length);
                case 'S':
                case 'P':
                    return new ReceiveProtocol_GatheringData_Response(bytes, length);
                case 'D':
                    return new ReceiveProtocol_GatheringData(bytes, length);
                case 'V':
                    return new ReceiveProtocol_Version(bytes, length);
                case 'I':
                    return new ReceiveProtocol_IP(bytes, length);
                default:
                    throw new ArgumentException("Unknown protocol type");
            }
        }
    }
}
