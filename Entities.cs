using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testCustomerService
{
    public class Entities
    {
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Familly { get; set; }
            public string FatherName { get; set; }
            public int BirthCertificateID { get; set; }
            public int NationalID { get; set; }
            public string BirthDate { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
        }
    }
}
