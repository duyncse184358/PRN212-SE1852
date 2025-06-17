using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> dsDuLieu = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnThem_Click (object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTri.Text);
            dsDuLieu.Add(x);
            HienThiDanhSach();
            txtGiaTri.Text = "";
        }

        void HienThiDanhSach()
        {
            IstDuLieu.Items.Clear();
            for(int i = 0; i < dsDuLieu.Count; i++)
            {
                int x = dsDuLieu[i];
                IstDuLieu.Items.Add(x);
            }
        }
        private void BtnChen_Click(object sender, RoutedEventArgs e)
        {
            int x = int.Parse(txtGiaTriChen.Text);
            int vt = int.Parse(txtViTriChen.Text);
            dsDuLieu.Insert(vt, x);
            HienThiDanhSach();
            txtViTriChen.Text = "";
            txtGiaTriChen.Text = "";
        }

        private void BtnSapXepTang_Click(object sender,RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            HienThiDanhSach();
        }

        private void BtnSapXepGiam_Click(object sender,RoutedEventArgs e)
        {
            dsDuLieu.Sort();
            dsDuLieu.Reverse();
            HienThiDanhSach();
        }
        private void BtnXoa1PhanTu_Click(object sender, RoutedEventArgs e)
        {
            if (IstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chọn phần tử mới xóa được", "Thông  báo lỗi", MessageBoxButton.OK); 
                return;
            }
          
            dsDuLieu.RemoveAt(IstDuLieu.SelectedIndex);
            HienThiDanhSach();
        }
        private void BtnXoaNhieuPhanTu_Click(object sender,RoutedEventArgs e)
        {
            if(IstDuLieu.SelectedIndex == -1)
            {
                MessageBox.Show("Phải chon phần tử mới xóa được", "Thông báo lỗi", MessageBoxButton.OK);
                return;
            }
            while(IstDuLieu.SelectedItems.Count > 0)
            {
                // lấy phần tử đầu tiên ra
                int data = (int)IstDuLieu.SelectedItems[0];
                //xóa khỏi danh sách
                dsDuLieu.Remove(data);
                // xóa dữ liệu trên giao diện
                IstDuLieu.Items.Remove(data);
            }
        }
        private void BtnXoaToanBoPhanTu_Click(object sender,RoutedEventArgs e)
        {
            dsDuLieu.Clear();// xóa toàn bộ dữ liệu
            HienThiDanhSach();
        }
    }
    
}