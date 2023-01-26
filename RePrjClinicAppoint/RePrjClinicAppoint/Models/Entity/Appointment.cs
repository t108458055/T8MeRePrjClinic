using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RePrjClinicAppoint.Models.Entity
{
    /// <summary>
    /// 服務預約
    /// </summary>
    public class Appointment : DentalEntityAbstract
    {
        //FK 預約哪位醫生
        public virtual Doctor Doctor { get; set; }
        //FK //哪位人預約的
        public virtual Patient Patient { get; set; }
        //預約服務
        [NotMapped]
        public DentalService dentalServices { get; set; }
        /// <summary>
        /// 預約服務
        /// </summary>
        public string appointService
        {
            get { return dentalServices.ToString(); }
            set
            {
                DentalService result;
                if (!Enum.TryParse<DentalService>(value, out result))
                    throw new ApplicationException($"Can't convert '{value}' to type [{typeof(DentalService)}]");
                this.dentalServices = result;
            }
        }

        /// <summary>
        /// 自我描述目前病因
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// 預約開始日
        /// </summary>
        [Required]
        public DateTime startDate { get; set; }
        /// <summary>
        /// 預約結束日
        /// </summary>
        [Required]
        public DateTime endDate { get; set; }
        /// <summary>
        /// 預約取消日
        /// </summary>
        public DateTime? cancelDate { get; set; }
        [NotMapped]
        public ServiceStatus serviceStatustype { get; set; }
        /// <summary>
        /// 預約狀態
        /// </summary>
        public string serviceStatus{
            get
            {
                return serviceStatustype.ToString();
            }
            set
            {
                ServiceStatus result;
                if (!Enum.TryParse<ServiceStatus>(value, out result))
                    throw new ApplicationException($"Can't convert '{value}' to type [{typeof(ServiceStatus)}]");
                this.serviceStatustype = result;
            }
        }
        /// <summary>
        ///  狀態完成
        /// </summary>
        [Required]
        public bool isFinish { get; set; }
    }
}
