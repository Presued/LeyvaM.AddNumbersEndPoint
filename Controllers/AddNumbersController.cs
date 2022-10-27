//Manuel L.
//10-25-22
//Adding Numbers EndPoint
//The user will input two numbers and the output will be both the numbers add up
//Peer Review: Kenneth Fujimura -  Eveyrthing works as we were instructed. Program adds whole integers the way we're supposed to. Code is clean and well organized. No real bugs beyond if you have inputs that arne't whole numbers. Good Job Manuel.

using Microsoft.AspNetCore.Mvc;

namespace LeyvaM.AddNumbersEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AddNumbersController : ControllerBase
{
    [HttpGet]
    [Route("MiniCh2/{number1}/{number2}")]

    public int Math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        return convertNum1 + convertNum2;
    }
}