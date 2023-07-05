using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using crud.Models;
using crud.Data;

namespace crud.Pages.Supplier
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;
        public IList<crud.Models.Supplier> Suppliers { get; set; } = default!;
        public List<string> Specialtys = new() { "Comércio", "Serviço", "Indústria" };

        public IndexModel(ApplicationDbContext context) {
            _context = context;
        }

        public void OnGet()
        {
            if (_context.Supplier != null) {
                Suppliers = _context.Supplier.ToList();
            }
        }
    }
}
