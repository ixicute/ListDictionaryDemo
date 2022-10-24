using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionaryDemo
{
    internal class Country
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Capital { get; set; }

        public Country(string Name, string Code, string Capital)
        {
            this.Name = Name;
            this.Code = Code.ToUpper();
            this.Capital = Capital;
        }
    }
}
