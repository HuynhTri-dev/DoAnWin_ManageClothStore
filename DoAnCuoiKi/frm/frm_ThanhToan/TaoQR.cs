using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DoAnCuoiKi.BanHang;
using System.Security.Cryptography;

namespace DoAnCuoiKi.frm.frm_ThanhToan
{
    public partial class TaoQR : Form
    {
        //partnerCode: Mã định danh đối tác.
        //amount: Số tiền thanh toán(đơn vị VNĐ).
        //orderId: Mã đơn hàng.
        //orderInfo: Thông tin đơn hàng.
        //redirectUrl: URL chuyển hướng sau thanh toán (tùy chọn).
        //ipnUrl: URL để nhận thông báo từ MoMo khi giao dịch hoàn tất.
        //requestType: Loại yêu cầu (thường là "captureWallet").

        string partnerCode = "MOMO";
        string orderId = "";
        string amount = "";
        string orderInfo = "";
        string returnUrl = "URL chuyen huong";
        string notifyUrl = "URL nhan thong bao hoan tat giao dich";
        string secretKey = "your_momo_secret_key";



        public TaoQR(string MaDH, decimal GiaTri)
        {
            InitializeComponent();
            orderId = MaDH;
            amount = GiaTri.ToString();
            orderInfo = "Thanh toán đơn hàng " + MaDH;
        }

        private void TaoQR_Load(object sender, EventArgs e)
        {
            string momoPaymentUrl = TaoDataQR(partnerCode, orderId, amount, orderInfo, returnUrl, notifyUrl, secretKey);
            Bitmap qrCodeImage = TaoQRThanhToan(momoPaymentUrl);
            pictureBoxQRCode.Image = qrCodeImage;
        }

        public string TaoDataQR(string partnerCode, string orderId, string amount, string orderInfo, string returnUrl, string notifyUrl, string secretKey)
        {
            string requestId = Guid.NewGuid().ToString();
            string requestType = "captureWallet";
            string rawData = $"partnerCode={partnerCode}&requestId={requestId}&amount={amount}&orderId={orderId}&orderInfo={orderInfo}&returnUrl={returnUrl}&notifyUrl={notifyUrl}&extraData=&requestType={requestType}";
            string signature = GenerateSignature(rawData, secretKey);

            // Chuỗi chứa thông tin QR MoMo
            return $"partnerCode={partnerCode}\n" +
                    $"&requestId={requestId}\n" +
                    $"&amount={amount}\n" +
                    $"&orderId={orderId}\n" +
                    $"&orderInfo={orderInfo}\n" +
                    $"&returnUrl={returnUrl}\n" +
                    $"&notifyUrl={notifyUrl}\n" +
                    $"&extraData=&requestType={requestType}\n" +
                    $"&signature={signature}";
        }

        public Bitmap TaoQRThanhToan(string data)
        {
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
                using (QRCode qrCode = new QRCode(qrCodeData))
                {
                    Bitmap qrImg =  qrCode.GetGraphic(10, Color.Black, Color.White, true);
                    Bitmap qrImgLogo = AddLogoToQRCode(qrImg, Properties.Resources.square_8c08a00f550e40a2efafea4a005b1232);
                    return qrImgLogo;
                }
            }
        }

        private Bitmap AddLogoToQRCode(Bitmap qrCode, Bitmap logoPath)
        {
            Bitmap logo = new Bitmap(logoPath);
            Graphics g = Graphics.FromImage(qrCode);

            int logoSize = qrCode.Width / 5; // Kích thước logo (20% kích thước mã QR)
            int x = (qrCode.Width - logoSize) / 2;
            int y = (qrCode.Height - logoSize) / 2;

            g.DrawImage(logo, new Rectangle(x, y, logoSize, logoSize));
            return qrCode;
        }


        private string GenerateSignature(string data, string secretKey)
        {
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey)))
            {
                byte[] hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        private void pictureBoxQRCode_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
