namespace ServiceLedger
{
    partial class ProductsForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnOpenClientsForm = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenProductsForm = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenSalesForm = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteProduct = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(158, 109);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(550, 308);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // btnOpenClientsForm
            // 
            this.btnOpenClientsForm.Location = new System.Drawing.Point(269, 423);
            this.btnOpenClientsForm.Name = "btnOpenClientsForm";
            this.btnOpenClientsForm.Size = new System.Drawing.Size(114, 36);
            this.btnOpenClientsForm.TabIndex = 1;
            this.btnOpenClientsForm.Text = "Форма Клиенты";
            // 
            // btnOpenProductsForm
            // 
            this.btnOpenProductsForm.Location = new System.Drawing.Point(402, 423);
            this.btnOpenProductsForm.Name = "btnOpenProductsForm";
            this.btnOpenProductsForm.Size = new System.Drawing.Size(110, 36);
            this.btnOpenProductsForm.TabIndex = 2;
            this.btnOpenProductsForm.Text = "Форма Товары";
            // 
            // btnOpenSalesForm
            // 
            this.btnOpenSalesForm.Location = new System.Drawing.Point(559, 423);
            this.btnOpenSalesForm.Name = "btnOpenSalesForm";
            this.btnOpenSalesForm.Size = new System.Drawing.Size(149, 36);
            this.btnOpenSalesForm.TabIndex = 3;
            this.btnOpenSalesForm.Text = "Форма Продаж и отчетов ";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(17, 109);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(99, 44);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(17, 173);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(100, 44);
            this.btnEditProduct.TabIndex = 5;
            this.btnEditProduct.Text = "Изменить товар";
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click_1);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(17, 237);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 44);
            this.btnDeleteProduct.TabIndex = 6;
            this.btnDeleteProduct.Text = "Удалить товар";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(269, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(229, 37);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Форма с товарами";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 471);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnOpenSalesForm);
            this.Controls.Add(this.btnOpenProductsForm);
            this.Controls.Add(this.btnOpenClientsForm);
            this.Controls.Add(this.gridControl1);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnOpenClientsForm;
        private DevExpress.XtraEditors.SimpleButton btnOpenProductsForm;
        private DevExpress.XtraEditors.SimpleButton btnOpenSalesForm;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private DevExpress.XtraEditors.SimpleButton btnEditProduct;
        private DevExpress.XtraEditors.SimpleButton btnDeleteProduct;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}