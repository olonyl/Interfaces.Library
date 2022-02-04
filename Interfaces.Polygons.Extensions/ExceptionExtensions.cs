using System.Text;

namespace System
{
    public static class ExceptionExtensions
    {
        public static string GetFullMessage(this Exception exception)
        {
            StringBuilder fullMessage = new StringBuilder();
            fullMessage.AppendLine(exception.Message);

            var innerException = exception.InnerException;
            while (innerException != null)
            {
                fullMessage.AppendLine(innerException.Message);
                innerException = innerException.InnerException;
            }

            return fullMessage.ToString();
        }
    }
}
