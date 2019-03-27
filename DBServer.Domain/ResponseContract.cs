using System;
using System.Collections.Generic;
using System.Text;

namespace DBServer.Domain
{
    public class ResponseContract<T>
    {
        public bool IsSuccess { get; set; }
        public DateTime Timestamp { get; set; }
        public int StatusCode { get; set;}
        public string error { get; set; }
        public Object Data { get; set; }

        public ResponseContract()
        {
            Timestamp = DateTime.Now;
            IsSuccess = true;
        }
    }
}
