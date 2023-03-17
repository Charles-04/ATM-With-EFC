using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.DAL.Models
{
    public  class Account
    {
        public string AccountName { get; set; }
        public long AccountNumber { get; set; }
        public int Pin { get; set; }
        public decimal Balance { get; set; }
        public bool IsActive { get; set; }

    }
}
