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
    public partial class f_banks : F_INHERTEANCE
    {
        public f_banks()
        {
            InitializeComponent();
        }
        cls_Commander<T_BANK> cmd_bank = new cls_Commander<T_BANK>();
        T_BANK bANK;

        public void fill_controls()
        {
            if (bANK != null)
            {
                txt_id.Text = bANK.bank_id.ToString();
                txt_code.Text = bANK.bank_code.ToString();
                txt_name.Text = bANK.bank_name;
                txt_nation.Text = bANK.bank_notion;
                txt_adress.Text = bANK.bank_adress;
                txt_phone.Text = bANK.bank_phone;
                txt_bank_branch.Text = bANK.bank_branch;
                che_state.Checked = (bool)bANK.bank_state;
            }
        }
        public void fill_entitey()
        {
            bANK.bank_id = Convert.ToInt64(txt_id.Text);
            bANK.bank_code = txt_code.Text == string.Empty ? 0 : Convert.ToInt64(txt_code.Text);
            bANK.bank_name = txt_name.Text.Trim();
            bANK.bank_notion = txt_nation.Text.Trim();
            bANK.bank_adress = txt_adress.Text.Trim();
            bANK.bank_branch = txt_bank_branch.Text.Trim(); 
            bANK.bank_phone = txt_phone.Text.Trim();
            bANK.bank_state = Convert.ToBoolean(che_state.CheckState);
        }
        public void check_data()
        {
            if (txt_code.Text == string.Empty)
                txt_code.ErrorText = "يرجى اختيار عنصر حقل مطلوب";
            if (txt_name.Text == string.Empty)
                txt_name.ErrorText = "يرجى اختيار عنصر حقل مطلوب";
        }
        private void f_banks_Load(object sender, EventArgs e)
        {
            get_data("");
        }
        public override void get_data(string status_mess)
        {
            try
            {
                var test = cmd_bank.get_all().ToList();
                if (test.Count > 0)
                {
                    gc_details.DataSource = (from ban in cmd_bank.get_all()
                                             select new
                                             {
                                                 id = ban.bank_id,
                                                 name = ban.bank_name,                                            
                                                 branch = ban.bank_branch,
                                                 adress = ban.bank_adress,
                                                 phone = ban.bank_phone
                                             }).OrderBy(b => b.id);
                    gv_details.Columns["id"].Caption = "الرقم";
                    gv_details.Columns["name"].Caption = "اسم البنك";
                    gv_details.Columns["branch"].Caption = "فرع البنك";
                    gv_details.Columns["adress"].Caption = "العنوان";
                    gv_details.Columns["phone"].Caption = "الهاتف";

                    gv_details.BestFitColumns();
                }

           base.get_data(status_mess);

                var max = cmd_bank.get_all().Where(c_id => c_id.bank_id == cmd_bank.get_all().Max(m => m.bank_id)).FirstOrDefault();
                txt_id.Text = max == null ? "1" : (max.bank_id + 1).ToString();
              //  txt_code.Text = txt_id.Text;
            }
            catch (Exception ex)
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);
            }
        }
        public override void insert_data()
        {
            try
            {
                if (txt_code.Text != string.Empty && txt_name.Text != string.Empty)
                {
                    bANK = new T_BANK();
                    bANK.bank_id = Convert.ToInt64(txt_id.Text);
                    fill_entitey();
                    cmd_bank.insert_data(bANK);
                    get_data("i");
                    base.insert_data();
                }
                else
                    check_data();
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
                if (gv_details.RowCount > 0 && txt_id.Text != string.Empty && txt_name.Text != string.Empty)
                {
                    if (bANK != null)
                        fill_entitey();
                    cmd_bank.update_data(bANK);
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
        public override string delete_data(long s_id)
        {
            if (s_id > 0)
            {
                if (bANK != null)
                    cmd_bank.delet_data(bANK);
                get_data("d");
                base.delete_data();
                s_id = 0;
                return "";
            }
            try
            {
                if (base.delete_data() == "true")
                {
                    //  if (gv_details.RowCount > 0 && txt_id.Text != string.Empty && txt_name.Text != string.Empty)
                    if (gv_details.RowCount > 0)
                    {
                         if (bANK != null)
                             cmd_bank.delet_data(bANK);
                         get_data("d");
                    }
                    else
                        // check_data();
                        return "";
                }
            }
            catch (Exception ex)
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);
            }
            get_data("");
            return "";
        }
        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(this.Controls);
            var max = cmd_bank.get_all().Where(c_id => c_id.bank_id == cmd_bank.get_all().Max(m => m.bank_id)).FirstOrDefault();
            txt_id.Text = max == null ? "1" : (max.bank_id + 1).ToString();

        }
        private void gv_details_DoubleClick(object sender, EventArgs e)
        {
            if (gv_details.RowCount > 0)
            {
                long id = Convert.ToInt64(gv_details.GetRowCellValue(gv_details.FocusedRowHandle, gv_details.Columns["id"]));
                bANK = cmd_bank.get_by(m => m.bank_id == id).FirstOrDefault();
                fill_controls();
            }
        }
        private void gv_details_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (gv_details.RowCount > 0 && e.KeyData == Keys.Delete)
                    foreach (int rowid in gv_details.GetSelectedRows())
                    {
                        long id = Convert.ToInt64(gv_details.GetRowCellValue(rowid, "id"));
                        bANK = cmd_bank.get_by(m => m.bank_id == id).FirstOrDefault();
                        delete_data(id);
                    }
                get_data("d");

            }
            catch (Exception )
            {

            }
        }
    }
}
