using System;
using System.Collections.Generic;
using System.Text;

namespace Default.Return
{
    public class DefaultReturn<T>
    {
        public DateTime date { get; set; }
        public Guid transactionToken { get; set; }
        public T dataReturn { get; set; }
        public Exception ex { get; set; }
        public int code { get; set; }

        public DefaultReturn()
        {
            date = DateTime.Now;
            transactionToken = Guid.NewGuid();
        }
        public DefaultReturn(T data,int statusCode)
        {
            date = DateTime.Now;
            transactionToken = Guid.NewGuid();
            code = statusCode;
            ex = null;
        }

        public DefaultReturn(Exception exception)
        {
            date = DateTime.Now;
            transactionToken = Guid.NewGuid();
            ex = exception;
        }
    }
}
