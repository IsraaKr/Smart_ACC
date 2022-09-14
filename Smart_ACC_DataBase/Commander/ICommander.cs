using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;//من اجل الاكسبريشن

namespace Smart_ACC_DataBase.Commander
{
    //الكومندر هو المحرك و الدينمو تبع الانتتي فريم ورك

    //الهدف منها عمل اوبجكت جاهزة لعمل كل شي نريد بنائه يكون موجود داخلها
    //فيها كل التوابع التي كننا ننشئها بالداتا سيت
    //insert/update/delete/max/getall/getby
    interface ICommander<Tentity>
    {
         //نوع الداتا التي تمر داخل الانترفس هو Tentity
        //لاستخدام الانترفيس نعمل منها انستنس اوبجكت مثل الكلاس

        //Tentity   هو نوع جدول من الانتتي
        void insert_data(Tentity entity);//لايعيد قيمة و نرسل له براميتر من نوع تي انتتي
        void update_data(Tentity entity);
        void delet_data(Tentity entity);
        IEnumerable<Tentity> get_all();//يعيد قيمة
                                       //ايمبريل
                                       //هذا النوع لانها تعيد قيمة هذه خاصة بالبيانات العائدة من النتتي فريمورك
        IEnumerable<Tentity> get_by(Expression<Func<Tentity, bool>> p);
        //تابع يعيد قيمة من نوع تي انتتي
        //نمرر له اكسبريشن من نوع فانكشن خاص بالانتتي فريمورك و نوع الفانكشن تي انتتي
        //بوليان لنرى النتيجة هل  رجع داتا او لا
        // البي هي اسم الاكسبريشن
        IEnumerable<Tentity> max_id(Expression<Func<Tentity, bool>> p);
    }
}

