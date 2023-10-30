using Microsoft.AspNetCore.Mvc;
using Wolk.Models;

using FluentFTP;

namespace Wolk.Controllers
{
    [ApiController]
    public class ConnectionController : Controller
    {
        [HttpPost("connect")]
        public IActionResult ConnectToFTPServer([FromQuery]string host, [FromBody] UserCredentials credentials)
        {
            var client = new FtpClient(host, credentials.UserName, credentials.Password);

            bool isConnected;
            try
            {
                client.Connect();
                isConnected = true;
            }
            catch
            {
                isConnected = false;
            }
            
            return Ok(isConnected);
        }
    }
}
