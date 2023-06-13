using DragonxTeamBackend.Models;

namespace DragonxTeamBackend.Models.DTO.User {
    public class UserInfoDTO {

        public long id_user_info {get; set;}
        public long id_user {get; set;}
        public string? country {get; set;}
        public string? country_code {get; set;}
        public string? city {get; set;}
        public string? cel {get; set;}
        public DateTime last_connection {get; set;}
    }
}
