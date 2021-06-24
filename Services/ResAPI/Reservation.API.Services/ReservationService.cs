﻿using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int BkgNumber)
        {
            return new ReservationDTO()
            {
                Id = (new Random().Next(100)),
                Amount = (new Random().Next(10000)),
                BkgDate = DateTime.Now,
                ChekinDate = DateTime.Now.Date.AddDays(30),
                ChekoutDate = DateTime.Now.Date.AddDays(37),
                BkgNumber = BkgNumber
            };
        }
    }
}
