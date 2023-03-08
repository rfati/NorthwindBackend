﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            MEssage = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string MEssage { get; }
    }
}
