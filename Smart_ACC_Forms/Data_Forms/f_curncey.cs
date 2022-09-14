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
    public partial class f_curncey : F_INHERTEANCE
    {
        public f_curncey()
        {
            InitializeComponent();
        }
        cls_Commander<T_CURNCY> cmd_curncy = new cls_Commander<T_CURNCY>();
        cls_Commander<T_BRANCH> cmd_branch = new cls_Commander<T_BRANCH>();

        T_CURNCY cURNCY;
        T_BRANCH bRANCH;
        private void f_curncey_Load(object sender, EventArgs e)
        {
            get_data("");
        }
        public void fill_controls()
        {
            if (cURNCY != null)
            {
                txt_id.Text = cURNCY.curncy_id.ToString();
                txt_code.Text = cURNCY.curncy_code.ToString();
                txt_name.Text = cURNCY.curncy_name;
                txt_nation.Text = cURNCY.curncy_nation.ToString();
                txt_value.Text = cURNCY.curncy_value.ToString();
                txt_type.Text = cURNCY.curncy_type.ToString();
                txt_note.Text = cURNCY.curncy_note;
                che_state.Checked = (bool)cURNCY.curncy_state;

                bRANCH = cmd_branch.get_by(b => b.bran_id == cURNCY.bran_id).FirstOrDefault();
                comb_bran_id.Text = bRANCH.bran_name;
                comb_bran_id.EditValue = bRANCH.bran_id;
            }
        }
        public void fill_entitey()
        {
            cURNCY.curncy_id = Convert.ToInt64(txt_id.Text);
            cURNCY.curncy_code = txt_code.Text == string.Empty ? 0 : Convert.ToInt64(txt_code.Text);
            cURNCY.curncy_name = txt_name.Text.Trim();
            cURNCY.curncy_nation = txt_nation.Text.Trim();
            cURNCY.curncy_value = Convert.ToDecimal(txt_value.Text.Trim());
            cURNCY.curncy_type = txt_type.Text.Trim(); ;
            cURNCY.curncy_state = Convert.ToBoolean(che_state.CheckState);
            cURNCY.curncy_note = txt_note.Text.Trim();
            cURNCY.bran_id = Convert.ToInt64(comb_bran_id.EditValue);
        }
        public void check_data()
        {
            if (txt_code.Text == string.Empty)
                txt_code.ErrorText = " حقل مطلوب";
            if (txt_name.Text == string.Empty)
                txt_name.ErrorText = " حقل مطلوب";
            if (txt_value.Text == string.Empty)
                txt_value.ErrorText = " حقل مطلوب";
        }
        public override void get_data(string status_mess)
        {
            try
            {
                var test = cmd_curncy.get_all().ToList();
                if (test.Count > 0)
                {
                    gc_details.DataSource = (from cur in cmd_curncy.get_all()
                                             join bran in cmd_branch.get_all() on cur.bran_id equals bran.bran_id
                                             select new
                                             {
                                                 id = cur.curncy_id,
                                                 name = cur.curncy_name,
                                                 nation = cur.curncy_nation,
                                                 value = cur.curncy_value,
                                                 branch_name = bran.bran_name
                                             }).OrderBy(c_id => c_id.id).ToList();
                    gv_details.Columns["id"].Caption = "الرقم";
                    gv_details.Columns["name"].Caption = "اسم العملة";
                    gv_details.Columns["nation"].Caption = "الجنسية";
                    gv_details.Columns["value"].Caption = "سعر الصرف";
                    gv_details.Columns["branch_name"].Caption = "اسم الفرع";

                    gv_details.BestFitColumns();
                }

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

                base.get_data(status_mess);

                var max = cmd_curncy.get_all().Where(c_id => c_id.curncy_id == cmd_curncy.get_all().Max(m => m.curncy_id)).FirstOrDefault();
                txt_id.Text = max == null ? "1" : (max.curncy_id + 1).ToString();
            }
            catch(Exception ex)
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
                    cURNCY = new T_CURNCY();
                    cURNCY.curncy_id = Convert.ToInt64(txt_id.Text);
                    fill_entitey();
                    cmd_curncy.insert_data(cURNCY);
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
                    if (cURNCY != null)
                        fill_entitey();
                    cmd_curncy.update_data(cURNCY);
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
                    // if (cURNCY != null)
                    cmd_curncy.delet_data(cURNCY);
                    //  get_data("d");
                    //  base.delete_data();
                    s_id = 0;
                    return "";
                }
                try
                {
                if (base.delete_data() == "true")
                {
                    if (gv_details.RowCount > 0 && txt_id.Text != string.Empty && txt_name.Text != string.Empty)
                    {
                        // if (cURNCY != null)
                        cmd_curncy.delet_data(cURNCY);
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
            
            return "";
        }
        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(this.Controls);
            var max = cmd_curncy.get_all().Where(c_id => c_id.curncy_id == cmd_curncy.get_all().Max(m => m.curncy_id)).FirstOrDefault();
            txt_id.Text = max == null ? "1" : (max.curncy_id + 1).ToString();

        }

        private void gv_details_DoubleClick(object sender, EventArgs e)
        {
            if (gv_details.RowCount > 0)
            {
                long id = Convert.ToInt64(gv_details.GetRowCellValue(gv_details.FocusedRowHandle, gv_details.Columns["id"]));
                cURNCY = cmd_curncy.get_by(m => m.curncy_id == id).FirstOrDefault();
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
                        cURNCY = cmd_curncy.get_by(m => m.curncy_id == id).FirstOrDefault();
                        delete_data( id);
                    }
                get_data("d");

            }
            catch (Exception )
            {

            }
        }
    }
}
