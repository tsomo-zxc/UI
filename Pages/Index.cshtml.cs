using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        public IFormFile StyleFile { get; set; }

        public string GeneratedImagePath { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            // TODO: ������ Python-������� ��� ��������� ����� Stable Diffusion
            // ���������, Process.Start("python", "generate.py " + Description);

            // ���� �� ������� ���������
            GeneratedImagePath = "/images/generated_example.png";

            return Page();
        }
    }
}
