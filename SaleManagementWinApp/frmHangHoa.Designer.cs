﻿namespace SaleManagementWinApp
{
    partial class frmHangHoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangHoa));
            btnClose = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            dgvHH = new DataGridView();
            txtSearchHH = new TextBox();
            lblKeyword = new Label();
            lblQLHH = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvHH).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Purple;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(643, 399);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(117, 41);
            btnClose.TabIndex = 15;
            btnClose.Text = "Thoát";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Purple;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(455, 399);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(124, 41);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Xóa";
            btnDelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.Purple;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(241, 399);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(140, 41);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnNew.ForeColor = Color.Purple;
            btnNew.Image = (Image)resources.GetObject("btnNew.Image");
            btnNew.Location = new Point(40, 399);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(140, 41);
            btnNew.TabIndex = 12;
            btnNew.Text = "Thêm mới";
            btnNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // dgvHH
            // 
            dgvHH.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHH.Location = new Point(40, 117);
            dgvHH.Name = "dgvHH";
            dgvHH.RowHeadersWidth = 51;
            dgvHH.RowTemplate.Height = 29;
            dgvHH.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHH.Size = new Size(720, 251);
            dgvHH.TabIndex = 11;
            dgvHH.CellClick += dgvHH_CellClick;
            dgvHH.CellDoubleClick += dgvHH_CellDoubleClick;
            // 
            // txtSearchHH
            // 
            txtSearchHH.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearchHH.Location = new Point(230, 72);
            txtSearchHH.Name = "txtSearchHH";
            txtSearchHH.Size = new Size(349, 30);
            txtSearchHH.TabIndex = 10;
            txtSearchHH.TextChanged += txtSearchHH_TextChanged;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblKeyword.ForeColor = Color.Purple;
            lblKeyword.Location = new Point(68, 75);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(153, 23);
            lblKeyword.TabIndex = 9;
            lblKeyword.Text = "Từ khóa tìm kiếm";
            // 
            // lblQLHH
            // 
            lblQLHH.AutoSize = true;
            lblQLHH.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lblQLHH.ForeColor = Color.Purple;
            lblQLHH.Location = new Point(230, 11);
            lblQLHH.Name = "lblQLHH";
            lblQLHH.Size = new Size(287, 37);
            lblQLHH.TabIndex = 8;
            lblQLHH.Text = "QUẢN LÝ HÀNG HÓA";
            // 
            // frmHangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnNew);
            Controls.Add(dgvHH);
            Controls.Add(txtSearchHH);
            Controls.Add(lblKeyword);
            Controls.Add(lblQLHH);
            Name = "frmHangHoa";
            Text = "Hàng hóa";
            Load += frmHangHoa_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHH).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnNew;
        private DataGridView dgvHH;
        private TextBox txtSearchHH;
        private Label lblKeyword;
        private Label lblQLHH;
    }
}