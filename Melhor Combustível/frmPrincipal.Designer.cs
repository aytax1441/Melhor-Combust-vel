
namespace Melhor_Combustível
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.valEtanol = new System.Windows.Forms.MaskedTextBox();
            this.valGasolina = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOpcoes = new System.Windows.Forms.GroupBox();
            this.rdbCalculado = new System.Windows.Forms.RadioButton();
            this.rdbPadrao = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // valEtanol
            // 
            this.valEtanol.Location = new System.Drawing.Point(41, 64);
            this.valEtanol.Mask = "0,000";
            this.valEtanol.Name = "valEtanol";
            this.valEtanol.Size = new System.Drawing.Size(77, 23);
            this.valEtanol.TabIndex = 0;
            this.valEtanol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valEtanol.ValidatingType = typeof(int);
            // 
            // valGasolina
            // 
            this.valGasolina.Location = new System.Drawing.Point(41, 108);
            this.valGasolina.Mask = "0,000";
            this.valGasolina.Name = "valGasolina";
            this.valGasolina.Size = new System.Drawing.Size(77, 23);
            this.valGasolina.TabIndex = 1;
            this.valGasolina.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valGasolina.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Etanol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor Gasolina";
            // 
            // grpOpcoes
            // 
            this.grpOpcoes.Controls.Add(this.rdbCalculado);
            this.grpOpcoes.Controls.Add(this.rdbPadrao);
            this.grpOpcoes.Location = new System.Drawing.Point(3, 137);
            this.grpOpcoes.Name = "grpOpcoes";
            this.grpOpcoes.Size = new System.Drawing.Size(151, 72);
            this.grpOpcoes.TabIndex = 4;
            this.grpOpcoes.TabStop = false;
            this.grpOpcoes.Text = "Opção";
            // 
            // rdbCalculado
            // 
            this.rdbCalculado.AutoSize = true;
            this.rdbCalculado.Location = new System.Drawing.Point(10, 47);
            this.rdbCalculado.Name = "rdbCalculado";
            this.rdbCalculado.Size = new System.Drawing.Size(127, 19);
            this.rdbCalculado.TabIndex = 1;
            this.rdbCalculado.Text = "Utilizar % calculada";
            this.rdbCalculado.UseVisualStyleBackColor = true;
            // 
            // rdbPadrao
            // 
            this.rdbPadrao.AutoSize = true;
            this.rdbPadrao.Checked = true;
            this.rdbPadrao.Location = new System.Drawing.Point(10, 22);
            this.rdbPadrao.Name = "rdbPadrao";
            this.rdbPadrao.Size = new System.Drawing.Size(114, 19);
            this.rdbPadrao.TabIndex = 0;
            this.rdbPadrao.TabStop = true;
            this.rdbPadrao.Text = "Utilizar % padrão";
            this.rdbPadrao.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(17, 215);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(122, 27);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Melhor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Combustível";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(158, 252);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.grpOpcoes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valGasolina);
            this.Controls.Add(this.valEtanol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combustível";
            this.grpOpcoes.ResumeLayout(false);
            this.grpOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox valEtanol;
        private System.Windows.Forms.MaskedTextBox valGasolina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpOpcoes;
        private System.Windows.Forms.RadioButton rdbCalculado;
        private System.Windows.Forms.RadioButton rdbPadrao;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

