using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjecteAccessBBDDHugo.Data;
using ProjecteAccessBBDDHugo.Model;

namespace ProjecteAccessBBDDHugo.Pages.Energies
{

    public class EnergiesModel : PageModel
    {
		public IList<Simulation> Energies { get; set; }
		private readonly ApplicationDbContext _context;
		public EnergiesModel(ApplicationDbContext context)
		{
			_context = context;
		}
		public void OnGet()
		{

			Energies = _context.Simulations.ToList();
			

		}



	}
}
