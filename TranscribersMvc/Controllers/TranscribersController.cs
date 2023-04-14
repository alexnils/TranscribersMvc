using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TranscribersMvc.Models;
using TranscribersMvc.Views.Transcribers;

namespace TranscribersMvc.Controllers
{
    public class TranscribersController : Controller
    {


        DataService dataService;

        public TranscribersController(DataService dataService)
        {
            this.dataService = dataService;
        }


        [HttpGet("")]
        public IActionResult Index()

        {
            IndexVM model =  dataService.GetTranscriber();
            return View(model);
        }

        [HttpPost("")]
        public IActionResult Index(IndexVM model)
        {
            model = dataService.TranscribeText(model);
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View(model);
        }

    }


}
