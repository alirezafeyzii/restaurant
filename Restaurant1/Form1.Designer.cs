
namespace Restaurant1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodAmount = new System.Windows.Forms.NumericUpDown();
            this.dgvFoodType = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodNameD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FoodAmountD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSabtInFoodType = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodType)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(43, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام غذا:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "قیمت غذا:";
            // 
            // txtFoodName
            // 
            this.txtFoodName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoodName.BackColor = System.Drawing.Color.SandyBrown;
            this.txtFoodName.Location = new System.Drawing.Point(638, 19);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(100, 23);
            this.txtFoodName.TabIndex = 2;
            // 
            // txtFoodAmount
            // 
            this.txtFoodAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFoodAmount.BackColor = System.Drawing.Color.Aquamarine;
            this.txtFoodAmount.Location = new System.Drawing.Point(169, 19);
            this.txtFoodAmount.Name = "txtFoodAmount";
            this.txtFoodAmount.Size = new System.Drawing.Size(120, 23);
            this.txtFoodAmount.TabIndex = 3;
            // 
            // dgvFoodType
            // 
            this.dgvFoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFoodType.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dgvFoodType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FoodNameD,
            this.FoodAmountD});
            this.dgvFoodType.Location = new System.Drawing.Point(1, 68);
            this.dgvFoodType.Name = "dgvFoodType";
            this.dgvFoodType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvFoodType.RowTemplate.Height = 25;
            this.dgvFoodType.Size = new System.Drawing.Size(797, 267);
            this.dgvFoodType.TabIndex = 4;
            // 
            // Id
            // 
            this.Id.HeaderText = "شناسه";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // FoodNameD
            // 
            this.FoodNameD.HeaderText = "نام غذا";
            this.FoodNameD.Name = "FoodNameD";
            // 
            // FoodAmountD
            // 
            this.FoodAmountD.HeaderText = "قیمت غذا";
            this.FoodAmountD.Name = "FoodAmountD";
            // 
            // btnSabtInFoodType
            // 
            this.btnSabtInFoodType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSabtInFoodType.BackColor = System.Drawing.Color.Lime;
            this.btnSabtInFoodType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSabtInFoodType.Location = new System.Drawing.Point(638, 341);
            this.btnSabtInFoodType.Name = "btnSabtInFoodType";
            this.btnSabtInFoodType.Size = new System.Drawing.Size(160, 107);
            this.btnSabtInFoodType.TabIndex = 5;
            this.btnSabtInFoodType.Text = "ثبت";
            this.btnSabtInFoodType.UseVisualStyleBackColor = false;
            this.btnSabtInFoodType.Click += new System.EventHandler(this.btnSabtInFoodType_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(1, 341);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(166, 107);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSabtInFoodType);
            this.Controls.Add(this.dgvFoodType);
            this.Controls.Add(this.txtFoodAmount);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "FormFoodType";
            ((System.ComponentModel.ISupportInitialize)(this.txtFoodAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.NumericUpDown txtFoodAmount;
        private System.Windows.Forms.DataGridView dgvFoodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodNameD;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodAmountD;
        private System.Windows.Forms.Button btnSabtInFoodType;
        private System.Windows.Forms.Button btnExit;
    }
}

