using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataREsult<T> : Result, IDataResult<T>
    {
        public T Data { get; }

        public DataREsult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataREsult(T data, bool success) : base(success)
        {
            Data = data;
        }
    }
}
