using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NHANVIEN nv = db.NHANVIENs.Where(x => x.TENDN == tbxUsername.Text).SingleOrDefault();
            SINHVIEN sv = db.SINHVIENs.Where(x => x.TENDN == tbxUsername.Text).SingleOrDefault();

            StringBuilder sBuilder = new StringBuilder();
            if (nv != null)
            {
                byte[] mk_nv = nv.MATKHAU.ToArray();
                for (int i = 0; i < mk_nv.Length; ++i)
                {
                    sBuilder.Append(mk_nv[i].ToString("x2"));
                }
                //MessageBox.Show(sBuilder.ToString());                                
                if (Encryption.VerifyHash("sha1", tbxPassword.Text, Encoding.Unicode.GetString(mk_nv)))
                {
                    DialogResult res = MessageBox.Show("Successful login staff\n " + nv.HOTEN, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        DSNV newform = new DSNV();
                        newform.ShowDialog();
                        this.Visible = false;
                    }
                }
                else
                {
                    nv = null;
                    sv = null;
                }
            }
            else if (sv != null)
            {
                byte[] mk_sv = sv.MATKHAU.ToArray();

                if (Encryption.VerifyHash("md5", tbxPassword.Text, Encoding.ASCII.GetString(mk_sv)))
                {
                    DialogResult res = MessageBox.Show("Successful login student\n" + sv.HOTEN, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        DSNV newform = new DSNV();
                        newform.ShowDialog();
                        this.Visible = false;
                    }
                }
                else
                {
                    nv = null;
                    sv = null;
                }
            }
            if (nv == null && sv == null)
            {
                MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {
            this.ActiveControl = tbxUsername;
            tbxUsername.Focus();
        }

    }
}
