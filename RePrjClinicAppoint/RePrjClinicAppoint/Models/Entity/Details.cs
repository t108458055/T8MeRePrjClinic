using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RePrjClinicAppoint.Models.Entity
{ 
    /// <summary>
    /// 完成明細
    /// </summary>
    public class Details: DentalEntityAbstract
    {
        //FK
        public virtual Appointment Appointment { get; set; }
        //檢查描述
        public string description { get; set; }
        //服務費用
        [Column(TypeName = "decimal(18,2)")]
        public Decimal price { get; set; }
        //狀態完成
        [Required]
        public bool isFinishStatus { get; set; }
    }
}
