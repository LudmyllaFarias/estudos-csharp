using System;
using System.Collections.Generic;
using System.Text;

namespace produto_categoria_linq
{
    internal class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Tier { get; set; }

        public Category(int Id, string Name, int Tier) 
        { 
            this.Id = Id;
            this.Name = Name;
            this.Tier = Tier;
        }
    }
}
