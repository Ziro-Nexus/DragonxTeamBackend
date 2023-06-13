using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DragonxTeamBackend.Models {

    [Table("UserClient")]
    public class UserClientModel {
        
        [Key]
        [Column(TypeName = "int")]
        public long id_user { get; set; }

        [Key]
        [Column(TypeName = "varchar(30)")]
        public string? user_name { get; set; }

        [Key]
        [Column(TypeName = "varchar(30)")]
        public string? last_name { get; set; }

        [Key]
        [Column(TypeName = "varchar(40)")]
        public string? email { get; set; }

        [Key]
        [Column(TypeName = "varchar(20)")]
        public string? password { get; set; }

        public UserExtraInfoModel Forkey_User_Info {get; set;}
    }
}
