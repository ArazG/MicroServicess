using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Models;
using Reservation.API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservation.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IReservationService reservationService;

        public ResController(IReservationService ReservationService)
        {
            reservationService = ReservationService;
        }

        [HttpGet("{Id}")]
        public ReservationDTO Get(int Id)
        {
            return reservationService.GetResByBkgNumber(Id);
        }
    }
}
