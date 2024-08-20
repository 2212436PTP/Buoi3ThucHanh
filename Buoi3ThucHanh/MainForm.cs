using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi3ThucHanh
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        // Click đôi vào nút chương trình sẽ tự động tạo hàm sự kiện này
        // Khi ta click chuột vào nút chương trình sẽ làm gì
        private void btnOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTên.Text;
            MessageBox.Show($"Xin chào bạn {tenDaNhap}. Rất vui được gặp bạn", "Thông điệp chào mừng");
        }

        private void btnSaoChepOK_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTên.Text;
        }

        private void txtTên_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTên.Text;
        }
        // Bây giờ muốn xử lý sự kiện, trong ô tên gõ gì thì ở sao chép có nội dung như vậy, không cần nhấn nút sao chép
        // Xử lý
    }
}
