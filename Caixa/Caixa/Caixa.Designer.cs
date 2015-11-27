namespace Caixa
{
    partial class Caixa
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.definePreco = new System.Windows.Forms.Button();
            this.precoGasolina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBomba1 = new System.Windows.Forms.TabPage();
            this.bomba1Cancelada = new System.Windows.Forms.Button();
            this.bomba1Paga = new System.Windows.Forms.Button();
            this.valorAbastecidoBomba1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabBomba2 = new System.Windows.Forms.TabPage();
            this.bomba2Cancelada = new System.Windows.Forms.Button();
            this.bomba2Paga = new System.Windows.Forms.Button();
            this.valorAbastecidoBomba2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTipFechamento = new System.Windows.Forms.ToolTip(this.components);
            this.bomba1 = new System.ComponentModel.BackgroundWorker();
            this.bomba2 = new System.ComponentModel.BackgroundWorker();
            this.fechamento = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabBomba1.SuspendLayout();
            this.tabBomba2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabBomba1);
            this.tabControl1.Controls.Add(this.tabBomba2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(564, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupBox2);
            this.tabSettings.Controls.Add(this.groupBox1);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(556, 305);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Configurações";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.fechamento);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 208);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fechamento";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Realizar Fechamento";
            this.toolTipFechamento.SetToolTip(this.button1, "Realiza o fechamento das vendas do dia anterior");
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.definePreco);
            this.groupBox1.Controls.Add(this.precoGasolina);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preço da Gasolina";
            // 
            // definePreco
            // 
            this.definePreco.Location = new System.Drawing.Point(282, 33);
            this.definePreco.Name = "definePreco";
            this.definePreco.Size = new System.Drawing.Size(104, 23);
            this.definePreco.TabIndex = 2;
            this.definePreco.Text = "&Define Preço";
            this.definePreco.UseVisualStyleBackColor = true;
            this.definePreco.Click += new System.EventHandler(this.definePreco_Click);
            // 
            // precoGasolina
            // 
            this.precoGasolina.Location = new System.Drawing.Point(176, 36);
            this.precoGasolina.Name = "precoGasolina";
            this.precoGasolina.Size = new System.Drawing.Size(100, 20);
            this.precoGasolina.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "R$";
            // 
            // tabBomba1
            // 
            this.tabBomba1.Controls.Add(this.bomba1Cancelada);
            this.tabBomba1.Controls.Add(this.bomba1Paga);
            this.tabBomba1.Controls.Add(this.valorAbastecidoBomba1);
            this.tabBomba1.Controls.Add(this.label2);
            this.tabBomba1.Location = new System.Drawing.Point(4, 22);
            this.tabBomba1.Name = "tabBomba1";
            this.tabBomba1.Padding = new System.Windows.Forms.Padding(3);
            this.tabBomba1.Size = new System.Drawing.Size(556, 305);
            this.tabBomba1.TabIndex = 1;
            this.tabBomba1.Text = "Bomba 1";
            this.tabBomba1.UseVisualStyleBackColor = true;
            // 
            // bomba1Cancelada
            // 
            this.bomba1Cancelada.Location = new System.Drawing.Point(240, 158);
            this.bomba1Cancelada.Name = "bomba1Cancelada";
            this.bomba1Cancelada.Size = new System.Drawing.Size(115, 23);
            this.bomba1Cancelada.TabIndex = 3;
            this.bomba1Cancelada.Text = "Venda Cancelada";
            this.bomba1Cancelada.UseVisualStyleBackColor = true;
            // 
            // bomba1Paga
            // 
            this.bomba1Paga.Location = new System.Drawing.Point(129, 158);
            this.bomba1Paga.Name = "bomba1Paga";
            this.bomba1Paga.Size = new System.Drawing.Size(75, 23);
            this.bomba1Paga.TabIndex = 2;
            this.bomba1Paga.Text = "Pago";
            this.bomba1Paga.UseVisualStyleBackColor = true;
            this.bomba1Paga.Click += new System.EventHandler(this.bomba1Paga_Click);
            // 
            // valorAbastecidoBomba1
            // 
            this.valorAbastecidoBomba1.AutoSize = true;
            this.valorAbastecidoBomba1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorAbastecidoBomba1.Location = new System.Drawing.Point(236, 77);
            this.valorAbastecidoBomba1.Name = "valorAbastecidoBomba1";
            this.valorAbastecidoBomba1.Size = new System.Drawing.Size(79, 29);
            this.valorAbastecidoBomba1.TabIndex = 1;
            this.valorAbastecidoBomba1.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Abastecimento:";
            // 
            // tabBomba2
            // 
            this.tabBomba2.Controls.Add(this.bomba2Cancelada);
            this.tabBomba2.Controls.Add(this.bomba2Paga);
            this.tabBomba2.Controls.Add(this.valorAbastecidoBomba2);
            this.tabBomba2.Controls.Add(this.label4);
            this.tabBomba2.Location = new System.Drawing.Point(4, 22);
            this.tabBomba2.Name = "tabBomba2";
            this.tabBomba2.Size = new System.Drawing.Size(556, 305);
            this.tabBomba2.TabIndex = 2;
            this.tabBomba2.Text = "Bomba 2";
            this.tabBomba2.UseVisualStyleBackColor = true;
            // 
            // bomba2Cancelada
            // 
            this.bomba2Cancelada.Location = new System.Drawing.Point(240, 158);
            this.bomba2Cancelada.Name = "bomba2Cancelada";
            this.bomba2Cancelada.Size = new System.Drawing.Size(115, 23);
            this.bomba2Cancelada.TabIndex = 7;
            this.bomba2Cancelada.Text = "Venda Cancelada";
            this.bomba2Cancelada.UseVisualStyleBackColor = true;
            // 
            // bomba2Paga
            // 
            this.bomba2Paga.Location = new System.Drawing.Point(129, 158);
            this.bomba2Paga.Name = "bomba2Paga";
            this.bomba2Paga.Size = new System.Drawing.Size(75, 23);
            this.bomba2Paga.TabIndex = 6;
            this.bomba2Paga.Text = "Pago";
            this.bomba2Paga.UseVisualStyleBackColor = true;
            // 
            // valorAbastecidoBomba2
            // 
            this.valorAbastecidoBomba2.AutoSize = true;
            this.valorAbastecidoBomba2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorAbastecidoBomba2.Location = new System.Drawing.Point(236, 77);
            this.valorAbastecidoBomba2.Name = "valorAbastecidoBomba2";
            this.valorAbastecidoBomba2.Size = new System.Drawing.Size(79, 29);
            this.valorAbastecidoBomba2.TabIndex = 5;
            this.valorAbastecidoBomba2.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Abastecimento:";
            // 
            // bomba1
            // 
            this.bomba1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bomba1_DoWork);
            this.bomba1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bomba1_ProgressChanged);
            // 
            // bomba2
            // 
            this.bomba2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bomba2_DoWork);
            // 
            // fechamento
            // 
            this.fechamento.AutoSize = true;
            this.fechamento.Location = new System.Drawing.Point(351, 78);
            this.fechamento.Name = "fechamento";
            this.fechamento.Size = new System.Drawing.Size(35, 13);
            this.fechamento.TabIndex = 3;
            this.fechamento.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor vendido no dia anterior:";
            // 
            // Caixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 352);
            this.Controls.Add(this.tabControl1);
            this.Name = "Caixa";
            this.Text = "Caixa";
            this.Load += new System.EventHandler(this.Caixa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabBomba1.ResumeLayout(false);
            this.tabBomba1.PerformLayout();
            this.tabBomba2.ResumeLayout(false);
            this.tabBomba2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabBomba1;
        private System.Windows.Forms.TabPage tabBomba2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button definePreco;
        private System.Windows.Forms.TextBox precoGasolina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bomba1Cancelada;
        private System.Windows.Forms.Button bomba1Paga;
        private System.Windows.Forms.Label valorAbastecidoBomba1;
        private System.Windows.Forms.Button bomba2Cancelada;
        private System.Windows.Forms.Button bomba2Paga;
        private System.Windows.Forms.Label valorAbastecidoBomba2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTipFechamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fechamento;
        private System.ComponentModel.BackgroundWorker bomba1;
        private System.ComponentModel.BackgroundWorker bomba2;
    }
}

