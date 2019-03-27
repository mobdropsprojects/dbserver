using System;
using System.Collections.Generic;
using System.Text;

namespace DBServer.Domain
{
    public class DataContract<T>
    {

        public string Operator { get; set; }
        public DateTime Timestamp { get; set; }
        public T Data { get; set; }
    }
}
