﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion.Models
{
    public interface ILogbook
    {
        public void Add(string description);
    }
}
