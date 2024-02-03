using System;

namespace Common.Communication
{
    [Serializable]
    public class Response
    {
        public object Data { get; set; }
        public Operation Operation { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
        public Exception Exception { get; set; }
    }
}
