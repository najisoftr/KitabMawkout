using Microsoft.EntityFrameworkCore;

namespace KitabMawkout.Data.MyData.Repositories
{
    public class MySettingsRepo
    {
        private readonly MyDbContext db;
        public MySettingsRepo(MyDbContext db)
        {
            this.db = db;
        }

        //get settings
        public async Task<SettingsVm?> GetSettingAsync()
        {
            if(db.MySettings is null || db.MySettings.Count()<=0)
            {
                return new SettingsVm();
            }
            else
            {
                var seting = await db.MySettings.FirstOrDefaultAsync();
                return new SettingsVm
                {
                    DesMasjid = seting!.DesMasjid,
                    Latitude = seting.Latitude,
                    Longitude = seting.Longitude,
                    MyCalculationMethode = seting.MyCalculationMethode,
                    MyMadhab = seting.MyMadhab
                };
            }
        }

        //set settings
        public async Task SetSettingAsync(SettingsVm? seting)
        {
            if (seting is null)
                return;
            var setin =await db.MySettings.FirstOrDefaultAsync();
            if(setin is null)
            {
                await db.MySettings.AddAsync(new MySetting
                {
                    DesMasjid = seting!.DesMasjid,
                    Latitude = seting.Latitude,
                    Longitude = seting.Longitude,
                    MyCalculationMethode = seting.MyCalculationMethode,
                    MyMadhab = seting.MyMadhab,
                    MySettingsId = 1
                });
            }
            else
            {
                setin.MyMadhab = seting.MyMadhab;
                setin.MyCalculationMethode = seting.MyCalculationMethode;
                setin.Longitude=seting.Longitude;
                setin.Latitude=seting.Latitude;
                setin.DesMasjid= seting.DesMasjid;
            }
            await db.SaveChangesAsync();
        }



    }
}
