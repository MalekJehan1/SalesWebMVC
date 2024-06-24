using System;

namespace SalesWebMVCx.Services.Exceptions
{
    public class NotFoundException : ApplicationException
    {
        public NotFoundException (string message) : base(message)
        {

        }
    }
}
