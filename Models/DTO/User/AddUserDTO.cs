using DragonxTeamBackend.Models;

namespace DragonxTeamBackend.Models.DTO.User {
    public class AddUserDTO {
        public long id_user { get; set; }
        public string? user_name { get; set; }
        public string? last_name { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }
    }
}
