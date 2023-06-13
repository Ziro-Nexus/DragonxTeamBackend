using DragonxTeamBackend.Db;
using DragonxTeamBackend.Models.DTO.User;
using DragonxTeamBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace DragonxTeamBackend.Repositories
{
    public class UserClientRepository
    {
        private readonly ServerContext _context;
        public UserClientRepository(ServerContext context)
        {
            this._context = context;
        }

        public async Task<string> DeleteUser(long id_user)
        {
            var user = await _context.DbUserClient.Where(user => user.id_user == id_user).ToListAsync();

            if (user.Count == 0)
                throw new Exception("User could not be found");


            var user_info = await _context.DbUserInfo.Where(user => user.id_user == id_user).ToListAsync();
            if (user_info.Count != 0) {
                _context.DbUserInfo.Remove(user_info.First());
                await _context.SaveChangesAsync();
            }

            _context.DbUserClient.Remove(user.First());
            await _context.SaveChangesAsync();

            return "User deleted";
        }

        public async Task<String> AddUser(AddUserDTO user_insert)
        {
            if (await _context.DbUserClient.AnyAsync(
                user => user.email == user_insert.email ||
                user.user_name == user_insert.user_name
            )) {
                throw new Exception("User Name or Email already exists");
            }
            var user = new UserClientModel
            {
                user_name = user_insert.user_name,
                last_name = user_insert.last_name,
                email = user_insert.email,
                password = user_insert.password,
            };

            await _context.DbUserClient.AddAsync(user);
            await _context.SaveChangesAsync();

            return "Registro guardado existosamente";
        }

        public async Task<List<UserDTO>> GetAllUsers()
        {
            return await _context.DbUserClient
            .Include(key => key.Forkey_User_Info)
            .Select(user => new UserDTO
            {
                id_user = user.id_user,
                user_name = user.user_name,
                last_name = user.last_name,
                email = user.email,
                //password = user.password,
                user_info = (user.Forkey_User_Info != null) ? new UserInfoDTO
                {
                    id_user_info = user.Forkey_User_Info.id_user_info,
                    id_user = user.id_user,
                    cel = user.Forkey_User_Info.cel,
                    city = user.Forkey_User_Info.city,
                    country = user.Forkey_User_Info.country,
                    country_code = user.Forkey_User_Info.country_code,
                    last_connection = user.Forkey_User_Info.last_connection,
                } : null

            }).ToListAsync();
        }
    }
}
