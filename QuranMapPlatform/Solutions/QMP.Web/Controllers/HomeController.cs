using Framework.Data.NHibernate.Contracts.Repositories;
using QMP.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace QMP.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public HomeController(INHibernateRepository<FactValueType> valueTypeRepository)
        {
            this.valueTypeRepository = valueTypeRepository;
        }
        private readonly INHibernateRepository<FactValueType> valueTypeRepository;
        public ActionResult Index()
        {
            //FactValueType val1 = new FactValueType();
            //val1.Constant = "Number";
            //val1.Name = "Number";
            //valueTypeRepository.Save(val1);
            //valueTypeRepository.DbContext.CommitChanges();
            return View();
        }
    }
}
