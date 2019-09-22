using System;
using System.Collections.Generic;
using System.Text;

namespace Plumsail.CommonLib.Exceptions
{
    /// <summary>
    /// Исключение, текст которого может быть отображен на интерфейсе.
    /// </summary>
    public class UserFriendlyException : Exception
    {
        public UserFriendlyException(string message, string errorCode = "") : base(message)
        {
            ErrorCode = errorCode;
        }

        public string ErrorCode { get; }
    }
}
