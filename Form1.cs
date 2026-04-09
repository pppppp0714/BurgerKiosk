using System.Diagnostics.Eventing.Reader;

namespace BurgerKiosk
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int totalCost = 0;
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            totalCost = 0;
            lblTotalCost.Text = $"총금액 : {totalCost:N0}원";

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (rdoBurger.Checked)
            {
                lstOrder.Items.Add("햄버거 5,000원");
                totalCost += 5000;
            }
            else if (rdoBulgogiBurger.Checked)
            {
                lstOrder.Items.Add("불고기버거 4,000원");
                totalCost += 4000;
            }
            else if (rdoChickenBurger.Checked)
            {
                lstOrder.Items.Add("치킨버거 3,000원");
                totalCost += 3000;
            }

            if (chkPotato.Checked)
            {
                lstOrder.Items.Add("감자튀김 3,500원");
                totalCost += 3500;
            }
            if (chkCola.Checked)
            {
                lstOrder.Items.Add("콜라 1,500원");
                totalCost += 1500;
            }
            if (chkCheese.Checked)
            {
                lstOrder.Items.Add("치즈 1,500원");
                totalCost += 1500;
            }
            if (chkSauce.Checked)
            {
                lstOrder.Items.Add("소스 500원");
                totalCost += 500;
            }

            lblTotalCost.Text = ($"총금액 : {totalCost:N0}원");
        }
    }
}
