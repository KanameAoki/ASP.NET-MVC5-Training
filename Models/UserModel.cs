using System.ComponentModel;

namespace WebApplication2.Models
{
    public class UserModel
    {
        /// DisplayName属性でプロパティの名前が表示されるようになる
        [DisplayName("ユーザーID")]
        public string UserID { get; set; }

        [DisplayName("パスワード")]
        public string Password { get; set;}
    }
}