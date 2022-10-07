using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketSystemClassLibrary;

namespace OresundBronTicketLibrary
{
    public class OresundbronMC: MC
    {
        public override double Price(bool broBizz)
        {
            return broBizz ? 73 : 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
