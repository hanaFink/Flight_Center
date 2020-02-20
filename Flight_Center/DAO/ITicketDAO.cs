﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight_Center
{
    public interface ITicketDAO:IBasicDB<Ticket>
    {
        IList<Ticket> GetAllTicketsByAirlineId(Int64 airlineId);
    }
}
