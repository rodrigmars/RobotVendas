using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotVendas.Application
{
    public class VendasApp
    {

        public bool DiaUtil() {

            var days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            return true; 
        }
    }
}
