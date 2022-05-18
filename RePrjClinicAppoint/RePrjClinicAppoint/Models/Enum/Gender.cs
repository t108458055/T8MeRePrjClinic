using System.ComponentModel.DataAnnotations;


namespace RePrjClinicAppoint.Models.Enum
{
    // 性別 屬性
    public enum Gender
    {
        [Display(Name="男性")]
        Male,
        [Display(Name = "女性")]
        Female,
    }
}
