namespace Bomba
{
    partial class Bomba
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
            this.LblLitro = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.TextBox();
            this.unidade = new System.Windows.Forms.ComboBox();
            this.LblMoeda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblLitro
            // 
            this.LblLitro.AutoSize = true;
            this.LblLitro.Location = new System.Drawing.Point(296, 31);
            this.LblLitro.Name = "LblLitro";
            this.LblLitro.Size = new System.Drawing.Size(32, 13);
            this.LblLitro.TabIndex = 5;
            this.LblLitro.Text = "Litros";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(132, 72);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 6;
            this.Ok.Text = "OK";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(192, 27);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(100, 20);
            this.valor.TabIndex = 0;
            this.valor.Leave += new System.EventHandler(this.valor_Leave);
            // 
            // unidade
            // 
            this.unidade.FormattingEnabled = true;
            this.unidade.Items.AddRange(new object[] {
            "Valor (R$)",
            "Litros (L)"});
            this.unidade.Location = new System.Drawing.Point(15, 27);
            this.unidade.Name = "unidade";
            this.unidade.Size = new System.Drawing.Size(121, 21);
            this.unidade.TabIndex = 7;
            this.unidade.SelectedIndexChanged += new System.EventHandler(this.unidade_SelectedIndexChanged);
            // 
            // LblMoeda
            // 
            this.LblMoeda.AutoSize = true;
            this.LblMoeda.Location = new System.Drawing.Point(168, 31);
            this.LblMoeda.Name = "LblMoeda";
            this.LblMoeda.Size = new System.Drawing.Size(21, 13);
            this.LblMoeda.TabIndex = 3;
            this.LblMoeda.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Unidade:";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Location = new System.Drawing.Point(192, 9);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(53, 13);
            this.LblDescricao.TabIndex = 8;
            this.LblDescricao.Text = "descricao";
            // 
            // Bomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 107);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.unidade);
            this.Controls.Add(this.LblLitro);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblMoeda);
            this.Controls.Add(this.valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bomba";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bomba";
            this.Load += new System.EventHandler(this.Bomba_Load);
            this.Shown += new System.EventHandler(this.Bomba_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLitro;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.TextBox valor;
        private System.Windows.Forms.ComboBox unidade;
        private System.Windows.Forms.Label LblMoeda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblDescricao;
    }
}

