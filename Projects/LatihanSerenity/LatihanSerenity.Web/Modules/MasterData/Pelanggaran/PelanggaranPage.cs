using Serenity;
using Serenity.Web;
using Microsoft.AspNetCore.Mvc;

namespace LatihanSerenity.MasterData.Pages
{

    [PageAuthorize(typeof(PelanggaranRow))]
    public class PelanggaranController : Controller
    {
        [Route("MasterData/Pelanggaran")]
        public ActionResult Index()
        {
            return View("~/Modules/MasterData/Pelanggaran/PelanggaranIndex.cshtml");
        }
    }
}