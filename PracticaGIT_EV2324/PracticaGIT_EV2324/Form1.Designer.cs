namespace PracticaGIT_EV2324
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbText = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.rbOrdinary = new System.Windows.Forms.RadioButton();
            this.rbUrgent = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(62, 87);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(584, 119);
            this.tbText.TabIndex = 0;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(125, 304);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(139, 26);
            this.tbPrice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coste:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(488, 286);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(158, 44);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // rbOrdinary
            // 
            this.rbOrdinary.AutoSize = true;
            this.rbOrdinary.Location = new System.Drawing.Point(62, 238);
            this.rbOrdinary.Name = "rbOrdinary";
            this.rbOrdinary.Size = new System.Drawing.Size(98, 24);
            this.rbOrdinary.TabIndex = 6;
            this.rbOrdinary.TabStop = true;
            this.rbOrdinary.Text = "Ordinario";
            this.rbOrdinary.UseVisualStyleBackColor = true;
            // 
            // rbUrgent
            // 
            this.rbUrgent.AutoSize = true;
            this.rbUrgent.Location = new System.Drawing.Point(247, 238);
            this.rbUrgent.Name = "rbUrgent";
            this.rbUrgent.Size = new System.Drawing.Size(92, 24);
            this.rbUrgent.TabIndex = 7;
            this.rbUrgent.TabStop = true;
            this.rbUrgent.Text = "Urgente";
            this.rbUrgent.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbUrgent);
            this.Controls.Add(this.rbOrdinary);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbText);
            this.Name = "Form1";
            this.Text = "PracticaGIT_EV2324";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.RadioButton rbOrdinary;
        private System.Windows.Forms.RadioButton rbUrgent;
    }
}

