using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RePrjClinicAppoint.Models
{
    public abstract class DentalEntityAbstract
    {
        [Key]
        public virtual int Id { get; set; }
        /// <summary>
        /// 創建者
        /// </summary>
        public string creater { get; set; }
        /// <summary>
        /// 創建日
        /// </summary>
        public DateTime? creationDate { get; set; }
        /// <summary>
        /// 修改者
        /// </summary>
        public string modifier { get; set; }
        /// <summary>
        /// 修改日
        /// </summary>
        public DateTime? modifiedDate { get; set;}
        /// <summary>
        /// 是否被移出
        /// </summary>
        public bool isRemoved { get; set; }
    }

    public abstract class DentalAccountEntityAbstract:DentalEntityAbstract
    {
        /// <summary>
        /// 帳號
        /// </summary>
        public string account { get; set; }
        /// <summary>
        /// 密碼
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// 電子信箱
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 電話
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
        [NotMapped]
        public Gender gendertype { get; set; }
        /// <summary>
        /// 性別
        /// </summary>
        public string gender
        {
            get { return gendertype.ToString(); }
            set
            {
                Gender result;
                if (!Enum.TryParse<Gender>(value, out result))
                    throw new ApplicationException($"Can't convert '{value}' to type [{typeof(Gender)}]");
                this.gendertype = result;
            }
        }
        /// <summary>
        /// 年齡
        /// </summary>
        public int age { get; set; }
        /// <summary>
        /// 備註
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 是否啟用
        /// </summary>
        public bool IsConfirm { get; set; }
    }
}
