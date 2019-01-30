using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO6
{
    class Bank_Account
    {
        public string _owner;
        public string _currency;
        public double _final_settlement;
        public void _tocredit(double _credit)
        {
        _final_settlement = _credit;
        }
        public void _todebit(double _debit)
        {
        _final_settlement = _debit;
        }
    }
}
