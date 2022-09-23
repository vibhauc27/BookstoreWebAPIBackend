using BussinessLayer.Interface;
using CommonLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookstoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserBL iUserBl;

        public UserController(IUserBL iUserBl)
        {
            this.iUserBl = iUserBl;
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Registration(RegisterModel userRegistration)
        {
            try
            {
                var result = this.iUserBl.Registration(userRegistration);
                if (result != null)
                {
                    return Ok(new { success = true, message = "Registration Successfull" });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Registration UnSuceessfull" });
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginModel loginModel)
        {
            try
            {
                var result = this.iUserBl.Login(loginModel);
                if (result != null)
                {
                    return Ok(new { success = true, message = "Login Successfull" });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Login UnSuceessfull" });
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("ForgetPassword")]
        public IActionResult ForgetPassword(string EmailId)
        {
            try
            {
                var result = this.iUserBl.ForgetPassword(EmailId);
                if (result != null)
                {
                    return Ok(new { success = true, message = "Mail Sent Successfully" });
                }
                else
                {
                    return BadRequest(new { success = false, message = "Mail UnSuceessfull" });
                }
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
