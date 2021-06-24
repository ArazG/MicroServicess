﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BkgNumber { get; set; }
        public DateTime? ChekinDate { get; set; }
        public DateTime? ChekoutDate { get; set; }
        public DateTime? BkgDate { get; set; }
        public double Amount { get; set; }


    }
}
