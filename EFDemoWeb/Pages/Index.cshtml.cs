using EFDataAccess.DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFDemoWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext db;

        public IndexModel(ILogger<IndexModel> logger, PeopleContext db)
        {
            _logger = logger;
            this.db = db;
        }

        public void OnGet()
        {

        }

        private void LoadSampleData()
        {
            if(db.People.Count() == 0)
            {
                String file = System.IO.File.ReadAllText("generated.json");
            }
        }
    }
}
