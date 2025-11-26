using System.ComponentModel.DataAnnotations;

namespace KitabMawkout.Data.MyData
{
    public class MySetting : SettingsVm
    {
        [Key]
        public int MySettingsId { get; set; }
    }
}
