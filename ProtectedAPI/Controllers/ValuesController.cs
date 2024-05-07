using Microsoft.AspNetCore.Mvc;

namespace ProtectedAPI.Controllers
{
    public class ValuesController : ControllerBase
    {
        [HttpGet("about/me")]
        public IActionResult GetAboutMe()
        {
            var randomInfo = GenerateRandomFact();

            return Ok(randomInfo);
        }

        private string GenerateRandomFact()
        {
            string randomFact = "Dogs belong to the taxonomic family " +
                "Canidae (canines) which is divided into two tribes: " +
                "those related to wolves (Canini) and those related to foxes (Vulpini).";
            return randomFact;
        }

        [HttpGet("about")]
        public IActionResult GetAbout()
        {
            string itsme = "Rb Lingling";
            return Ok(new { Itsme = itsme});
        }


        [HttpPost("about")]
        public IActionResult PostAbout([FromBody] string name) 
        {
            string me = "Rb Lingling";

            string msg = $"Greetings, my fellow Earthlings {name} a salutation from {me}";
            return Ok(new { message = msg, });
        }

        [HttpGet("meFacts")]

        public IActionResult MeFacts()
        {
            var MeFacts = new List<string>
            {
                "Both of my first names came from my Grandmas",
                "I have a mild heart failure/problem",
                "I f'en love playing MMORPG games",
                "I love gaming in general XD",
                "Branded as a sharp-shooter in Basketball",
                "I don't like being an IT D:"
            };
            return Ok(MeFacts);
        }
    }
}