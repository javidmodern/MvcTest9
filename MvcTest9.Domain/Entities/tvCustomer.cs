using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcTest9.Domain.Entities
{
    public class tvCustomer
    {
        [Key]
        public int numCustomerCode { set; get; }
        public string strMobile { set; get; }
        public string strName { get; set; }
        public string strTel { get; set; }
        public string strEmail { get; set; }
        public int numTelegramChatID { get; set; }
        public string strOstanRef { get; set; }
        public string strCityRef { get; set; }
        public string strLastAddress { get; set; }
        public string dtEnterDate { get; set; }
        public int numEnterRefCode { get; set; }
        public int numStatus { get; set; }
        public int numSex { get; set; }
        public int numEmailIsValid { get; set; }
        public string dtBirthDay { get; set; }
        public string dtMarriageDay { get; set; }
        public string dtRegisterDate { get; set; }
        public int numSumHistoryBuyCnt { get; set; }        
    }
}
