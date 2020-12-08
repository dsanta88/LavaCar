using System;
using System.Collections.Generic;
using System.Text;

namespace LavaCar.Shared
{
    public class Response
    {
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public object Data { get; set; }
    }
}

