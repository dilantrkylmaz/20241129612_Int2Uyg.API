using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Int2Uyg.API.Controllers
{

    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("api/test")]
        public string Test()
        {
            return "Bu Bir Test";
        }

        [HttpGet]
        [Route("api/number")]
        public int number()
        {
            return Random.Shared.Next(100);
        }

        [HttpGet]
        [Route("api/stringlist")]
        public List<string> StringList()
        {
            var list = new List<string>();
            list.Add("Antalya");
            list.Add("Ankara");
            list.Add("İzmir");
            list.Add("Kars");
            list.Add("İstanbul");
            return list;
        }

        [HttpGet]
        [Route("api/intlist")]
        public List<int> IntList()
        {
            var list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(Random.Shared.Next(100));
            }

            return list;
        }

        [HttpGet]
        [Route("api/karesi/{s1}")]

        public int Karesi(int s1)
        {
            return s1 * s1;
        }

        [HttpGet]
        [Route("api/ort/{s1}/{s2}")]

        public double Ortalama(int s1, int s2)
        {
            return s1 * 0.4 + s2 * 0.6;
        }

    }
}
