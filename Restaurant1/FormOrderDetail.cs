using Restaurant1.Models;
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
    public partial class FormOrderDetail : Form
    {
        private readonly FoodTypeRepository foodTypeRepository = new FoodTypeRepository();
        private readonly OrderRepository orderRepository = new OrderRepository();
        private List<OrderDetail> orderDetail1 = new List<OrderDetail>();
        public FormOrderDetail()
        {
            InitializeComponent();
            var orderDetails = foodTypeRepository.Gets();
            orderDetails.ForEach(p => CBFoodType.Items.Add(p));
            CBFoodType.DisplayMember = "Name";
            CBFoodType.ValueMember = "Amount";
            CBFoodType.SelectedIndex = 0;
        }

        private void btnAfzoodan_Click(object sender, EventArgs e)
        {
            if (txtCount.Value == 0)
            {
                MessageBox.Show("وارد کردن تعداد غذا الزامی است");
                return;
            }
            var orderDetail = new OrderDetail();
            var foodType = (FoodType)CBFoodType.SelectedItem;
            orderDetail.Count = txtCount.Value;
            orderDetail.FoodType = foodType;
            dgvFormOrderDetail.Rows.Add(foodType.Id, foodType.Name, orderDetail.Count);
            orderDetail1.Add(orderDetail);
        }

        private void BtnSabtNahaee_Click(object sender, EventArgs e)
        {
            var order = new Order(orderDetail1);
            orderRepository.Add(order);
            this.Close();
        }
    }
}
