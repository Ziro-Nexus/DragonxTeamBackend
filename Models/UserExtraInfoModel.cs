using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DragonxTeamBackend.Models {
    
    [Table("UserExtraInfo")]
    public class UserExtraInfoModel {
        
        [Key]
        [Column(TypeName = "int")]
        public long id_user_info {get; set;}

        [Column(TypeName = "int")]
        public long id_user {get; set;}

        [Column(TypeName = "varchar(20)")]
        public string? country {get; set;}

        [Column(TypeName = "varchar(5)")]
        public string? country_code {get; set;}
        
        [Column(TypeName = "varchar(20)")]
        public string? city {get; set;}
        
        [Column(TypeName = "varchar(30)")]
        public string? cel {get; set;}
        
        [Column(TypeName = "datetime")]
        public DateTime last_connection {get; set;}

        public UserClientModel? Forkey_User {get; set;}
    }
}
