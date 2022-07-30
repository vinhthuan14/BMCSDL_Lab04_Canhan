using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class DSNV : Form
    {
        
        DataClasses1DataContext db = new DataClasses1DataContext();
        AESExample newAES = new AESExample();
        SqlConnection myCon = new SqlConnection("Data Source=LAPTOP-FRHKQJ00;Initial Catalog=QLSV_Lab04;Integrated Security=TrueData Source=LAPTOP-FRHKQJ00;Initial Catalog=QLSV_Lab04;Integrated Security=True");
        
      
        public DSNV()
        {
            InitializeComponent();
            
        }
        private void Update()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("col1", "MÃ NHÂN VIÊN");
            dataGridView1.Columns.Add("col2", "HỌ TÊN");
            dataGridView1.Columns.Add("col3", "EMAIL");
            dataGridView1.Columns.Add("col4", "LƯƠNG");

            var res = db.SP_SEL_NHANVIEN();
            foreach (var r in res)
            {
                DataGridViewRow dt = new DataGridViewRow();
                dt.CreateCells(dataGridView1);
                dt.Cells[0].Value = r.MANV;
                dt.Cells[1].Value = r.HOTEN;
                dt.Cells[2].Value = r.EMAIL;
                dt.Cells[3].Value = r.LUONG;


                dt.Cells[3].Value = newAES.Decrypt(r.LUONG, "4501104230", 256);
                dataGridView1.Rows.Add(dt);
            }

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DSNV_Load(object sender, EventArgs e)
        {
            Update();
            tbxManv.ReadOnly = true;
            btnGhi.Enabled = false;
            btnKhong.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            tbxManv.ReadOnly = false;
            tbxManv.Text = "";
            tbxEmail.Text = "";
            tbxLuong.Text = "";
            tbxMK.Text = "";
            tbxTen.Text = "";
            tbxTendangnhap.Text = "";
            btnGhi.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string ConvertBytetoString(byte[] ba)
        {
            return BitConverter.ToString(ba).Replace("-", "");
        }

        public static byte[] ConvertStringToByte(String hex)
        {
            Console.WriteLine(hex);
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        private void btnGhi_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIEN nv = db.NHANVIENs.Where(p => p.MANV == tbxManv.Text).SingleOrDefault();
                if (nv != null)
                {
                    nv.MANV = tbxManv.Text;
                    nv.HOTEN = tbxTen.Text;
                    nv.EMAIL = tbxEmail.Text;
                    if (tbxMK.Text != null)
                    {
                        nv.MATKHAU = Encoding.Unicode.GetBytes(Encryption.GetHash("sha1", tbxMK.Text));
                    }
                    nv.LUONG = Encoding.ASCII.GetBytes(newAES.Encrypt(tbxLuong.Text, "4501104230"));
                    db.SubmitChanges();
                    Update();
                    MessageBox.Show("Update Successfull", "Notification",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else { 
                    if (tbxMK.Text == null)
                    {
                        MessageBox.Show("Password is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string luongcb = newAES.Encrypt(tbxLuong.Text, "4501104230");
                        db.SP_INS_ENCRYPT_NHANVIEN(tbxManv.Text, tbxTen.Text, tbxEmail.Text,luongcb , tbxTendangnhap.Text, Encryption.GetHash("sha1", tbxMK.Text));
                        Update();
                        db.SubmitChanges();
                        MessageBox.Show("Add Successfull", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                }
                
            }
            catch
            {
                MessageBox.Show("Notification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
