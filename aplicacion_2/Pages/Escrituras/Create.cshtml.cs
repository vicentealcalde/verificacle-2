using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aplicacion_2.Pages.Escrituras
{
    public class CreateModel : PageModel
    {
        public Escritura escritura = new Escritura();
        public void OnGet()
        {
        }

        public void OnPost()
        {
            escritura.CNE = Request.Form["CNE"];
            escritura.NumAtencion = Request.Form["NumAtencion"];
            escritura.Manzana = Request.Form["Manzana"];
            escritura.Predio = Request.Form["predio"];
            escritura.Fojas = Request.Form["Fojas"];

        }
    }
}
