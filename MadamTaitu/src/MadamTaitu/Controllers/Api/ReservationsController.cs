using MadamTaitu.Models;
using MadamTaitu.Models.Restaurant;
using Microsoft.AspNet.Authorization;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace MadamTaitu.Controllers.Api
{
    public class ReservationsController : Controller
    {
        private ApplicationDbContext _dataContext;

        public ReservationsController(ApplicationDbContext dataContext)
        {
            this._dataContext = dataContext;
        }

        [HttpGet("api/reservations")]
       // [Authorize]
        public JsonResult Get()
        {
            var reservations = new List<Reservation> {
                new Reservation() { Id= 1, Name="Michael", EmailAddresss="mkassa@gmail.com", NumberOfPeople=4, ReservationDate=new DateTime(2015, 02, 20, 14, 2, 1), ReservationStatus=ReservationStatus.Pending },
                new Reservation() { Id= 2, Name="Manna", EmailAddresss="manna@gmail.com", NumberOfPeople=4, ReservationDate=new DateTime(2015, 03, 20, 14, 2, 1), ReservationStatus=ReservationStatus.Approved }
            };
            
            return Json(reservations);

        }

        [HttpPost("api/reservation/update")]
        public HttpResponseMessage Update(Reservation reservation)
        {
            try
            {
                _dataContext.Reservations.Update(reservation);
                _dataContext.SaveChanges();

                return  new HttpResponseMessage(HttpStatusCode.OK) { Content= new StringContent("Reservation saved")};
                
            }
            catch (Exception exc)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content= new StringContent(exc.Message)};
            }
            
        }

        [HttpDelete("api/reservation/Delete")]
        public HttpResponseMessage Delete(Reservation reservation)
        {
            try
            {
                _dataContext.Reservations.Remove(reservation);
                _dataContext.SaveChanges();

                return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("Reservation Deleted") };

            }
            catch (Exception exc)
            {
                return new HttpResponseMessage(HttpStatusCode.InternalServerError) { Content = new StringContent(exc.Message) };
            }

        }

        public ActionResult Index()
        {
            return View();
        }
    }
}
