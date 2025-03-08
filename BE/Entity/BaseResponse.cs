using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity
{
    public class BaseResponse
    {
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
    }

    public class BaseResponse<T> : BaseResponse where T : class
    {
        public T Data { get; set; }
    }
}
