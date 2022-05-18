using RePrjClinicAppoint.Models.Enum;
using System;
using System.ComponentModel.DataAnnotations;


namespace RePrjClinicAppoint.Models.Entity
{//病人 資料表 自動屬性
    public class Patient
    {
        //id Primary Key
        [Key]
        public int PatientId { get; set; }
        //帳號
        [Required]
        public string Account { get; set; }
        //密碼
        [Required]
        public string Password { get; set; }
        //電子信箱
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        //連絡電話
        [Phone]
        public string Phone { get; set; }
        // 姓名
        public string Name { get; set; }
        //性別
        public Gender gender { get; set; }
        //年齡
        public int Age { get; set; }
        //自我描述目前病因
        public string Description { get; set; }
        // 電子信箱確認
        public bool IsMailConfirm { get; set; }
        // 門號確認
        public bool IsPhoneConfirm { get; set; }
        //帳戶建立日期
        public DateTime CreateDate { get; set; }
        //帳戶資料更新日期
        public DateTime? UpdateDate { get; set; }

    }
}
