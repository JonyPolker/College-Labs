using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work9
{
    internal class Bank
    {
        private int _money;
        private int _serialNumber;
        private bool _isActive;

        public Bank(int SN)
        {
            _serialNumber = SN;
        }

        public void Switch()
        {
            _isActive = !_isActive;
        }
        public int Money
        {
            set
            {
                _money = Math.Max(0, value);
            }
            get
            {
                return _money;
            }
        }

        public string Status
        {
            get
            {
                if (_isActive == true)
                {
                    return "Банкомат включен.";
                }
                else
                {
                    return "Банкомат выключен.";
                }
            }
        }

        public int CheckSN
        {
            get
            {
                return _serialNumber;
            }
        }

        public bool ST
        {
            get
            {
                return _isActive;
            }
        }
    }
}
