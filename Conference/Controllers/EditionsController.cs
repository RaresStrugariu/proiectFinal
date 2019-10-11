using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Areas.Admin.Models;
using Conference.Domain.Entities;
using Conference.Models;
using Conference.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Omu.ValueInjecter;

namespace Conference.Controllers
{
    public class EditionsController : Controller
    {
      //private readonly IEditionService editionService;
      private readonly ISpeakerService speakerService;
      private readonly IWorkshopService workshopService;
      private readonly ITalkService talkService;
      public EditionsController(ISpeakerService speakerService, IWorkshopService workshopService, ITalkService talkService)
      {
         this.speakerService = speakerService;
         this.workshopService = workshopService;
         this.talkService = talkService;
      }



      
      // GET: Editions
      public ActionResult Index()
      {
         IEnumerable<Speakers> allSpeakers = speakerService.GetAllSpeakers();
         IEnumerable<Workshops> allWorkshops = workshopService.GetAllWorkshops();
         IEnumerable<Talks> allTalks = talkService.GetAllTalks();
         return View(allSpeakers);
         //IEnumerable<Editions> allEditions = editionService.GetAllEditions();
         //return View(allEditions);
      }

      // GET: Editions/Details/5
      //public ActionResult Details(int id)
      //{
      //   //Editions editions = editionService.GetEditionById(id);
      //   //EditionsViewModel1 model = new EditionsViewModel1();
      //   //model.InjectFrom(editions);
      //   //return View(editions);
      //}

      // GET: Editions/Create
      public ActionResult Create()
        {
            return View();
        }

        // POST: Editions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Editions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Editions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Editions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Editions/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}