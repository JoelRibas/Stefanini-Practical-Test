using System;
using System.Collections.Generic;

namespace Stefanini.Business
{
    public class BusinessManager
    {

        #region Execution Status and Message

        protected BusinessExecutionStatus status = null;
        public BusinessExecutionStatus Status
        {
            get
            {
                if (this.status == null)
                {
                    this.status = new BusinessExecutionStatus();
                }
                return this.status;
            }
        }

        #endregion

        #region ResetStatus

        public void ResetStatus(bool sucess)
        {
            this.status = null;
            this.Status.Success = sucess;
        }

        #endregion

        #region GetStatusMessage

        public string GetStatusMessage()
        {
            string message = null;
            message += this.Status.Message;
            if (this.Status.InnerMessage != null && this.Status.InnerMessage.Count > 0)
            {
                message += "\n";
                foreach (var item in this.Status.InnerMessage)
                {
                    message += item + "\n";
                }
            }
            if (this.Status.Exception != null)
            {
                message += "EXCEPTION:\n";
                message += Util.GetExceptionMessage(this.Status.Exception);
            }
            return message;
        }

        #endregion

    }
}
