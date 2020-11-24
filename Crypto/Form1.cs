using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto
{
    public partial class frm_crypto : Form
    {
        public frm_crypto()
        {
            InitializeComponent();
        }

        private void btn_generer_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception erreur)
            {
                lbl_error.Text = erreur.Message;
            }
            Crypto unCrypto = new Crypto();
            tb_cle.Text = unCrypto.GenererCle();
        }
       

        private void btn_crypter_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Text = "";
                Encrypt unCrypt = new Encrypt();
                tb_decrypt.Text = unCrypt.Crypt(tb_crypt.Text, tb_cle.Text);
            }
            catch (DivideByZeroException erreur)
            {
                lbl_error.Text = "Erreur : Aucune clé entrée";
            }
            catch (Exception erreur)
            {
                lbl_error.Text = erreur.Message;
            }
            
        }

        private void btn_decrypter_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Text = "";
                Decrypt unDecrypt = new Decrypt();
                tb_crypt.Text = unDecrypt.DeCrypt(tb_cle.Text, tb_decrypt.Text);
            }
            catch (DivideByZeroException erreur)
            {
                lbl_error.Text = "Erreur : Aucune clé entrée";
            }
            catch (Exception erreur)
            {
                lbl_error.Text = erreur.Message;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_error.Text = "";
                Application.Exit();
            }
            catch (Exception erreur)
            {
                lbl_error.Text = erreur.Message;
            }
        }
    }
}
