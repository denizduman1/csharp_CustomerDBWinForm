using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Customer:IEntity
    {
        public int ID { get; set; }
        public string NAMESURNAME { get; set; }
        public string GENDER { get; set; }
        public DateTime BIRTHDATE { get; set; }
        public string CITY { get; set; }
        public string TOWN { get; set; }
        public string TELNR { get; set; }
    }
}
