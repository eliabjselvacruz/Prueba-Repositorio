namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.lblResul = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(53, 73);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(262, 20);
            this.txtN1.TabIndex = 0;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(157, 44);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(56, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Numero 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero 2:";
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(53, 152);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(262, 20);
            this.txtN2.TabIndex = 2;
            // 
            // btnSum
            // 
            this.btnSum.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSum.Image = ((System.Drawing.Image)(resources.GetObject("btnSum.Image")));
            this.btnSum.Location = new System.Drawing.Point(53, 219);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(89, 37);
            this.btnSum.TabIndex = 4;
            this.btnSum.UseVisualStyleBackColor = false;
            // 
            // btnRes
            // 
            this.btnRes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRes.Image = ((System.Drawing.Image)(resources.GetObject("btnRes.Image")));
            this.btnRes.Location = new System.Drawing.Point(148, 219);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(75, 37);
            this.btnRes.TabIndex = 5;
            this.btnRes.UseVisualStyleBackColor = false;
            // 
            // lblResul
            // 
            this.lblResul.AutoSize = true;
            this.lblResul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResul.Location = new System.Drawing.Point(106, 297);
            this.lblResul.Name = "lblResul";
            this.lblResul.Size = new System.Drawing.Size(146, 31);
            this.lblResul.TabIndex = 7;
            this.lblResul.Text = "Resultado";
            this.lblResul.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(229, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 37);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResul);
            this.Controls.Add(this.btnRes);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtN1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Label lblResul;
        private System.Windows.Forms.Button button1;
    }
}

