
namespace Lanchonete.Telas
{
    partial class F_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Usuário = new System.Windows.Forms.Label();
            this.TX_Usuario = new System.Windows.Forms.TextBox();
            this.BT_Cancelar = new System.Windows.Forms.Button();
            this.TX_Senha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_Confirma = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuário
            // 
            this.Usuário.AutoSize = true;
            this.Usuário.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuário.Location = new System.Drawing.Point(23, 131);
            this.Usuário.Name = "Usuário";
            this.Usuário.Size = new System.Drawing.Size(60, 18);
            this.Usuário.TabIndex = 0;
            this.Usuário.Text = "Usuário";
            // 
            // TX_Usuario
            // 
            this.TX_Usuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TX_Usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TX_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Usuario.Location = new System.Drawing.Point(91, 128);
            this.TX_Usuario.Name = "TX_Usuario";
            this.TX_Usuario.Size = new System.Drawing.Size(147, 24);
            this.TX_Usuario.TabIndex = 1;
            // 
            // BT_Cancelar
            // 
            this.BT_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Cancelar.Location = new System.Drawing.Point(224, 291);
            this.BT_Cancelar.Name = "BT_Cancelar";
            this.BT_Cancelar.Size = new System.Drawing.Size(82, 31);
            this.BT_Cancelar.TabIndex = 4;
            this.BT_Cancelar.Text = "Cancelar";
            this.BT_Cancelar.UseVisualStyleBackColor = true;
            this.BT_Cancelar.Click += new System.EventHandler(this.BT_Cancelar_Click);
            // 
            // TX_Senha
            // 
            this.TX_Senha.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TX_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TX_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Senha.Location = new System.Drawing.Point(91, 175);
            this.TX_Senha.Name = "TX_Senha";
            this.TX_Senha.Size = new System.Drawing.Size(147, 24);
            this.TX_Senha.TabIndex = 2;
            this.TX_Senha.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Senha";
            // 
            // BT_Confirma
            // 
            this.BT_Confirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Confirma.Location = new System.Drawing.Point(118, 291);
            this.BT_Confirma.Name = "BT_Confirma";
            this.BT_Confirma.Size = new System.Drawing.Size(89, 31);
            this.BT_Confirma.TabIndex = 3;
            this.BT_Confirma.Text = "Confirma";
            this.BT_Confirma.UseVisualStyleBackColor = true;
            this.BT_Confirma.Click += new System.EventHandler(this.BT_Confirma_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lanchonete.Properties.Resources.icons8_bust_in_silhouette_100;
            this.pictureBox1.Location = new System.Drawing.Point(111, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(329, 334);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BT_Confirma);
            this.Controls.Add(this.TX_Senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_Cancelar);
            this.Controls.Add(this.TX_Usuario);
            this.Controls.Add(this.Usuário);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuário;
        private System.Windows.Forms.TextBox TX_Usuario;
        private System.Windows.Forms.Button BT_Cancelar;
        private System.Windows.Forms.TextBox TX_Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_Confirma;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}