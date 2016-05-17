using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThorsHammerPoC.Models
{
    public class UserDto
    {
        private int _count;
        private string _message;

        public UserDto(int count, string message)
        {
            Count = count;
            Message = message;
        }

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public string Message {
            get { return _message;}
            set { _message = value; }
        }
    }
}