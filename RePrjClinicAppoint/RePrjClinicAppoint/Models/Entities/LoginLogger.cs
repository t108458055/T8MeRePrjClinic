using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RePrjClinicAppoint.Models.Entities
{
    public class LoginLogger:DentalEntityAbstract
    {
        /// <summary>
        /// 輸入的帳號
        /// </summary>
        [Display(Name = "輸入的帳號")]
        public string accessUserId { get; set; }
        [Display(Name = "登入者IP")]
        [StringLength(200, ErrorMessage = "{0}長度不能超過{1}字元")]
        public string loginIp { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        [Display(Name = "備註")]
        [StringLength(200, ErrorMessage = "{0}長度不能超過{1}字元")]
        public string remark { get; set; }
    }
}
