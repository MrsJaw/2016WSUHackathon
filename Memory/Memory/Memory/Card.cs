using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Card
    {
        public bool Flipped { get; set; }
        public int Value { get; set; }

        private string _Display;
        public string Display
        {
            get
            {
                return Flipped ? Value.ToString() : _Display;
            }
            set
            {
                _Display = value;
            }
        }
        
        public Card(int value)
        {
            Value = value;
            _Display = "*";
            Flipped = false;
        }
    }
}
