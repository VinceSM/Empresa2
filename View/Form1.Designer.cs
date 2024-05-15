namespace Empresa2
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
            this.lblGameDevCompany = new System.Windows.Forms.Label();
            this.lblOutsourcingCompany = new System.Windows.Forms.Label();
            this.btnEmployeeOS = new System.Windows.Forms.Button();
            this.btnEmployeeGD = new System.Windows.Forms.Button();
            this.txtDescriptionEmployeeOS = new System.Windows.Forms.TextBox();
            this.txtDescriptionEmployeeGD = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // lblGameDevCompany
            // 
            this.lblGameDevCompany.AutoSize = true;
            this.lblGameDevCompany.Location = new System.Drawing.Point(23, 29);
            this.lblGameDevCompany.Name = "lblGameDevCompany";
            this.lblGameDevCompany.Size = new System.Drawing.Size(116, 13);
            this.lblGameDevCompany.TabIndex = 0;
            this.lblGameDevCompany.Text = "GAMEDEV COMPANY";
            // 
            // lblOutsourcingCompany
            // 
            this.lblOutsourcingCompany.AutoSize = true;
            this.lblOutsourcingCompany.Location = new System.Drawing.Point(401, 28);
            this.lblOutsourcingCompany.Name = "lblOutsourcingCompany";
            this.lblOutsourcingCompany.Size = new System.Drawing.Size(143, 13);
            this.lblOutsourcingCompany.TabIndex = 1;
            this.lblOutsourcingCompany.Text = "OUTSOURCING COMPANY";
            // 
            // btnEmployeeOS
            // 
            this.btnEmployeeOS.Location = new System.Drawing.Point(404, 63);
            this.btnEmployeeOS.Name = "btnEmployeeOS";
            this.btnEmployeeOS.Size = new System.Drawing.Size(140, 23);
            this.btnEmployeeOS.TabIndex = 2;
            this.btnEmployeeOS.Text = "VER EMPLEADOS";
            this.btnEmployeeOS.UseVisualStyleBackColor = true;
            this.btnEmployeeOS.Click += new System.EventHandler(this.btnEmployeeOS_Click_1);
            // 
            // btnEmployeeGD
            // 
            this.btnEmployeeGD.Location = new System.Drawing.Point(26, 63);
            this.btnEmployeeGD.Name = "btnEmployeeGD";
            this.btnEmployeeGD.Size = new System.Drawing.Size(113, 23);
            this.btnEmployeeGD.TabIndex = 3;
            this.btnEmployeeGD.Text = "VER EMPLEADOS";
            this.btnEmployeeGD.UseVisualStyleBackColor = true;
            this.btnEmployeeGD.Click += new System.EventHandler(this.btnEmployeeGD_Click_1);
            // 
            // txtDescriptionEmployeeOS
            // 
            this.txtDescriptionEmployeeOS.Location = new System.Drawing.Point(404, 103);
            this.txtDescriptionEmployeeOS.Multiline = true;
            this.txtDescriptionEmployeeOS.Name = "txtDescriptionEmployeeOS";
            this.txtDescriptionEmployeeOS.ReadOnly = true;
            this.txtDescriptionEmployeeOS.Size = new System.Drawing.Size(358, 221);
            this.txtDescriptionEmployeeOS.TabIndex = 4;
            // 
            // txtDescriptionEmployeeGD
            // 
            this.txtDescriptionEmployeeGD.Location = new System.Drawing.Point(26, 103);
            this.txtDescriptionEmployeeGD.Multiline = true;
            this.txtDescriptionEmployeeGD.Name = "txtDescriptionEmployeeGD";
            this.txtDescriptionEmployeeGD.ReadOnly = true;
            this.txtDescriptionEmployeeGD.Size = new System.Drawing.Size(358, 221);
            this.txtDescriptionEmployeeGD.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 450);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.txtDescriptionEmployeeGD);
            this.Controls.Add(this.txtDescriptionEmployeeOS);
            this.Controls.Add(this.btnEmployeeGD);
            this.Controls.Add(this.btnEmployeeOS);
            this.Controls.Add(this.lblOutsourcingCompany);
            this.Controls.Add(this.lblGameDevCompany);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameDevCompany;
        private System.Windows.Forms.Label lblOutsourcingCompany;
        private System.Windows.Forms.Button btnEmployeeOS;
        private System.Windows.Forms.Button btnEmployeeGD;
        private System.Windows.Forms.TextBox txtDescriptionEmployeeOS;
        private System.Windows.Forms.TextBox txtDescriptionEmployeeGD;
        private System.Windows.Forms.Splitter splitter1;
    }
}

