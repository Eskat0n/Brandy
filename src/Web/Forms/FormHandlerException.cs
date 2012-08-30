namespace Brandy.Web.Forms
{
    using System;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using NArms.Utility;

    [Serializable]
    public class FormHandlerException : FormHandlerExceptionBase
    {
        public FormHandlerException(string message)
            : base("form", message)
        {
        }

        public FormHandlerException(string message, Exception innerException)
            : base("form", message, innerException)
        {
        }

        public FormHandlerException(string key, string message)
            : base(key, message)
        {
        }

        public FormHandlerException(string key, string message, Exception inner)
            : base(key, message, inner)
        {
        }

        protected FormHandlerException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }

    [Serializable]
    public class FormHandlerException<TForm> : FormHandlerExceptionBase
        where TForm : class, IForm
    {
        public FormHandlerException(Expression<Func<TForm, object>> expression, string message)
            : base(Name.Of(expression), message)
        {
        }

        public FormHandlerException(Expression<Func<TForm, object>> expression, string message, Exception inner)
            : base(Name.Of(expression), message, inner)
        {
        }

        public FormHandlerException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
