namespace ExercicioWindowsForm
{
    partial class Exercicio02
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantidadeLitros = new System.Windows.Forms.TextBox();
            this.txtQuantidadeAnosConsumidos = new System.Windows.Forms.TextBox();
            this.btnQuantidadeLitros = new System.Windows.Forms.Button();
            this.btnValorTotal = new System.Windows.Forms.Button();
            this.mtbValor = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Litros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de anos consumidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor por Litro";
            // 
            // txtQuantidadeLitros
            // 
            this.txtQuantidadeLitros.Location = new System.Drawing.Point(301, 68);
            this.txtQuantidadeLitros.Name = "txtQuantidadeLitros";
            this.txtQuantidadeLitros.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeLitros.TabIndex = 5;
            // 
            // txtQuantidadeAnosConsumidos
            // 
            this.txtQuantidadeAnosConsumidos.Location = new System.Drawing.Point(301, 114);
            this.txtQuantidadeAnosConsumidos.Name = "txtQuantidadeAnosConsumidos";
            this.txtQuantidadeAnosConsumidos.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeAnosConsumidos.TabIndex = 6;
            // 
            // btnQuantidadeLitros
            // 
            this.btnQuantidadeLitros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuantidadeLitros.Location = new System.Drawing.Point(17, 191);
            this.btnQuantidadeLitros.Name = "btnQuantidadeLitros";
            this.btnQuantidadeLitros.Size = new System.Drawing.Size(169, 54);
            this.btnQuantidadeLitros.TabIndex = 7;
            this.btnQuantidadeLitros.Text = "Quantidade de Litros Consumidos";
            this.btnQuantidadeLitros.UseVisualStyleBackColor = true;
            this.btnQuantidadeLitros.Click += new System.EventHandler(this.btnQuantidadeLitros_Click);
            // 
            // btnValorTotal
            // 
            this.btnValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValorTotal.Location = new System.Drawing.Point(301, 191);
            this.btnValorTotal.Name = "btnValorTotal";
            this.btnValorTotal.Size = new System.Drawing.Size(100, 54);
            this.btnValorTotal.TabIndex = 8;
            this.btnValorTotal.Text = "Valor Total ";
            this.btnValorTotal.UseVisualStyleBackColor = true;
            this.btnValorTotal.Click += new System.EventHandler(this.btnValorTotal_Click);
            // 
            // mtbValor
            // 
            this.mtbValor.Location = new System.Drawing.Point(301, 23);
            this.mtbValor.Mask = "000,00";
            this.mtbValor.Name = "mtbValor";
            this.mtbValor.Size = new System.Drawing.Size(100, 20);
            this.mtbValor.TabIndex = 9;
            // 
            // Exercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(716, 437);
            this.Controls.Add(this.mtbValor);
            this.Controls.Add(this.btnValorTotal);
            this.Controls.Add(this.btnQuantidadeLitros);
            this.Controls.Add(this.txtQuantidadeAnosConsumidos);
            this.Controls.Add(this.txtQuantidadeLitros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Exercicio02";
            this.Text = "Exercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidadeLitros;
        private System.Windows.Forms.TextBox txtQuantidadeAnosConsumidos;
        private System.Windows.Forms.Button btnQuantidadeLitros;
        private System.Windows.Forms.Button btnValorTotal;
        private System.Windows.Forms.MaskedTextBox mtbValor;
    }
}