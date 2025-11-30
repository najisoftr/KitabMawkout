using Batoulapps.Adhan;
using System.ComponentModel.DataAnnotations;

namespace KitabMawkout.Data.MyData
{
    public class SettingsVm
    {
        [Required(ErrorMessage ="رقم الطول إجباري")]
        public double? Longitude { get; set; }

        [Required(ErrorMessage ="رقم دائرة العرض إجباري")]
        public double? Latitude { get; set; }


        [Required(ErrorMessage ="يرجى اختيار طريقة الحساب")]
        public Madhab? MyMadhab { get; set; }

        [Required(ErrorMessage ="يرجى اختيار المذهب")]
        public CalculationMethod? MyCalculationMethode { get; set; }

        [Required(ErrorMessage ="يرجى اختيار إسم المسجد")]
        [Length(5, 512, ErrorMessage ="إسم المسجد بين 5 و 512 حرفا")]
        public string? DesMasjid { get; set; } = string.Empty;

        [Required(ErrorMessage ="يرجى اختيار المجال الزمني لمدينتك")]
        public string? TimeZoneId { get; set; } = string.Empty;
    }
}
