using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public interface IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int BkgNumber);
    }
}
