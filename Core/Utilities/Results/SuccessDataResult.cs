using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataREsult<T>
    {

        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }
        public SuccessDataResult(T data ) : base(data, true)
        {
        }

        public SuccessDataResult(string message) : base(default, success: true, message)
        {

        }
    }


}
