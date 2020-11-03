using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class CITY_DISTRICT:IEntity
    {
        public int ID { get; set; }
        public string CITY { get; set; }
        public string TOWNCODE { get; set; }
        public string TOWN { get; set; }
        public string PHONECODE { get; set; }
    }
}
