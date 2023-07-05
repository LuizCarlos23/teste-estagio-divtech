using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using crud.Data;
using crud.Models;

namespace crud.Pages.Supplier
{
    public class DeleteModel : PageModel
    {

        private readonly ApplicationDbContext _context;
        [BindProperty]
        public crud.Models.Supplier Supplier { get; set; } = default!;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> OnPostAsync(int? id)
        {
            Console.WriteLine("Teste");
            if (id == null || _context.Supplier == null)
            {
                return NotFound();
            }
            var supplier = await _context.Supplier.FindAsync(id);

            if (supplier != null)
            {
                Supplier = supplier;
                _context.Supplier.Remove(supplier);
                await _context.SaveChangesAsync();
            }

            return Content("Fornecedor removido com sucesso!");
        }
        public void OnGet()
        {
        }
    }
}
