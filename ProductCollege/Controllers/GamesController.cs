using Microsoft.AspNetCore.Mvc;
using ProductCollege.Models;
using System.Net;

namespace ProductCollege.Controllers
{
    public class GamesController : Controller
    {
        private readonly IserviceRepo _serviceRepo;
        public GamesController(IserviceRepo serviceRepo)
        {
            _serviceRepo = serviceRepo;
        }



        public IActionResult GamesShow()
        {
            var data = _serviceRepo.GetallGames();
            return View();
        }
        [HttpGet]
        public IActionResult InsertGame()
        {

            return View();
        }
        [HttpPost]
        public IActionResult InsertGame(Game game)
        {

            return View();
        }

        [HttpGet]
        public IActionResult BroadLive()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveRecoredFile()
        {
            if (Request.Form.Files.Any())
            {
                var file = Request.Form.Files["video-blob"];
                string UploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "UploadedFiles");
                string UniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName + ".webm";
                string UploadPath = Path.Combine(UploadFolder, UniqueFileName);
                await file.CopyToAsync(new FileStream(UploadPath, FileMode.Create));
            }
            return Json(HttpStatusCode.OK);
        }

        [HttpGet]
        public IActionResult BroadLiveShow()
        {
            return View();
        }
    }
}
