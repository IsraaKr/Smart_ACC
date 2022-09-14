using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_ACC_Forms
{
    public partial class F_INHERTEANCE : Form
    {
        public F_INHERTEANCE()
        {
            InitializeComponent();
        }
        public void change_states_message(string status_mess)
        {
            bar_states.Caption = "...";
            bar_states.ItemAppearance.Normal.BackColor = F_INHERTEANCE.DefaultBackColor;
            if (status_mess == "")
            {
                return;
            }
            else if (status_mess == "i")
            {
                bar_states.Caption = "             تم الإدخال بنجاح              ";
                bar_states.ItemAppearance.Normal.BackColor = Color.DarkSeaGreen;
                clear_data(this.Controls);
            }
            else if (status_mess == "u")
            {
                bar_states.Caption = "             تم التعديل بنجاح              ";
                bar_states.ItemAppearance.Normal.BackColor = Color.DarkSeaGreen;
                clear_data(this.Controls);
            }
            else if (status_mess == "d")
            {
                bar_states.Caption = "             تم الحذف بنجاح              ";
                bar_states.ItemAppearance.Normal.BackColor = Color.DarkSeaGreen;
                clear_data(this.Controls);
            }
            else
            {
                MessageBox.Show(status_mess);
                bar_states.Caption = "            فشل الإجراء             ";
                bar_states.ItemAppearance.Normal.BackColor = Color.IndianRed;
            }

        }
        //فيرتشول من اجل اعمله اوفر رايدينغ عند الوراثة و 
        // البراميتر من نوع الداتا بيس انتتي
        public virtual void get_data(string status_mess)
        {
            change_states_message(status_mess);
        }

        //الادخال
        public virtual void insert_data()
        {
            timer_states_bar.Enabled = true;

        }
        //التعديل
        public virtual void update_data()
        {
            timer_states_bar.Enabled = true;

        }
        //الحذف
        public virtual string delete_data()
        {
            timer_states_bar.Enabled = true;

            if (MessageBox.Show("هل تريد حذف البيانات ", "تنبيه !!", MessageBoxButtons.YesNo , MessageBoxIcon.Warning) == DialogResult.Yes)
                return "true";
            else
                return"false";

        }
        public virtual string delete_data( long s_id )
        {
            timer_states_bar.Enabled = true;
            /*  if (MessageBox.Show("هل تريد حذف البيانات ", "تنبيه !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                  return "true";
              else
                  return "false";*/
            return "";
        }
        //لتفريغ الحقول و لتغير جملة الستاتس
        public virtual void clear_data(Control.ControlCollection s_controls)
        {    //كود لتفريغ كل محتوى الكونترولات
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control c in controls)
                    if (c is TextBox)
                        (c as TextBox).Clear();
                    else if (c is DateEdit)
                        (c as DateEdit).DateTime = DateTime.Now;
                    else if (c is TimeEdit)
                        (c as TimeEdit).Time = DateTime.Now;

                    else if (c is LookUpEdit)
                        (c as LookUpEdit).Text = "";
                    else if (c is DateTimePicker)
                        (c as DateTimePicker).Value = DateTime.Now;
                    else if (c is System.Windows.Forms.ComboBox)
                        (c as System.Windows.Forms.ComboBox).SelectedIndex = -1;
                    else
                        func(c.Controls);
            };
            func(s_controls);
        }

        private void F_INHERTEANCE_Load(object sender, EventArgs e)
        {
            get_data("");
        }

        private void bar_save_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            insert_data();
            timer_states_bar.Enabled = true;
        }

        private void bar_edite_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            update_data();
            timer_states_bar.Enabled = true;
        }

        private void bar_delete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            delete_data(0);
            timer_states_bar.Enabled = true;
        }

        private void bar_clear_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clear_data(this.Controls);
            get_data("");
            timer_states_bar.Enabled = true;
        }

        private void timer_states_bar_Tick(object sender, EventArgs e)
        {
            change_states_message("");
            timer_states_bar.Enabled = false;
        }

        private void timer_date_Tick(object sender, EventArgs e)
        {
            bar_date.Caption = DateTime.Now.ToString();

        }

    
    }
}
