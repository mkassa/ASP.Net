using MadamTaitu.DAL;
using Microsoft.AspNet.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MadamTaitu.Controllers
{
    public abstract class MadamTaituController : Controller
    {
        protected ApplicationDbContext _dbContext;

        public MadamTaituController(ApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
