using CreditCard.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCard
{
    public class Collection<T> :Resource
    {
        public T[] Value { get; set; }

    }
}
