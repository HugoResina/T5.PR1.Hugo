using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjecteAccessBBDDHugo.Data;
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
            if(id == null||_context.Simulations == null)
			{
				return NotFound();
			}
            var simulation = await _context.Simulations.FirstOrDefaultAsync(s => s.Id == id);
            if(simulation == null)
            {
                return NotFound();
            }
            Simulation = simulation;
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
		{
			if(!ModelState.IsValid)
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
