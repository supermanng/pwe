using Application.Common.Constant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Models
{
    public class ResponseModel
    {
        public string Code { get; set; }
        public string Service { get; set; }


        public static ResponseModel Success(string service = null)
        {
            return new ResponseModel()
            {
                Code = ResponseCode.Success,
                Service = service ?? "Request.Default",

            };
        }

        public static ResponseModel Failure(string service = null) // , Dictionary<string, string> errors = null
        {
            return new ResponseModel()
            {
                Code = ResponseCode.Failure,
                Service = service ?? "Request.Default",

                //Errors = errors
            };
        }
    }
    public class ResponseModel<T> : ResponseModel
    {
        public T Data { get; set; }

        public static ResponseModel<T> Success(T data, string service = null)
        {
            return new ResponseModel<T>()
            {
                Code = ResponseCode.Success,
                Service = service ?? "Request.Default",
                Data = data,
            };
        }
        public static ResponseModel<T> Failure(T data, string service = null)
        {
            return new ResponseModel<T>()
            {
                Code = ResponseCode.Failure,
                Service = service ?? "Request.Default",
                Data = data,
            };
        }
    }
}

