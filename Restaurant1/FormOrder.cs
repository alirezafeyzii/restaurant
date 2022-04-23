using Restaurant1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Restaurant1
{
    public partial class FormOrder : Form
    {
        private readonly OrderRepository orderRepository = new OrderRepository();
        public FormOrder()
        {
            InitializeComponent();
            var orderDetails = orderRepository.Gets();
            orderDetails.ForEach(orderd => dgvOrder.Rows.Add(orderd.Id, orderd.OrderDescription, orderd.FinallyAmount));
        }

        private void btnAfzoodanFoodType_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void btnKharid_Click(object sender, EventArgs e)
        {
            FormOrderDetail formOrderDetail = new FormOrderDetail();
            formOrderDetail.ShowDialog();
            var orderDetails = orderRepository.Gets();
            dgvOrder.Rows.Clear();
            orderDetails.ForEach(orderd => dgvOrder.Rows.Add(orderd.Id, orderd.OrderDescription, orderd.FinallyAmount));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
