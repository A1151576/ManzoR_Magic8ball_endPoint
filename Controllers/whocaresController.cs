/* 
Rafael Manzo
Magic 8 Ball En point
10/27/2022
Peer Review : Reed Goodwin, progroam runs god nice ad short. but is a simple one. good job. 
*/
using Microsoft.AspNetCore.Mvc;

namespace ManzoR_Magic8ball_endPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class whocaresController : ControllerBase
{
    [HttpGet]
    [Route("Juegits")]

    public string Juego()
    {
        string[] randomFortune = new string[] { "I don't know about all that", "I don't wanna hear it", "Why not?", "You know you shouldn't", "I say no", "Stop bothering me", "Is that right?", "Puh!", "Perhaps..", "Pondr on it" };

        Random num = new Random();
        int guessNum = num.Next(0, 9);


        return randomFortune[guessNum];


    }
}
