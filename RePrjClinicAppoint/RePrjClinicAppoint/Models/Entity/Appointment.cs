using RePrjClinicAppoint.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RePrjClinicAppoint.Models.Entity
{ 
    public class Appointment
    {
        //id Primary Key
        [Key]
        public int ServerId { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        //預約服務
        public Dental dental { get; set; }
        //自我描述目前病因
        public string Description { get; set; }
        //建立日期
        [Required]
        public DateTime CreateDate { get; set; }
        //開始日期
        [Required]
        public DateTime StartDate { get; set; }
        //結束日期
        [Required]
        public DateTime EndDate { get; set; }
        //取消日期
        public DateTime? CancelDate { get; set; }
        //資料更新日期
        public DateTime UpdateDate { get; set; }
        //狀態完成
        [Required]
        public bool Status { get; set; }
    }
}
