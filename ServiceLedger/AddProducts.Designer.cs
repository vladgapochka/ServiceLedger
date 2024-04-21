namespace ServiceLedger
{
    partial class AddProducts
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
            this.txtCostPerUnit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNameProduct = new DevExpress.XtraEditors.TextEdit();
            this.Save = new DevExpress.XtraEditors.SimpleButton();
            this.Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCostPerUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameProduct.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCostPerUnit
            // 
            this.txtCostPerUnit.Location = new System.Drawing.Point(127, 76);
            this.txtCostPerUnit.Name = "txtCostPerUnit";
            this.txtCostPerUnit.Size = new System.Drawing.Size(100, 20);
            this.txtCostPerUnit.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 79);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Цена за единицу";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Название товара";
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(127, 45);
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(100, 20);
            this.txtNameProduct.TabIndex = 10;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(152, 139);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 41);
            this.Save.TabIndex = 9;
            this.Save.Text = "Добавить";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(49, 139);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 41);
            this.Cancel.TabIndex = 8;
            this.Cancel.Text = "Отменить";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(58, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(143, 19);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Добавление товара";
            // 
            // AddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 202);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtCostPerUnit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Name = "AddProducts";
            this.Text = "AddProducts";
            ((System.ComponentModel.ISupportInitialize)(this.txtCostPerUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameProduct.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtCostPerUnit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtNameProduct;
        private DevExpress.XtraEditors.SimpleButton Save;
        private DevExpress.XtraEditors.SimpleButton Cancel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}