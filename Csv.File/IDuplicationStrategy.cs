﻿using System.Collections.Generic;
using CsvFile.Kata.Dependencies;

namespace Csv.File
{
    public interface IDuplicationStrategy
    {
        List<Customer> Apply(List<Customer> customers);
    }
}