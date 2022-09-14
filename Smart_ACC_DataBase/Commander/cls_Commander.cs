using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//وظيفته بناء الميثود التي قمت بإنشائها في الانترفيس
//الكلاس يحمل نفس البروبرتي تبع الانترفيس لذا ياخذ نفس الداتا 
//يرث من الانترفيس و الاثنين ياخذو داتا من نوع تي انتتي
//حيث عامل التي انتتي مثل الكلاس

namespace Smart_ACC_DataBase.Commander
{
    //اسم الوعاء الذي بداخله الداتا بيس كاملة  نجده في 
    /*ملف الانتتي .edmx 
    ثم ملف الانتتي .context.tt
    ثم ملف الانتتي .context.cs */

   public class cls_Commander<Tentity> : ICommander<Tentity> where Tentity : class
    {
        SMART_ACC_DB_2022Entities context = new SMART_ACC_DB_2022Entities();
        public void insert_data(Tentity entity)
        {
            context.Set<Tentity>().Add(entity);
            context.SaveChanges();
            //يعني خذ من الداتا بيس التي انتتي الي معرفو ك براميتر و ضفلو الانتتي 
            //السيت لتحديد اي جدول سنتعامل معه من الداتا يس
        }
        public void update_data(Tentity entity)
        {
            context.Set<Tentity>().AddOrUpdate(entity);
            context.SaveChanges();
        }
        public void delet_data(Tentity entity)
        {
            context.Set<Tentity>().Remove(entity);
            context.SaveChanges();
        }
        public IEnumerable<Tentity> get_all()
        {
            return context.Set<Tentity>().ToList();
        }
        public IEnumerable<Tentity> get_by(Expression<Func<Tentity, bool>> p)
        {
            return context.Set<Tentity>().Where(p);
        } 
        public IEnumerable<Tentity> max_id(Expression<Func<Tentity, bool>> p)
        {
            return context.Set<Tentity>().Where(p);
        }
    }
}
