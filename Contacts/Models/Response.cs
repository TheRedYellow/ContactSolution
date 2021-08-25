using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Contacts.Models
{

    public interface IJsonResponse
    {
        JsonResult ToJsonResult();
    }

    public class ErrorResponse : IJsonResponse
    {
        string _error;
        public ErrorResponse(string error)
        {
            _error = error;
        }

        public string Error
        {
            get
            {
                return _error;
            }
        }

        public JsonResult ToJsonResult()
        {
            return new JsonResult(this);
        }
    }

    public class DataResponse : IJsonResponse
    {
        object _data;
        int _count;
        int _total;

        public DataResponse(object data, int count = 0, int total = 0)
        {
            _data = data;
            _count = count;
            _total = total;
        }

        public object Data
        {
            get
            {
                return _data;
            }
        }
        public int Count
        {
            get
            {
                return _count;
            }
        }
        public int Total
        {
            get
            {
                return _total;
            }
        }
        public JsonResult ToJsonResult()
        {
            return new JsonResult(this);
        }
    }
}
