using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;

namespace Guru.Core.Data
{
    public class Model : IModel
    {
        public ObjectId Id { get; set; }
        public string UpdateBy { get; set; }
        public string InsertBy { get; set; }
        public string DeleteBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime InsertAt { get; set; }
        public DateTime DeleteAt { get; set; }
    }
}
