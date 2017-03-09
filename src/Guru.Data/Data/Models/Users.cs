using Guru.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guru.Data.Models
{
  public  class Users:Model
    {

        public string Mail { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GoogleCode { get; set; }
        public string Facebook { get; set; }

    }
}
