using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjecteAccessBBDDHugo.Data;
using ProjecteAccessBBDDHugo.Migrations;
using ProjecteAccessBBDDHugo.Model;

namespace ProjecteAccessBBDDHugo.Pages.Energies
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public EditModel(ApplicationDbContext context)
		{
			_context = context;
		}
        [BindProperty]
        public Simulation Simulation { get; set; }

		public async Task<IActionResult> OnGetAsync(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			Simulation = await _context.Simulations.FirstOrDefaultAsync(m => m.Id == id);
			if (Simulation == null)
			{
				return NotFound();
			}
			return Page();

		}

        public async Task<IActionResult> OnPostAsync()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			else
			{
				_context.Simulations.Update(Simulation);
				await _context.SaveChangesAsync();
				return RedirectToPage("./Simulations");
			}
		}
    }
}
