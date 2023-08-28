using Smart_ACC_DataBase;
using Smart_ACC_DataBase.Commander;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_ACC_Forms.Data_Forms
{
    public partial class f_main_cash : F_INHERTEANCE
    {
        public f_main_cash()
        {
            InitializeComponent();
        }
        cls_Commander<T_MAIN_CASH> cmd_main_cash = new cls_Commander<T_MAIN_CASH>();
        cls_Commander<T_BRANCH> cmd_branch = new cls_Commander<T_BRANCH>();

        T_MAIN_CASH mAIN_CASH;
        T_BRANCH bRANCH;

        private void f_main_cash_Load(object sender, EventArgs e)
        {
            get_data("");
        }
        public void fill_controls()
        {
            if (mAIN_CASH != null)
            {
                txt_id.Text = mAIN_CASH.cash_id.ToString();
                txt_code.Text = mAIN_CASH.cash_code.ToString();
                txt_name.Text = mAIN_CASH.cash_name;
                txt_start_balance.Text = mAIN_CASH.cash_start_balance.ToString();
                txt_zero_balance.Text = mAIN_CASH.cash_zero_balance.ToString();
                txt_cash_balance.Text = mAIN_CASH.cash_balance.ToString();
                txt_note.Text = mAIN_CASH.cash_note;
                dtp_date.DateTime = (DateTime)mAIN_CASH.cash_start_date;
                che_state.Checked = (bool)mAIN_CASH.cash_state;

                bRANCH = cmd_branch.get_by(b => b.bran_id==mAIN_CASH.bran_id).FirstOrDefault();
                comb_bran_id.Text = bRANCH.bran_name;
                comb_bran_id.EditValue = bRANCH.bran_id;
            }
        }
        public void fill_entitey()
        {
            mAIN_CASH.cash_id = Convert.ToInt64(txt_id.Text);
            mAIN_CASH.cash_code = txt_code.Text == string.Empty ? 0 : Convert.ToInt64(txt_code.Text);
            mAIN_CASH.cash_name = txt_name.Text.Trim();
            mAIN_CASH.cash_start_date = Convert.ToDateTime(string.Format(dtp_date.DateTime.ToShortDateString(), "yyyy/MM/dd"));
            mAIN_CASH.cash_start_balance = Convert.ToDecimal( txt_start_balance.Text.Trim());
            mAIN_CASH.cash_zero_balance = Convert.ToDecimal(txt_zero_balance.Text.Trim());
            mAIN_CASH.cash_balance = Convert.ToDecimal(txt_cash_balance.Text.Trim());
            mAIN_CASH.cash_state = Convert.ToBoolean(che_state.CheckState);
            mAIN_CASH.cash_note = txt_note.Text.Trim(); 
            mAIN_CASH.bran_id= Convert.ToInt64(comb_bran_id.EditValue);
        }
        public void check_data()
        {
            if (txt_code.Text == string.Empty)
                txt_code.ErrorText = "يرجى اختيار عنصر حقل مطلوب";
            if (txt_name.Text == string.Empty)
                txt_name.ErrorText = "يرجى اختيار عنصر حقل مطلوب";
        }
        public override void get_data(string status_mess)
        {try
            {
                var test = cmd_main_cash.get_all().ToList();
                if (test.Count > 0)
                {//الجوين لتجنب خطاء عند الادخال لفرع غير مدخل من قبل 
                    gc_details.DataSource = (from main_cash in cmd_main_cash.get_all()
                                             join bran in cmd_branch.get_all() on main_cash.bran_id equals bran.bran_id
                                             select new
                                             {
                                                 id = main_cash.cash_id,
                                                 name = main_cash.cash_name,
                                                 balance = main_cash.cash_balance,
                                                 state = main_cash.cash_state,
                                                 branch_id = bran.bran_id,
                                                 branch_name = bran.bran_name
                                             }).OrderBy(c_id => c_id.id);
                    gv_details.Columns["id"].Caption = "الرقم";
                    gv_details.Columns["name"].Caption = "اسم الصندوق";
                    gv_details.Columns["balance"].Caption = "الرصيد";
                    gv_details.Columns["state"].Caption = "الحالة";
                    gv_details.Columns["branch_id"].Caption = "رقم الفرع";
                    gv_details.Columns["branch_name"].Caption = "اسم الفرع";

                    gv_details.BestFitColumns();
                }
                base.get_data(status_mess);

                comb_bran_id.Properties.DataSource = (from bran in cmd_branch.get_all().Where(b => b.bran_stat == true)
                                                      select new
                                                      {
                                                          branch_id = bran.bran_id,
                                                          branch_name = bran.bran_name
                                                      }).OrderBy(b_id => b_id.branch_id);
                comb_bran_id.Properties.DisplayMember = "branch_name";
                comb_bran_id.Properties.ValueMember = "branch_id";
                comb_bran_id.Properties.PopulateColumns();
                comb_bran_id.Properties.Columns[0].Caption = "الرقم";
                comb_bran_id.Properties.Columns[1].Caption = "الاسم";

                var max = cmd_main_cash.get_all().Where(c_id => c_id.cash_id == cmd_main_cash.get_all().Max(m => m.cash_id)).FirstOrDefault();
                txt_id.Text = max == null ? "1" : (max.cash_id + 1).ToString();
                txt_code.Text = txt_id.Text;
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
                if (txt_code.Text !=string.Empty && txt_name.Text != string.Empty)
                {
                    mAIN_CASH = new T_MAIN_CASH();
                    mAIN_CASH.cash_id = Convert.ToInt64(txt_id.Text);
                    fill_entitey();
                    cmd_main_cash.insert_data(mAIN_CASH);
                    get_data("i");
                    clear_data(this.Controls);
                    base.insert_data();
                }               
            }
            catch (Exception ex)
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);
            }
        }

        private void gv_details_DoubleClick(object sender, EventArgs e)
        {
            if (gv_details.RowCount>0)
            {
                long id = Convert.ToInt64(gv_details.GetRowCellValue(gv_details.FocusedRowHandle, gv_details.Columns["id"]));
                mAIN_CASH = cmd_main_cash.get_by(m => m.cash_id==id).FirstOrDefault();
                fill_controls();
            }
        }
        public override void update_data()
        {
            try
            {
                if (gv_details.RowCount > 0 && txt_id.Text != string.Empty && txt_name.Text != string.Empty)
                {
                    if (mAIN_CASH != null)
                        fill_entitey();
                    cmd_main_cash.update_data(mAIN_CASH);
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
        public override string delete_data( long s_id)
        {        
                if (s_id > 0)
                {
                    if (mAIN_CASH != null)
                        cmd_main_cash.delet_data(mAIN_CASH);
                    get_data("d");
                    base.delete_data();
                    s_id = 0;
                    return "";
                }
            try
            {
                if (base.delete_data() == "true")
                {
                    if (gv_details.RowCount > 0 && txt_id.Text != string.Empty && txt_name.Text != string.Empty)
                    {
                        if (mAIN_CASH != null)
                            cmd_main_cash.delet_data(mAIN_CASH);
                        get_data("d");
                    }
                    else
                        check_data();
                }
            }
            catch (Exception ex)
            {
                get_data(ex.InnerException.ToString() + "/" + ex.Message);
            }
           
            return "";
           
        }
        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(this.Controls);
            var max = cmd_main_cash.get_all().Where(c_id => c_id.cash_id == cmd_main_cash.get_all().Max(m => m.cash_id)).FirstOrDefault();
            txt_id.Text = max == null ? "1" : (max.cash_id + 1).ToString();

        }
        //حذف الاسطر المحددة عند الضغط عل زر ديليت
        private void gv_details_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (gv_details.RowCount > 0 && e.KeyData == Keys.Delete)
                    foreach (int rowid in gv_details.GetSelectedRows())
                    {
                        long id = Convert.ToInt64(gv_details.GetRowCellValue(rowid, "id"));
                        mAIN_CASH = cmd_main_cash.get_by(m => m.cash_id == id).FirstOrDefault();
                        delete_data( id);
                    }
                get_data("d");

            }
            catch(Exception )
            {

            }
        }
    }
}
