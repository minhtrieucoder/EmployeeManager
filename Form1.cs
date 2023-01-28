using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanLiNhanVien
{
    public partial class frm_quanLiNhanVien : Form
    {
        private string hoNV;
        private string tenNV;
        private string chucVu;
        private decimal luong;

        int dayBirth;
        int monthBirth;
        int yearBirth;

        int dayHire;
        int monthHire;
        int yearHire;

        Boss boss;
        CommissionWorker commissionWorker;
        PieceWorker pieceWorker;
        HourlyWorker hourlyWorker;

        public frm_quanLiNhanVien()
        {
            InitializeComponent();
        }

        private void btn_nhapThongTin_Click(object sender, EventArgs e)
        {
            hoNV = tbx_ho.Text;
            tenNV = tbx_ten.Text;
            chucVu = cbx_chucVu.Text;
            luong = Convert.ToDecimal(tbx_luong.Text);

            if (chucVu == "Boss")
            {
                boss = new Boss(tenNV, hoNV, luong, monthBirth, dayBirth, yearBirth, monthHire, dayHire, yearHire);     
            }
            else if (chucVu == "CommissionWorker")
            {
                commissionWorker = new CommissionWorker(tenNV, hoNV, luong, Convert.ToDecimal(tbx_commission.Text), Convert.ToInt32(tbx_quantity.Text), monthBirth, dayBirth, yearBirth, monthHire, dayHire, yearHire);
            }
            else if (chucVu == "PieceWorker")
            {
                pieceWorker = new PieceWorker(tenNV, hoNV, Convert.ToDecimal(tbx_wage.Text), Convert.ToInt32(tbx_quantity.Text), monthBirth, dayBirth, yearBirth, monthHire, dayHire, yearHire);
            }
            else if (chucVu == "HourlyWorker")
            {
                hourlyWorker = new HourlyWorker(tenNV, hoNV, Convert.ToDecimal(tbx_wage.Text), Convert.ToDouble(tbx_hoursWorked.Text), monthBirth, dayBirth, yearBirth, monthHire, dayHire, yearHire);
            }

            MessageBox.Show("Đã nhận thông tin nhân viên", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_nhapNgaySinh_Click(object sender, EventArgs e)
        {
            dayBirth = Int32.Parse(tbx_ngay.Text);
            monthBirth = Int32.Parse(tbx_thang.Text);
            yearBirth = Int32.Parse(tbx_nam.Text);

            MessageBox.Show("Đã nhận thông tin ngày sinh", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_nhapNgayLam_Click(object sender, EventArgs e)
        {
            dayHire = Int32.Parse(tbx_ngay.Text);
            monthHire = Int32.Parse(tbx_thang.Text);
            yearHire = Int32.Parse(tbx_nam.Text);

            MessageBox.Show("Đã nhận thông tin ngày làm", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }        

        private void btn_hienDuLieuNhap_Click(object sender, EventArgs e)
        {
            Employee employee;

            if (tbx_number.Text == "1")
            {
                employee = boss;
                lb_hienDuLieuNhap.Text = GetString(employee);
            }

            else if (tbx_number.Text == "2")
            {
                employee = commissionWorker;
                lb_hienDuLieuNhap.Text = GetString(employee);
            }

            else if (tbx_number.Text == "3")
            {
                employee = pieceWorker;
                lb_hienDuLieuNhap.Text = GetString(employee);
            }

            else if (tbx_number.Text == "4")
            {
                employee = hourlyWorker;
                lb_hienDuLieuNhap.Text = GetString(employee);
            }
        }

        private void btn_hienThiKetQua_Click(object sender, EventArgs e)
        {
            Employee employee = boss;

            string output = GetString(employee);

            employee = commissionWorker;

            output += GetString(employee);

            employee = pieceWorker;

            output += GetString(employee);

            employee = hourlyWorker;

            output += GetString(employee);

            lb_hienThiKetQua.Text = output;
        }



        private void cbx_chucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_chucVu.Text == "Boss")
            {
                lb_luong.Visible = true;
                tbx_luong.Visible = true;

                lb_quantity.Visible = false;
                tbx_quantity.Visible = false;

                lb_commission.Visible = false;
                tbx_commission.Visible = false;

                lb_wage.Visible = false;
                tbx_wage.Visible = false;

                lb_hoursWorked.Visible = false;
                tbx_hoursWorked.Visible = false;
            }

            else if (cbx_chucVu.Text == "CommissionWorker")
            {
                lb_luong.Visible = true;
                tbx_luong.Visible = true;

                lb_quantity.Visible = true;
                tbx_quantity.Visible = true;

                lb_commission.Visible = true;
                tbx_commission.Visible = true;

                lb_wage.Visible = false;
                tbx_wage.Visible = false;

                lb_hoursWorked.Visible = false;
                tbx_hoursWorked.Visible = false;
            }

            else if (cbx_chucVu.Text == "PieceWorker")
            {
                lb_luong.Visible = false;
                tbx_luong.Visible = false;

                lb_quantity.Visible = true;
                tbx_quantity.Visible = true;

                lb_commission.Visible = false;
                tbx_commission.Visible = false;

                lb_wage.Visible = true;
                tbx_wage.Visible = true;

                lb_hoursWorked.Visible = false;
                tbx_hoursWorked.Visible = false;
            }

            else if (cbx_chucVu.Text == "HourlyWorker")
            {
                lb_luong.Visible = false;
                tbx_luong.Visible = false;

                lb_quantity.Visible = false;
                tbx_quantity.Visible = false;

                lb_commission.Visible = false;
                tbx_commission.Visible = false;

                lb_wage.Visible = true;
                tbx_wage.Visible = true;

                lb_hoursWorked.Visible = true;
                tbx_hoursWorked.Visible = true;
            }
        }

        public static string GetString(Employee worker)
        {
            return worker.ToString() + "\nEarned: " + worker.Earnings().ToString("C") + "\n\n";
        }
    }
}
