﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            IsSuccess = success;
        }

        public bool IsSuccess { get; }

        public string Message {  get; }
    }
}
