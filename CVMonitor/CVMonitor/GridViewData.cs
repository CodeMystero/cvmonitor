using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPExample
{
    enum DataFlow { Send, Receive }
    
    class GridViewDataComm
    {

        public DateTime DateTime { get; set; }
        public DataFlow DataFlow { get; set; }
        public string Message { get; set; }

        public GridViewDataComm(DateTime dateTime, DataFlow dataFlow, string message)
        {
            DateTime = dateTime;
            DataFlow = dataFlow;
            Message = message;
        }
    }

    class GridViewDataDeviceLog
    {

        public DateTime DateTime { get; set; }
        public string ClientIPAddress { get; set; }
        public string strCode { get; set; }
        public ErrorCode ErrorCode { get; set; }

        public GridViewDataDeviceLog(DateTime dateTime, string clientIPAddress, ErrorCode errorCode)
        {
            DateTime = dateTime;
            ClientIPAddress = clientIPAddress;
            strCode = GetrDescription(errorCode);
            ErrorCode = errorCode;
        }

        public string GetrDescription(ErrorCode errorCode)
        {
            var enumtotal = Enum.GetValues(typeof(ErrorCode)).Cast<int>().Aggregate((i1, i2) => i1 | i2); //this could be buffered for performance
            if ((enumtotal | (int)errorCode) == enumtotal)
                return "0x" + ((int)errorCode).ToString("X2");
            return "0x" + ((int)errorCode).ToString("X2");
        }
    }

    class GridViewDataData
    {

        public DateTime DateTime { get; set; }
        [DisplayName("Current CH 0")]
        [DisplayFormat(DataFormatString = "{0:N3}")]
        public float Current0 { get; set; }
        [DisplayName("Current CH 1")]
        [DisplayFormat(DataFormatString = "{0:N3}")] 
        public float Current1 { get; set; }
        [DisplayName("Voltage CH 0")]
        [DisplayFormat(DataFormatString = "{0:N3}")] 
        public float Voltage0 { get; set; }
        [DisplayName("Voltage CH 1")]
        [DisplayFormat(DataFormatString = "{0:N3}")] 
        public float Voltage1 { get; set; }

        [DisplayName("Result")]
        public string Result { get; set; }
        public GridViewDataData(DateTime dateTime, float current0, float current1, float voltage0, float voltage1, string result)
        {
            DateTime = dateTime;
            Current0 = current0;
            Current1 = current1;
            Voltage0 = voltage0;
            Voltage1 = voltage1;
            Result = result;
        }

        public override string ToString()
        {
            return DateTime.ToString("yyyy-MM-dd HH:mm:ss.fff") + "," + Current0.ToString("N3") + "," + Current1.ToString("N3") + "," + Voltage0.ToString("N3") + "," + Voltage1.ToString("N3") + "," + Result.ToString();
        }
    }
}
