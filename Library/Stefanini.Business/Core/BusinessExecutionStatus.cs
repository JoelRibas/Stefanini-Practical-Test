using System;
using System.Collections.Generic;

namespace Stefanini.Business
{
    public class BusinessExecutionStatus
    {

        public bool Success { get; set; }
        public string Message { get; set; }

        public List<string> InnerMessage { get; set; }

        public Exception Exception { get; set; }

        public void AddInnerMessage(string message)
        {
            if (this.InnerMessage == null)
            {
                this.InnerMessage = new List<string>();
            }
            this.InnerMessage.Add(message);
        }

    }
}
