namespace Crypto
{
    partial class frm_crypto
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_crypt = new System.Windows.Forms.TextBox();
            this.btn_crypter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_decrypt = new System.Windows.Forms.TextBox();
            this.btn_decrypter = new System.Windows.Forms.Button();
            this.tb_cle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_generer = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texte à crypter :";
            // 
            // tb_crypt
            // 
            this.tb_crypt.BackColor = System.Drawing.Color.Black;
            this.tb_crypt.ForeColor = System.Drawing.Color.White;
            this.tb_crypt.Location = new System.Drawing.Point(139, 37);
            this.tb_crypt.Name = "tb_crypt";
            this.tb_crypt.Size = new System.Drawing.Size(368, 20);
            this.tb_crypt.TabIndex = 1;
            // 
            // btn_crypter
            // 
            this.btn_crypter.Location = new System.Drawing.Point(538, 37);
            this.btn_crypter.Name = "btn_crypter";
            this.btn_crypter.Size = new System.Drawing.Size(75, 23);
            this.btn_crypter.TabIndex = 2;
            this.btn_crypter.Text = "Crypter";
            this.btn_crypter.UseVisualStyleBackColor = true;
            this.btn_crypter.Click += new System.EventHandler(this.btn_crypter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texte à décrypter :";
            // 
            // tb_decrypt
            // 
            this.tb_decrypt.BackColor = System.Drawing.Color.Black;
            this.tb_decrypt.ForeColor = System.Drawing.Color.White;
            this.tb_decrypt.Location = new System.Drawing.Point(139, 81);
            this.tb_decrypt.Name = "tb_decrypt";
            this.tb_decrypt.Size = new System.Drawing.Size(368, 20);
            this.tb_decrypt.TabIndex = 4;
            // 
            // btn_decrypter
            // 
            this.btn_decrypter.Location = new System.Drawing.Point(538, 81);
            this.btn_decrypter.Name = "btn_decrypter";
            this.btn_decrypter.Size = new System.Drawing.Size(75, 23);
            this.btn_decrypter.TabIndex = 5;
            this.btn_decrypter.Text = "Décrypter";
            this.btn_decrypter.UseVisualStyleBackColor = true;
            this.btn_decrypter.Click += new System.EventHandler(this.btn_decrypter_Click);
            // 
            // tb_cle
            // 
            this.tb_cle.BackColor = System.Drawing.Color.Black;
            this.tb_cle.ForeColor = System.Drawing.Color.White;
            this.tb_cle.Location = new System.Drawing.Point(128, 192);
            this.tb_cle.Name = "tb_cle";
            this.tb_cle.Size = new System.Drawing.Size(404, 20);
            this.tb_cle.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(91, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clef :";
            // 
            // btn_generer
            // 
            this.btn_generer.Location = new System.Drawing.Point(538, 192);
            this.btn_generer.Name = "btn_generer";
            this.btn_generer.Size = new System.Drawing.Size(75, 23);
            this.btn_generer.TabIndex = 8;
            this.btn_generer.Text = "Générer";
            this.btn_generer.UseVisualStyleBackColor = true;
            this.btn_generer.Click += new System.EventHandler(this.btn_generer_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 227);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Quitter";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.White;
            this.lbl_error.Location = new System.Drawing.Point(225, 141);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(0, 13);
            this.lbl_error.TabIndex = 10;
            // 
            // frm_crypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(667, 262);
            this.Controls.Add(this.lbl_error);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_generer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cle);
            this.Controls.Add(this.btn_decrypter);
            this.Controls.Add(this.tb_decrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_crypter);
            this.Controls.Add(this.tb_crypt);
            this.Controls.Add(this.label1);
            this.Name = "frm_crypto";
            this.Text = "Crypter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_crypt;
        private System.Windows.Forms.Button btn_crypter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_decrypt;
        private System.Windows.Forms.Button btn_decrypter;
        private System.Windows.Forms.TextBox tb_cle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_generer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_error;
    }
}

