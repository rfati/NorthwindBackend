using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    class ErrorResult : Result
    {
        public ErrorResult(bool success, string message) : base(success: false, message)
        {
        }
        public ErrorResult() : base(success: false)
        {
        }
    }
}
