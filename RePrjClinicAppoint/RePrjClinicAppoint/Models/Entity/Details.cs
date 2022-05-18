using RePrjClinicAppoint.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace RePrjClinicAppoint.Models.Entity
{  //完成服務明細
    public class Details
    {
        public int Id { get; set; }

        public virtual Appointment Appointment { get; set; }
        //成立服務
        
        public Dental dental { get; set; }
        //檢查描述
        public string Description { get; set; }
        //服務費用
        public int Price { get; set; }
        //建立日期
        public DateTime CreateDate { get; set; }

    }
}
