using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        //this will be used automatically as the primary key of the table
        public int Id { get; set; }
        public string Name { get; set; }
    }
}