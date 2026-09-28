using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace UzenetWcf.Models
{
    [DataContract]
    public class Uzenet
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Szoveg { get; set; }

        [IgnoreDataMember]
        public DateTime KuldesiIdo { get; set; }

     
        [DataMember(Name = "KuldesiIdo")]
        public string KuldesiIdoSzoveg
        {
            get { return KuldesiIdo.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture); }
            set
            {
                DateTime d;
                KuldesiIdo = DateTime.TryParse(value, CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out d) ? d : DateTime.MinValue;
            }
        }
        [DataMember]
        public string UzenetTipus { get; set; }

        [DataMember]
        public string Telefon { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
