﻿using System.Collections.Generic;
using Csv.File.Domain;

namespace Csv.File
{
    public class NullDuplicatesStrategy : IDuplicationStrategy
    {
        public List<Customer> Apply(List<Customer> customers)
        {
            if(customers == null) return new List<Customer>();
            return customers;
        }
    }
}