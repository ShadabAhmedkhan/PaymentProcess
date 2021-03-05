using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Payment.ErrorHandling
{
    public class AuthException : Exception
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; }
        public AuthException(string message)
            : base(message)
        {
            Success = false;
            Message = message;
        }
    }
}
