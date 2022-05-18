using System.ComponentModel.DataAnnotations;

//ref:https://www.isaacsongentledentistry.com/blog/post/12-common-dental-services-you-should-know.html
namespace RePrjClinicAppoint.Models.Enum
{ //牙醫服務
    public enum Dental
    {
        [Display(Name = "牙齒清潔")]
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
}
