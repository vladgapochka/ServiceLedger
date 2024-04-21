namespace ServiceLedger
{
    partial class MainForm
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
            this.btnOpenClientsForm = new System.Windows.Forms.Button();
            this.btnOpenProductsForm = new System.Windows.Forms.Button();
            this.btnOpenSalesForm = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnEditClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(164, 99);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(448, 419);
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
            this.btnOpenClientsForm.Location = new System.Drawing.Point(164, 548);
            this.btnOpenClientsForm.Name = "btnOpenClientsForm";
            this.btnOpenClientsForm.Size = new System.Drawing.Size(124, 40);
            this.btnOpenClientsForm.TabIndex = 1;
            this.btnOpenClientsForm.Text = "Форма Клиентов";
            this.btnOpenClientsForm.UseVisualStyleBackColor = true;
            // 
            // btnOpenProductsForm
            // 
            this.btnOpenProductsForm.Location = new System.Drawing.Point(336, 548);
            this.btnOpenProductsForm.Name = "btnOpenProductsForm";
            this.btnOpenProductsForm.Size = new System.Drawing.Size(101, 40);
            this.btnOpenProductsForm.TabIndex = 2;
            this.btnOpenProductsForm.Text = "Форма товаров";
            this.btnOpenProductsForm.UseVisualStyleBackColor = true;
            // 
            // btnOpenSalesForm
            // 
            this.btnOpenSalesForm.Location = new System.Drawing.Point(495, 548);
            this.btnOpenSalesForm.Name = "btnOpenSalesForm";
            this.btnOpenSalesForm.Size = new System.Drawing.Size(117, 40);
            this.btnOpenSalesForm.TabIndex = 3;
            this.btnOpenSalesForm.Text = "Форма Продаж и отчетов ";
            this.btnOpenSalesForm.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(23, 99);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(104, 41);
            this.btnAddClient.TabIndex = 5;
            this.btnAddClient.Text = "Добавить Клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnEditClient
            // 
            this.btnEditClient.Location = new System.Drawing.Point(23, 157);
            this.btnEditClient.Name = "btnEditClient";
            this.btnEditClient.Size = new System.Drawing.Size(104, 41);
            this.btnEditClient.TabIndex = 6;
            this.btnEditClient.Text = "Изменить Клиента";
            this.btnEditClient.UseVisualStyleBackColor = true;
            this.btnEditClient.Click += new System.EventHandler(this.btnEditClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(23, 214);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(104, 41);
            this.btnDeleteClient.TabIndex = 7;
            this.btnDeleteClient.Text = "Удалить";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(224, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(240, 37);
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Форма с клиентами";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 603);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnEditClient);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.btnOpenSalesForm);
            this.Controls.Add(this.btnOpenProductsForm);
            this.Controls.Add(this.btnOpenClientsForm);
            this.Controls.Add(this.gridControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Button btnOpenClientsForm;
        private System.Windows.Forms.Button btnOpenProductsForm;
        private System.Windows.Forms.Button btnOpenSalesForm;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

