using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProjecteAccessBBDDHugo.Data;
using ProjecteAccessBBDDHugo.Model;

namespace ProjecteAccessBBDDHugo.Pages.Energies
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Simulation Simulation { get; set; }

        public async Task<IActionResult> OnPost()
        {
            if(!ModelState.IsValid || _context.Simulations == null || Simulation == null)
            {
                return Page();
            }
            else
            {

               _context.Simulations.Add(Simulation);
                await _context.SaveChangesAsync();
                return RedirectToPage("./Simulations");
            }
        }
    }
}
