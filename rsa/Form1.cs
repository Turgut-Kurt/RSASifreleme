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

namespace rsa
{
    public partial class Anaform : Form
    {
        static public byte[] Sifrele(byte[] Veri, RSAParameters RSAKey, bool DoOAEPPadding)//şifreleme kısmı
        {
            try
            {
                byte[] sifreliveri;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey); sifreliveri = RSA.Encrypt(Veri, DoOAEPPadding);
                }
                return sifreliveri;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        static public byte[] Sıfrecoz(byte[] Veri, RSAParameters RSAKey, bool DoOAEPPadding)//şifre çözme kısmı
        {
            try
            {
                byte[] sifresicozulmusveri;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    sifresicozulmusveri = RSA.Decrypt(Veri, DoOAEPPadding);
                }
                return sifresicozulmusveri;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }
        UnicodeEncoding ByteConverter = new UnicodeEncoding();//
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        byte[] düzmetin;
        byte[] sifrelimetin;
        //asdsadasda

        public Anaform()
        {
            InitializeComponent();
        }

        private void Anaform_Load(object sender, EventArgs e)
        {

        }

        private void BtnSifrele_Click(object sender, EventArgs e)
        {
            düzmetin = ByteConverter.GetBytes(Txtmetin1.Text);
            sifrelimetin = Sifrele(düzmetin, RSA.ExportParameters(false), false);
            Txtsonuc.Text = ByteConverter.GetString(sifrelimetin);
        }

        private void BtnSifrecoz_Click(object sender, EventArgs e)
        {
            byte[] decryptedtex = Sıfrecoz(sifrelimetin, RSA.ExportParameters(true), false);
            Txtsonuc2.Text = ByteConverter.GetString(decryptedtex);
        }
    }
}
