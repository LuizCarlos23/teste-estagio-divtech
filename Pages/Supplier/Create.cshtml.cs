using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using crud.Data;
using crud.Models;

namespace crud.Pages.Supplier
{
    public class CreateModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        // public Specialty Specialtys { get; set }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

         public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public crud.Models.Supplier Supplier { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Supplier == null || Supplier == null)
            {
                return Page();
            }

            _context.Supplier.Add(Supplier);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
