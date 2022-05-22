using RePrjClinicAppoint.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RePrjClinicAppoint.Models.Entity
{ //醫生 資料表 自動屬性 This is Service Layer 
    public class Doctor
    {
        //id Primary Key
        [Key]
        public int DoctorId { get; set; }
        //帳號
   
        public string Account { get; set; }
        //密碼

        public string Password { get; set; }
        //電子信箱
        public string Email { get; set; }
        //連絡電話
        
        public string Phone { get; set; }
        // 姓名
        public string Name { get; set; }
        //性別
        public Gender gender { get; set; }
        //年齡
        public int Age { get; set; }
        //專業技術描述
        public string Description { get; set; }
        //帳戶建立日期
        [Required]
        public DateTime CreateDate { get; set; }
    }
}
