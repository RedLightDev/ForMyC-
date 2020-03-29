using System;
namespace BS_Start.Models
{
    public abstract class BaseModel
    {
        public int ID { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
    }
}
