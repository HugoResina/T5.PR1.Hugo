using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjecteAccessBBDDHugo.Data;

namespace ProjecteAccessBBDDHugo.Pages
{
	public class IndexModel : PageModel
	{

		//private readonly ILogger<IndexModel> _logger;

		/*public IndexModel(ILogger<IndexModel> logger)
		{
			_logger = logger;
		}*/

		private readonly ApplicationDbContext _context;
		public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
		public void OnGet()
		{
			var Energies = _context.Simulations.ToList();

		}
	}
}
