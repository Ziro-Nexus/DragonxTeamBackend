using Microsoft.AspNetCore.Mvc;

using DragonxTeamBackend.Db;
using DragonxTeamBackend.Models.DTO.User;
using DragonxTeamBackend.Repositories;

namespace DragonxTeamBackend.Controllers {
    
    [Route("api/[controller]")]
    [ApiController]
    public class UserClientController : ControllerBase {
        private readonly UserClientRepository user_repo;
        public UserClientController(UserClientRepository repo) {
            user_repo = repo;
        }

        [HttpDelete("DeleteUser/{id}")]
        public async Task<ActionResult> DeleteUser(long id) {
            try
            {
                var response = await user_repo.DeleteUser(id);
                return Ok(response);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("AddUser")]
        public async Task<ActionResult> AddUser([FromBody] AddUserDTO user) {
            try
            {
                var response = await user_repo.AddUser(user);
                return Ok(response);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllUsers() {
           try
            {
                var response = await user_repo.GetAllUsers();
                return Ok(response);
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
