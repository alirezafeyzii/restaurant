
namespace Restaurant1
{
    partial class FormOrder
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
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinallyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKharid = new System.Windows.Forms.Button();
            this.btnAfzoodanFoodType = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOrder
            // 
            this.dgvOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrder.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.OrderDescription,
            this.FinallyAmount});
            this.dgvOrder.Location = new System.Drawing.Point(-2, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvOrder.RowTemplate.Height = 25;
            this.dgvOrder.Size = new System.Drawing.Size(802, 324);
            this.dgvOrder.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "شماره سفارش";
            this.Id.Name = "Id";
            // 
            // OrderDescription
            // 
            this.OrderDescription.HeaderText = "شرح سفارش";
            this.OrderDescription.Name = "OrderDescription";
            // 
            // FinallyAmount
            // 
            this.FinallyAmount.HeaderText = "مبلغ کل سفارش";
            this.FinallyAmount.Name = "FinallyAmount";
            // 
            // btnKharid
            // 
            this.btnKharid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKharid.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnKharid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKharid.Location = new System.Drawing.Point(588, 345);
            this.btnKharid.Name = "btnKharid";
            this.btnKharid.Size = new System.Drawing.Size(212, 93);
            this.btnKharid.TabIndex = 1;
            this.btnKharid.Text = "خرید";
            this.btnKharid.UseVisualStyleBackColor = false;
            this.btnKharid.Click += new System.EventHandler(this.btnKharid_Click);
            // 
            // btnAfzoodanFoodType
            // 
            this.btnAfzoodanFoodType.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAfzoodanFoodType.BackColor = System.Drawing.Color.Lime;
            this.btnAfzoodanFoodType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfzoodanFoodType.Location = new System.Drawing.Point(286, 345);
            this.btnAfzoodanFoodType.Name = "btnAfzoodanFoodType";
            this.btnAfzoodanFoodType.Size = new System.Drawing.Size(222, 93);
            this.btnAfzoodanFoodType.TabIndex = 2;
            this.btnAfzoodanFoodType.Text = "افزودن نوع غذا";
            this.btnAfzoodanFoodType.UseVisualStyleBackColor = false;
            this.btnAfzoodanFoodType.Click += new System.EventHandler(this.btnAfzoodanFoodType_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Location = new System.Drawing.Point(-2, 345);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(219, 93);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAfzoodanFoodType);
            this.Controls.Add(this.btnKharid);
            this.Controls.Add(this.dgvOrder);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinallyAmount;
        private System.Windows.Forms.Button btnKharid;
        private System.Windows.Forms.Button btnAfzoodanFoodType;
        private System.Windows.Forms.Button btnExit;
    }
}