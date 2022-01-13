using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCard.Model
{
    public class Results: Resource 
    {
        public Guid Id { get; set; }
        public string fisrtName { get; set; }
        public string lastName { get; set; }
        public string dateOfBirth { get; set; }
        public int income { get; set; }
        public string cardName { get; set; }
        public string cardApr { get; set; }
        public string promoMessage { get; set; }

    }
}
