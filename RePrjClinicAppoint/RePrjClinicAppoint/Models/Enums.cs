using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace RePrjClinicAppoint.Models
{
    public class Enums
    {
    }
    /// <summary>
    /// 登入狀態
    /// </summary>
    public enum LoginStatus
    {
        /// <summary>成功</summary>
        [Column("成功")]
        SUCCESS = 1,
        /// <summary>失敗</summary>
        [Column("失敗")]
        FAIL = 0
    }
    /// <summary>
    /// 登入狀態
    /// </summary>
    public enum UserTypes
    {  /// <summary>管理者</summary>
        [Column("管理者")]
        admin,
        /// <summary>醫生</summary>
        [Column("醫生")]
        doctor,
        /// <summary>病人</summary>
        [Column("病人")]
        patinet
    }

    ////ref:https://www.isaacsongentledentistry.com/blog/post/12-common-dental-services-you-should-know.html
    //牙醫服務
    public enum DentalService
    {
        [Display(Name = "牙齒清潔")]
        [Column("牙齒清潔")]
        ThootCleanings,
        [Display(Name = "假牙")]
        Dentures,
        [Display(Name = "根管治療")]
        RootCanalTherapy,
        [Display(Name = "牙齒密封")]
        DentalSealants,
        [Display(Name = "牙齒美白")]
        Whitening,
        [Display(Name = "拔牙")]
        Extractions,
        [Display(Name = "其他")]
        Other
    }
    /// <summary>
    /// 服務狀態
    /// </summary>
    public enum ServiceStatus 
    {
        [Column("預約")]
        Reservation,
        [Column("進行中")]
        Proceeing,
        [Column("已結案")]
        Proceed,
        [Column("取消")]
        Cancel,
        [Column("完成")]
        Finished,
    }

    // 性別 屬性
    public enum Gender
    {
        [Column("男")]
        [Display(Name = "男")]
        male,
        [Column("女")]
        [Display(Name = "女")]
        female,
    }
}
