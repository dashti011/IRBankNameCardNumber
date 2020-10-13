 public static class CardHolderBankFaName
    {
        /// <summary>
        /// پیش شماره کارت بانک‌های مختلف
        /// </summary>
        /// <param name="number">  شش رقم اول شماره کارت بانکی یا شماره کامل کارت</param>
        /// <returns>نام بانک</returns>
        public  static string BankNameBasedCardHolderNumber(this string number)
        {
            if (string.IsNullOrWhiteSpace(number)) return "";

            if (number.Length > 6) number = number.Substring(0, 6);

            switch (number)
            {
                case "603770":
                case "639217":
                    return "بانک کشاورزی";
                case "589210":
                    return "بانک سپه";
                case "628023":
                    return "بانک مسکن";
                case "603799":
                    return "بانک ملی";
                case "627760":
                    return "پست بانک ایران";
                case "627648":
                case "207177":
                    return "بانک توسعه صادرات ایران";
                case "627961":
                    return "بانک صنعت و معدن";
                case "502908":
                    return "بانک توسعه تعاون";
                case "589463":
                    return "بانک رفاه کارگران";
                case "603769":
                    return "بانک صادرات ایران";
                case "627353":
                    return "بانک تجارت";
                case "610433":
                case "991975":
                    return "بانک ملت";
                case "627381":
                    return "بانک انصار";
                case "639347":
                case "502229":
                    return "بانک پاسارگاد";

                case "639194":
                case "622106":
                case "627884":
                    return "بانک پارسیان";

                case "621986":
                    return "بانک سامان";
                case "639607":
                    return "بانک سرمایه";

                case "627412":
                    return "بانک اقتصاد نوین";

                case "502806":
                case "504706":
                    return "بانک شهر";

                case "639346":
                    return "بانک سینا";

                case "502938":
                    return "بانک دی";

                case "505785":
                    return "بانک ایران زمین";
                case "639599":
                    return "بانک قوامین";
                case "636214":
                    return "بانک آینده";
                case "636949":
                    return "بانک حکمت ایرانیان";
                case "505416":
                    return "بانک گردشگری";
                case "627488":
                case "502910":
                    return "بانک کارآفرین";
                case "639370":
                case "606737":
                    return "بانک مهر اقتصاد";
                case "628157":
                    return "موسسه اعتباری توسعه";
                case "505801":
                    return "موسسه اعتباری کوثر";
                case "606373":
                    return "بانک  مهر ایران";
                case "636795":
                    return "بانک مرکزی"; 
                case "606256":
                    return "موسسه مؤسسه اعتباری ملل (عسکریه)";
                case "504172":
                    return "بانک قرض الحسنه رسالت";
                case "505809":
                    return "بانک خاورمیانه";

                default:
                    return "بانک نا مشخص";
            }

        }
    }
