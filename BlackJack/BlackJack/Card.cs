using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card
    {
        public char sym;
        public string num;

        public Card(char _sym, string _num) 
        { 
            sym = _sym;
            num = _num;
        }
        
        
    }
}
