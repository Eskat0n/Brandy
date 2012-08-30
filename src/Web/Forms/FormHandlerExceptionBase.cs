namespace Brandy.Web.Forms
{
    using System;
    using System.Runtime.Serialization;

    public abstract class FormHandlerExceptionBase : Exception
    {
        public string Key { get; private set; }

        protected FormHandlerExceptionBase(string key, string message)
            : base(message)
        {
            Key = key;
        }

        protected FormHandlerExceptionBase(string key, string message, Exception inner)
            : base(message, inner)
        {
            Key = key;
        }

        protected FormHandlerExceptionBase(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}