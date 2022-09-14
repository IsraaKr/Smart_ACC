using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smart_ACC_DataBase;
using Smart_ACC_DataBase.Commander;


namespace Smart_ACC_Forms.Data_Forms
{
    public partial class f_company :F_INHERTEANCE
    {
        public f_company()
        {
            InitializeComponent();
        }
        cls_Commander<T_COMPANY_INFO> cmd_company = new cls_Commander<T_COMPANY_INFO>();
        T_COMPANY_INFO cOMPANY_INFO;
        
        private void f_company_Load(object sender, EventArgs e)
        {
            get_data("");           
        }
        public void fill_controls()
        {
            if (cOMPANY_INFO != null)
            {
                txt_id.Text = cOMPANY_INFO.com_id.ToString();
                txt_code.Text = cOMPANY_INFO.com_code.ToString();
                txt_name.Text = cOMPANY_INFO.com_name;
                txt_phone1.Text = cOMPANY_INFO.com_mobile1;
                txt_phone2.Text = cOMPANY_INFO.com_mobile2;
                txt_phone3.Text = cOMPANY_INFO.com_mobile3;
                txt_adress1.Text = cOMPANY_INFO.com_adress1;
                txt_adress2.Text = cOMPANY_INFO.com_adress2;
                txt_adress3.Text = cOMPANY_INFO.com_adress3;
                txt_fax.Text = cOMPANY_INFO.com_fax;
                txt_note.Text = cOMPANY_INFO.com_notes;
                txt_details.Text = cOMPANY_INFO.com_title;
            }

        }
        public void fill_entitey()
        {
            cOMPANY_INFO.com_id = Convert.ToUInt64(txt_id.Text);
                cOMPANY_INFO.com_code = Convert.ToUInt64(txt_code.Text);
                cOMPANY_INFO.com_name = txt_name.Text;
                cOMPANY_INFO.com_mobile1 = txt_phone1.Text;
                cOMPANY_INFO.com_mobile2 = txt_phone2.Text;
                cOMPANY_INFO.com_mobile3 = txt_phone3.Text;
                cOMPANY_INFO.com_adress1 = txt_adress1.Text;
                cOMPANY_INFO.com_adress2 = txt_adress2.Text;
                cOMPANY_INFO.com_adress3 = txt_adress3.Text;
                cOMPANY_INFO.com_fax = txt_fax.Text;
                cOMPANY_INFO.com_notes = txt_note.Text;
                cOMPANY_INFO.com_title = txt_details.Text;
            
        }
        public override void get_data(string status_mess)
        {
            cOMPANY_INFO = cmd_company.get_all().FirstOrDefault();
            var comp = cmd_company.get_all().ToList(); 
            fill_controls();
            base.get_data(status_mess);
          
        }
        public override void insert_data()
        {
            try
            {
                cOMPANY_INFO = new T_COMPANY_INFO();
                cOMPANY_INFO.com_id = Convert.ToUInt64(txt_id.Text);
                fill_entitey();
                cmd_company.insert_data(cOMPANY_INFO);
                get_data("i");     
                base.insert_data();
            }
            catch (Exception ex)
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);
            }
        }
        public override void update_data()
        {
            try
            {
                long id = (long)(txt_id.Text  == string.Empty ? 0 : Convert.ToUInt64(txt_id.Text));
                cOMPANY_INFO = cmd_company.get_by( c_id => c_id.com_id ==id).FirstOrDefault();
                if (cOMPANY_INFO != null)
                    fill_entitey();
                cmd_company.update_data(cOMPANY_INFO);
                get_data("u");
                base.update_data();
            }
            catch (Exception ex)
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);
            }
        }
        public override string delete_data()
        {
            try
            {
                if (base.delete_data() == "true")
                {
                    long id = (long)(txt_id.Text == string.Empty ? 0 : Convert.ToUInt64(txt_id.Text));
                    cOMPANY_INFO = cmd_company.get_by(c_id => c_id.com_id == id).FirstOrDefault();
                    if (cOMPANY_INFO != null)
                        fill_entitey();
                    cmd_company.delet_data(cOMPANY_INFO);
                    get_data("d");
                }
            }
            catch (Exception ex)
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);
            }
 
            return "";
        }
   
    }
}
