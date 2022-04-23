
namespace Restaurant1
{
    partial class FormOrderDetail
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
            this.CBFoodType = new System.Windows.Forms.ComboBox();
            this.txtCount = new System.Windows.Forms.NumericUpDown();
            this.btnAfzoodan = new System.Windows.Forms.Button();
            this.dgvFormOrderDetail = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodTypeInOrderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountInOrderDetail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnSabtNahaee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(760, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "تعداد:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(750, 28);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "نوع غذا:";
            // 
            // CBFoodType
            // 
            this.CBFoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CBFoodType.BackColor = System.Drawing.Color.LightGreen;
            this.CBFoodType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBFoodType.FormattingEnabled = true;
            this.CBFoodType.Location = new System.Drawing.Point(623, 28);
            this.CBFoodType.Name = "CBFoodType";
            this.CBFoodType.Size = new System.Drawing.Size(121, 23);
            this.CBFoodType.TabIndex = 2;
            // 
            // txtCount
            // 
            this.txtCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCount.BackColor = System.Drawing.Color.Turquoise;
            this.txtCount.Location = new System.Drawing.Point(623, 65);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(131, 23);
            this.txtCount.TabIndex = 3;
            // 
            // btnAfzoodan
            // 
            this.btnAfzoodan.BackColor = System.Drawing.Color.Lime;
            this.btnAfzoodan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfzoodan.Location = new System.Drawing.Point(4, 5);
            this.btnAfzoodan.Name = "btnAfzoodan";
            this.btnAfzoodan.Size = new System.Drawing.Size(181, 83);
            this.btnAfzoodan.TabIndex = 4;
            this.btnAfzoodan.Text = "افزودن";
            this.btnAfzoodan.UseVisualStyleBackColor = false;
            this.btnAfzoodan.Click += new System.EventHandler(this.btnAfzoodan_Click);
            // 
            // dgvFormOrderDetail
            // 
            this.dgvFormOrderDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFormOrderDetail.BackgroundColor = System.Drawing.Color.CadetBlue;
            this.dgvFormOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FoodTypeInOrderDetail,
            this.CountInOrderDetail});
            this.dgvFormOrderDetail.Location = new System.Drawing.Point(4, 94);
            this.dgvFormOrderDetail.Name = "dgvFormOrderDetail";
            this.dgvFormOrderDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvFormOrderDetail.RowTemplate.Height = 25;
            this.dgvFormOrderDetail.Size = new System.Drawing.Size(792, 255);
            this.dgvFormOrderDetail.TabIndex = 5;
            // 
            // Id
            // 
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FoodTypeInOrderDetail
            // 
            this.FoodTypeInOrderDetail.HeaderText = "نوع غذا";
            this.FoodTypeInOrderDetail.Name = "FoodTypeInOrderDetail";
            // 
            // CountInOrderDetail
            // 
            this.CountInOrderDetail.HeaderText = "تعداد";
            this.CountInOrderDetail.Name = "CountInOrderDetail";
            // 
            // BtnSabtNahaee
            // 
            this.BtnSabtNahaee.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSabtNahaee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BtnSabtNahaee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSabtNahaee.Location = new System.Drawing.Point(294, 371);
            this.BtnSabtNahaee.Name = "BtnSabtNahaee";
            this.BtnSabtNahaee.Size = new System.Drawing.Size(262, 67);
            this.BtnSabtNahaee.TabIndex = 6;
            this.BtnSabtNahaee.Text = "ثبت نهایی سفارش";
            this.BtnSabtNahaee.UseVisualStyleBackColor = false;
            this.BtnSabtNahaee.Click += new System.EventHandler(this.BtnSabtNahaee_Click);
            // 
            // FormOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSabtNahaee);
            this.Controls.Add(this.dgvFormOrderDetail);
            this.Controls.Add(this.btnAfzoodan);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.CBFoodType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormOrderDetail";
            this.Text = "FormOrderDetail";
            ((System.ComponentModel.ISupportInitialize)(this.txtCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBFoodType;
        private System.Windows.Forms.NumericUpDown txtCount;
        private System.Windows.Forms.Button btnAfzoodan;
        private System.Windows.Forms.DataGridView dgvFormOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodTypeInOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountInOrderDetail;
        private System.Windows.Forms.Button BtnSabtNahaee;
    }
}