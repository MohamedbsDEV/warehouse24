﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse24.Models.Classes
{
    public class ToWarehouse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ToWarehouse(int id, string name)  
        {
           this. Id = id;
           this. Name = name;
        }
        public override string ToString() 
        {
            return $"{Id}  {Name}\n";
        
        }
    }
}
