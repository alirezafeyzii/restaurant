using Restaurant1.Models;
using Restaurant1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant1
{
    public partial class Form1 : Form
    {
        private readonly FoodTypeRepository foodTypeRepository = new FoodTypeRepository();
        public Form1()
        {
            InitializeComponent();
            var foodTypes = foodTypeRepository.Gets();
            foodTypes.ForEach(foodType => dgvFoodType.Rows.Add(foodType.Id, foodType.Name, foodType.Amount));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSabtInFoodType_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text == "")
            {
                MessageBox.Show("وارد کردن نام غذا الزامی است");
                return;
            }
            if (txtFoodAmount.Value == 0)
            {
                MessageBox.Show("وارد کردن قیمت غذا الزامی است");
                return;
            }
            var foodType = new FoodType(txtFoodName.Text, txtFoodAmount.Value);
            foodTypeRepository.Add(foodType);
            dgvFoodType.Rows.Add(foodType.Id, foodType.Name, foodType.Amount);
        }
    }
}
