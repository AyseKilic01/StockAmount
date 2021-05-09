namespace StockAmount
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmountHDD = new System.Windows.Forms.TextBox();
            this.btnAmountGsm = new System.Windows.Forms.TextBox();
            this.btnSellGsm = new DevExpress.XtraEditors.SimpleButton();
            this.btnSellHDD = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(26, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(135, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Hard Disk Amount";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(26, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(96, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "GSM Amount";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(175, 98);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(6, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = ":";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(175, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(6, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = ":";
            // 
            // txtAmountHDD
            // 
            this.txtAmountHDD.Enabled = false;
            this.txtAmountHDD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmountHDD.Location = new System.Drawing.Point(202, 44);
            this.txtAmountHDD.Name = "txtAmountHDD";
            this.txtAmountHDD.Size = new System.Drawing.Size(188, 27);
            this.txtAmountHDD.TabIndex = 4;
            // 
            // btnAmountGsm
            // 
            this.btnAmountGsm.Enabled = false;
            this.btnAmountGsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAmountGsm.Location = new System.Drawing.Point(202, 96);
            this.btnAmountGsm.Name = "btnAmountGsm";
            this.btnAmountGsm.Size = new System.Drawing.Size(188, 27);
            this.btnAmountGsm.TabIndex = 5;
            // 
            // btnSellGsm
            // 
            this.btnSellGsm.Location = new System.Drawing.Point(255, 256);
            this.btnSellGsm.Name = "btnSellGsm";
            this.btnSellGsm.Size = new System.Drawing.Size(135, 29);
            this.btnSellGsm.TabIndex = 6;
            this.btnSellGsm.Text = "Sell Gsm";
            // 
            // btnSellHDD
            // 
            this.btnSellHDD.Location = new System.Drawing.Point(81, 256);
            this.btnSellHDD.Name = "btnSellHDD";
            this.btnSellHDD.Size = new System.Drawing.Size(135, 29);
            this.btnSellHDD.TabIndex = 7;
            this.btnSellHDD.Text = "Sell HardDisk";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(113, 175);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(103, 22);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "labelControl5";
            this.labelControl5.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 338);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.btnSellHDD);
            this.Controls.Add(this.btnSellGsm);
            this.Controls.Add(this.btnAmountGsm);
            this.Controls.Add(this.txtAmountHDD);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Control";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.TextBox txtAmountHDD;
        private System.Windows.Forms.TextBox btnAmountGsm;
        private DevExpress.XtraEditors.SimpleButton btnSellGsm;
        private DevExpress.XtraEditors.SimpleButton btnSellHDD;
        private DevExpress.XtraEditors.LabelControl labelControl5;
    }
}

