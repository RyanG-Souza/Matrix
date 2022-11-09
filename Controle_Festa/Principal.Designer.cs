namespace Controle_Festa
{
    partial class Principal
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
            this.lbl_Título = new System.Windows.Forms.Label();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.btm_Verificar = new System.Windows.Forms.Button();
            this.lbl_sobrenome = new System.Windows.Forms.Label();
            this.lbl_data = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.btm_Limpar = new System.Windows.Forms.Button();
            this.txb_sobrenome = new System.Windows.Forms.TextBox();
            this.txb_data = new System.Windows.Forms.TextBox();
            this.btm_Sair = new System.Windows.Forms.Button();
            this.pib_Headphones = new System.Windows.Forms.PictureBox();
            this.lbl_Cadsuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pib_Headphones)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Título
            // 
            this.lbl_Título.AutoSize = true;
            this.lbl_Título.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Título.Location = new System.Drawing.Point(224, 28);
            this.lbl_Título.Name = "lbl_Título";
            this.lbl_Título.Size = new System.Drawing.Size(231, 24);
            this.lbl_Título.TabIndex = 1;
            this.lbl_Título.Text = "MaTrIx_UnDeRgRoUnD";
            // 
            // txb_nome
            // 
            this.txb_nome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nome.Location = new System.Drawing.Point(210, 88);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(100, 25);
            this.txb_nome.TabIndex = 3;
            // 
            // btm_Verificar
            // 
            this.btm_Verificar.BackColor = System.Drawing.Color.Lime;
            this.btm_Verificar.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Verificar.Location = new System.Drawing.Point(96, 308);
            this.btm_Verificar.Name = "btm_Verificar";
            this.btm_Verificar.Size = new System.Drawing.Size(138, 62);
            this.btm_Verificar.TabIndex = 4;
            this.btm_Verificar.Text = "Cadastrar";
            this.btm_Verificar.UseVisualStyleBackColor = false;
            this.btm_Verificar.Click += new System.EventHandler(this.btm_Verificar_Click);
            // 
            // lbl_sobrenome
            // 
            this.lbl_sobrenome.AutoSize = true;
            this.lbl_sobrenome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sobrenome.Location = new System.Drawing.Point(120, 119);
            this.lbl_sobrenome.Name = "lbl_sobrenome";
            this.lbl_sobrenome.Size = new System.Drawing.Size(84, 19);
            this.lbl_sobrenome.TabIndex = 5;
            this.lbl_sobrenome.Text = "Sobrenome";
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_data.Location = new System.Drawing.Point(63, 156);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(141, 19);
            this.lbl_data.TabIndex = 5;
            this.lbl_data.Text = "Data de nascimento";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(155, 88);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(49, 19);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "Nome";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(535, 56);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 22);
            this.lbl_resultado.TabIndex = 6;
            // 
            // btm_Limpar
            // 
            this.btm_Limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btm_Limpar.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Limpar.Location = new System.Drawing.Point(262, 315);
            this.btm_Limpar.Name = "btm_Limpar";
            this.btm_Limpar.Size = new System.Drawing.Size(109, 49);
            this.btm_Limpar.TabIndex = 7;
            this.btm_Limpar.Text = "Limpar";
            this.btm_Limpar.UseVisualStyleBackColor = false;
            this.btm_Limpar.Click += new System.EventHandler(this.btm_Limpar_Click);
            // 
            // txb_sobrenome
            // 
            this.txb_sobrenome.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_sobrenome.Location = new System.Drawing.Point(210, 119);
            this.txb_sobrenome.Name = "txb_sobrenome";
            this.txb_sobrenome.Size = new System.Drawing.Size(100, 25);
            this.txb_sobrenome.TabIndex = 3;
            // 
            // txb_data
            // 
            this.txb_data.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_data.Location = new System.Drawing.Point(210, 150);
            this.txb_data.Name = "txb_data";
            this.txb_data.Size = new System.Drawing.Size(100, 25);
            this.txb_data.TabIndex = 3;
            // 
            // btm_Sair
            // 
            this.btm_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btm_Sair.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btm_Sair.Location = new System.Drawing.Point(392, 315);
            this.btm_Sair.Name = "btm_Sair";
            this.btm_Sair.Size = new System.Drawing.Size(109, 49);
            this.btm_Sair.TabIndex = 7;
            this.btm_Sair.Text = "Sair";
            this.btm_Sair.UseVisualStyleBackColor = false;
            this.btm_Sair.Click += new System.EventHandler(this.btm_Sair_Click);
            // 
            // pib_Headphones
            // 
            this.pib_Headphones.Location = new System.Drawing.Point(539, 99);
            this.pib_Headphones.Name = "pib_Headphones";
            this.pib_Headphones.Size = new System.Drawing.Size(178, 196);
            this.pib_Headphones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pib_Headphones.TabIndex = 0;
            this.pib_Headphones.TabStop = false;
            // 
            // lbl_Cadsuc
            // 
            this.lbl_Cadsuc.AutoSize = true;
            this.lbl_Cadsuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cadsuc.Location = new System.Drawing.Point(501, 28);
            this.lbl_Cadsuc.Name = "lbl_Cadsuc";
            this.lbl_Cadsuc.Size = new System.Drawing.Size(0, 19);
            this.lbl_Cadsuc.TabIndex = 8;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 508);
            this.Controls.Add(this.lbl_Cadsuc);
            this.Controls.Add(this.btm_Sair);
            this.Controls.Add(this.btm_Limpar);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_data);
            this.Controls.Add(this.lbl_sobrenome);
            this.Controls.Add(this.btm_Verificar);
            this.Controls.Add(this.txb_data);
            this.Controls.Add(this.txb_sobrenome);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.lbl_Título);
            this.Controls.Add(this.pib_Headphones);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)(this.pib_Headphones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pib_Headphones;
        private System.Windows.Forms.Label lbl_Título;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.Button btm_Verificar;
        private System.Windows.Forms.Label lbl_sobrenome;
        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Button btm_Limpar;
        private System.Windows.Forms.TextBox txb_sobrenome;
        private System.Windows.Forms.TextBox txb_data;
        private System.Windows.Forms.Button btm_Sair;
        private System.Windows.Forms.Label lbl_Cadsuc;
    }
}