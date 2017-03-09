using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;

namespace Guru.Core.Data
{
  public  interface IModel
    {
        ObjectId Id { get; set; }
               
        string UpdateBy { get; set; }
        string InsertBy { get; set; }
        string DeleteBy { get; set; }
        DateTime UpdateAt { get; set; }
        DateTime InsertAt { get; set; }
        DateTime DeleteAt { get; set; }

    }
}
