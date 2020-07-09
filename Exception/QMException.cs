using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMesurement.Exception
{
  public  class QMException: System.Exception
    {
        public enum ExceptionEnmu
        {
            INVAILD_VALUE, NULL_EXCEPTION, EMPTY_EXCEPTION

        }
        public ExceptionEnmu exceptionEnmu;
        private ExceptionEnmu iNVAILD_VALUE;

        public QMException(ExceptionEnmu exceptionType, String message) : base(message)
        {
            this.exceptionEnmu = exceptionType;
        }

        public QMException(ExceptionEnmu iNVAILD_VALUE)
        {
            this.iNVAILD_VALUE = iNVAILD_VALUE;
        }
    }
}
