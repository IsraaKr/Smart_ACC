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
    public partial class f_branch : F_INHERTEANCE
    {
        public f_branch()
        {
            InitializeComponent();
        }
        cls_Commander<T_BRANCH> cmd_branch = new cls_Commander<T_BRANCH>();
        T_BRANCH bRANCH;

        private void f_branch_Load(object sender, EventArgs e)
        {
            get_data("");
        }
        public void fill_controls()
        {
            if (bRANCH != null)
            {
                txt_id.Text = bRANCH.bran_id.ToString();
                txt_code.Text = bRANCH.bran_code.ToString();
                txt_name.Text = bRANCH.bran_name;
                txt_adress.Text = bRANCH.bran_adress;
                txt_phone.Text = bRANCH.bran_phone;
                txt_mobile.Text = bRANCH.bran_mobile;
                txt_location.Text = bRANCH.bran_location;
                dtp_date.DateTime = (DateTime)bRANCH.bran_opendate;
                che_state.Checked = (bool)bRANCH.bran_stat;

            }
        }
        public void fill_entitey()
        {
          bRANCH.bran_id = Convert.ToInt64( txt_id.Text);
          bRANCH.bran_code=txt_code.Text == string.Empty ? 0 : Convert.ToInt64(txt_code.Text);
          bRANCH.bran_name = txt_name.Text.Trim() ;
          bRANCH.bran_adress = txt_adress.Text.Trim();
          bRANCH.bran_phone = txt_phone.Text.Trim();
          bRANCH.bran_mobile = txt_mobile.Text.Trim();
          bRANCH.bran_location = txt_location.Text.Trim();
          bRANCH.bran_opendate =Convert.ToDateTime(string.Format( dtp_date.DateTime.ToShortDateString() , "yyyy/MM/dd")) ;
          bRANCH.bran_stat =Convert.ToBoolean( che_state.CheckState) ;
        }
        public void check_data()
        {
            if (txt_code.Text == string.Empty)
                txt_code.ErrorText = "يرجى اختيار عنصر حقل مطلوب";
            if (txt_name.Text == string.Empty)
                txt_name.ErrorText = "يرجى اختيار عنصر حقل مطلوب";          
        }
        public override void get_data(string status_mess)
        {
            try
            {
                var test = cmd_branch.get_all().ToList();
                if (test.Count > 0)
                {
                    gc_details.DataSource = (from b in cmd_branch.get_all()
                                             select new
                                             {
                                                 id = b.bran_id,
                                                 code = b.bran_code,
                                                 name = b.bran_name,
                                                 phone = b.bran_phone,
                                                 mobile = b.bran_mobile
                                             }).OrderBy(i => i.id);
                    gv_details.Columns["id"].Caption = "الرقم";
                    gv_details.Columns["code"].Caption = "الكود";
                    gv_details.Columns["name"].Caption = " اسم الفرع";
                    gv_details.Columns["phone"].Caption = "الهاتف";
                    gv_details.Columns["mobile"].Caption = "الموبايل";

                    gv_details.BestFitColumns();
                    base.get_data(status_mess);
                }

                var max = cmd_branch.get_all().Where(b_id => b_id.bran_id == cmd_branch.get_all().Max(m => m.bran_id)).FirstOrDefault();
                txt_id.Text = max == null ? "1" : (max.bran_id + 1).ToString();

            }
            catch(Exception ex)
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);

            }
        }
        private void gv_details_DoubleClick(object sender, EventArgs e)
        {
            if (gv_details.RowCount >0)
            {
                long id = Convert.ToInt64(gv_details.GetRowCellValue(gv_details.FocusedRowHandle, gv_details.Columns["id"]));
                bRANCH = cmd_branch.get_by(b_id => b_id.bran_id == id).FirstOrDefault();
                if (bRANCH != null)
                    fill_controls();
            }
        }
        public override void insert_data()
        {
            try
            {
                if (txt_id.Text.Trim() != string.Empty)
                {
                    bRANCH = new T_BRANCH();
                    bRANCH.bran_id = Convert.ToInt64(txt_id.Text);
                    fill_entitey();
                    cmd_branch.insert_data(bRANCH);
                    get_data("i");
                    base.insert_data();
                }
                else
                    check_data();
            }
            catch (Exception ex )
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);
            }
          
        }
        public override void update_data()
        {
            try
            {
                if (gv_details.RowCount > 0 && txt_id.Text != string.Empty && txt_name.Text != string.Empty)
                {
                    long id =txt_id.Text == string.Empty ? 0 : Convert.ToInt64(txt_id.Text);
                    bRANCH = cmd_branch.get_by(b_id => b_id.bran_id==id).FirstOrDefault();
                    if (bRANCH != null)
                        fill_entitey();
                    cmd_branch.update_data(bRANCH);
                    get_data("u");
                    base.update_data();
                }
                else
                    check_data();              
            }
            catch (Exception ex)
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);
            }
        }
        public override string delete_data()
        {
            if (base.delete_data() =="true")
            {
                try
                {
                    if (gv_details.RowCount > 0 && txt_id.Text != string.Empty && txt_name.Text != string.Empty)
                    {
                        long id = Convert.ToInt64(txt_id.Text);
                        bRANCH = cmd_branch.get_by(b_id => b_id.bran_id == id).FirstOrDefault();
                        if (bRANCH != null)
                            cmd_branch.delet_data(bRANCH);
                        get_data("d");
                    }
                    else
                        check_data();
                }
                catch (Exception ex)
                {
                    get_data(ex.InnerException.ToString() + "/" + ex.Message);
                }
                return "";
            }
           
            return "";
        }
        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(this.Controls);

            var max = cmd_branch.get_all().Where(b_id => b_id.bran_id == cmd_branch.get_all().Max(m => m.bran_id)).FirstOrDefault();
            txt_id.Text = max == null ? "1" : (max.bran_id + 1).ToString();

        }

    }
}
