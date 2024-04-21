namespace ServiceLedger
{
    partial class SalesEntryForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEditSaleDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlSales = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxClients = new DevExpress.XtraEditors.LookUpEdit();
            this.btnDeleteProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddSale = new DevExpress.XtraEditors.SimpleButton();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.pivotGridControl2 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.comboBoxClient2 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtpEndDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate2 = new System.Windows.Forms.DateTimePicker();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenerateReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenSalesForm = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenProductsForm = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpenClientsForm = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSaleDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSaleDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxClients.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxClient2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Выбрать клинета";
            // 
            // dateEditSaleDate
            // 
            this.dateEditSaleDate.EditValue = null;
            this.dateEditSaleDate.Location = new System.Drawing.Point(19, 128);
            this.dateEditSaleDate.Name = "dateEditSaleDate";
            this.dateEditSaleDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSaleDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditSaleDate.Size = new System.Drawing.Size(100, 20);
            this.dateEditSaleDate.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Дата";
            // 
            // gridControlSales
            // 
            this.gridControlSales.Location = new System.Drawing.Point(179, 56);
            this.gridControlSales.MainView = this.gridView1;
            this.gridControlSales.Name = "gridControlSales";
            this.gridControlSales.Size = new System.Drawing.Size(451, 241);
            this.gridControlSales.TabIndex = 4;
            this.gridControlSales.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlSales;
            this.gridView1.Name = "gridView1";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(19, 175);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(123, 31);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Добавить товар";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.Location = new System.Drawing.Point(19, 75);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxClients.Size = new System.Drawing.Size(100, 20);
            this.comboBoxClients.TabIndex = 6;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(19, 212);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(123, 31);
            this.btnDeleteProduct.TabIndex = 7;
            this.btnDeleteProduct.Text = "Удалить товар";
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(19, 253);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(123, 44);
            this.btnAddSale.TabIndex = 8;
            this.btnAddSale.Text = "Добавить продажу";
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Location = new System.Drawing.Point(782, 56);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl1.Size = new System.Drawing.Size(678, 583);
            this.pivotGridControl1.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(648, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 13);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Дата начала ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(648, 140);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Дата конца";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(643, 100);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(123, 20);
            this.dtpStartDate.TabIndex = 14;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(643, 165);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(123, 20);
            this.dtpEndDate.TabIndex = 15;
            // 
            // pivotGridControl2
            // 
            this.pivotGridControl2.Location = new System.Drawing.Point(179, 369);
            this.pivotGridControl2.Name = "pivotGridControl2";
            this.pivotGridControl2.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.pivotGridControl2.Size = new System.Drawing.Size(587, 270);
            this.pivotGridControl2.TabIndex = 16;
            // 
            // comboBoxClient2
            // 
            this.comboBoxClient2.Location = new System.Drawing.Point(23, 388);
            this.comboBoxClient2.Name = "comboBoxClient2";
            this.comboBoxClient2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxClient2.Size = new System.Drawing.Size(134, 20);
            this.comboBoxClient2.TabIndex = 18;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(23, 369);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(89, 13);
            this.labelControl5.TabIndex = 17;
            this.labelControl5.Text = "Выбрать клинета";
            // 
            // dtpEndDate2
            // 
            this.dtpEndDate2.Location = new System.Drawing.Point(23, 478);
            this.dtpEndDate2.Name = "dtpEndDate2";
            this.dtpEndDate2.Size = new System.Drawing.Size(134, 20);
            this.dtpEndDate2.TabIndex = 22;
            // 
            // dtpStartDate2
            // 
            this.dtpStartDate2.Location = new System.Drawing.Point(23, 433);
            this.dtpStartDate2.Name = "dtpStartDate2";
            this.dtpStartDate2.Size = new System.Drawing.Size(134, 20);
            this.dtpStartDate2.TabIndex = 21;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 459);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(59, 13);
            this.labelControl6.TabIndex = 20;
            this.labelControl6.Text = "Дата конца";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(23, 414);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(68, 13);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "Дата начала ";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(23, 595);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(134, 44);
            this.btnGenerateReport.TabIndex = 23;
            this.btnGenerateReport.Text = "Сформировать отчет ";
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnOpenSalesForm
            // 
            this.btnOpenSalesForm.Location = new System.Drawing.Point(1311, 656);
            this.btnOpenSalesForm.Name = "btnOpenSalesForm";
            this.btnOpenSalesForm.Size = new System.Drawing.Size(149, 36);
            this.btnOpenSalesForm.TabIndex = 26;
            this.btnOpenSalesForm.Text = "Форма Продаж и отчетов ";
            // 
            // btnOpenProductsForm
            // 
            this.btnOpenProductsForm.Location = new System.Drawing.Point(1154, 656);
            this.btnOpenProductsForm.Name = "btnOpenProductsForm";
            this.btnOpenProductsForm.Size = new System.Drawing.Size(110, 36);
            this.btnOpenProductsForm.TabIndex = 25;
            this.btnOpenProductsForm.Text = "Форма Товары";
            // 
            // btnOpenClientsForm
            // 
            this.btnOpenClientsForm.Location = new System.Drawing.Point(1021, 656);
            this.btnOpenClientsForm.Name = "btnOpenClientsForm";
            this.btnOpenClientsForm.Size = new System.Drawing.Size(114, 36);
            this.btnOpenClientsForm.TabIndex = 24;
            this.btnOpenClientsForm.Text = "Форма Клиенты";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(179, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(261, 31);
            this.labelControl8.TabIndex = 27;
            this.labelControl8.Text = "Форма занесения продаж";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(782, 19);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(268, 31);
            this.labelControl9.TabIndex = 28;
            this.labelControl9.Text = "Сводная таблица продаж ";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(179, 332);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(350, 31);
            this.labelControl10.TabIndex = 29;
            this.labelControl10.Text = "Отчет оказанных услуг по клиенту";
            // 
            // SalesEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1474, 705);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnOpenSalesForm);
            this.Controls.Add(this.btnOpenProductsForm);
            this.Controls.Add(this.btnOpenClientsForm);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dtpEndDate2);
            this.Controls.Add(this.dtpStartDate2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.comboBoxClient2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.pivotGridControl2);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pivotGridControl1);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.gridControlSales);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dateEditSaleDate);
            this.Controls.Add(this.labelControl1);
            this.Name = "SalesEntryForm";
            this.Text = "SalesEntryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSaleDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditSaleDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxClients.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxClient2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEditSaleDate;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.GridControl gridControlSales;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
        private DevExpress.XtraEditors.LookUpEdit comboBoxClients;
        private DevExpress.XtraEditors.SimpleButton btnDeleteProduct;
        private DevExpress.XtraEditors.SimpleButton btnAddSale;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl2;
        private DevExpress.XtraEditors.LookUpEdit comboBoxClient2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DateTimePicker dtpEndDate2;
        private System.Windows.Forms.DateTimePicker dtpStartDate2;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnGenerateReport;
        private DevExpress.XtraEditors.SimpleButton btnOpenSalesForm;
        private DevExpress.XtraEditors.SimpleButton btnOpenProductsForm;
        private DevExpress.XtraEditors.SimpleButton btnOpenClientsForm;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
    }
}