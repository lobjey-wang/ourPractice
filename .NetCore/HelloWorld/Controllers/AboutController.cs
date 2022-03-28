using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class AboutController : Controller
    {
        public string Phone()
        {
            return "10086";
        }

        public string Conyry()
        {
            return "China";
        }
    }
}
