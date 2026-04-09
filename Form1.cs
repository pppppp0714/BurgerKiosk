using System.Diagnostics.Eventing.Reader;

namespace BurgerKiosk
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 시작 시 초기화
            rdoBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            totalCost = 0;
            lblTotalCost.Text = $"총 금액 : {totalCost:N0}원";
            lblTotalCost.ForeColor = Color.Blue;
            // 추가로 Load 이벤트에서 라디오 버튼 자동 선택을 방지
            this.Load += Form1_Load;
            // dummy radio 선택
            rdoNone.Checked = true;
        }
        int totalCost = 0;

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            rdoNone.Checked = true;
            chkPotato.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lstOrder.Items.Clear();
            totalCost = 0;
            lblTotalCost.Text = $"총 금액 : {totalCost:N0}원";
            lblTotalCost.ForeColor = Color.Blue;

        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // 런타임에서 라디오 버튼이 자동으로 체크되는 것을 방지
            rdoBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            rdoNone.Checked = true;
            rdoBurger.TabStop = false;
            rdoBulgogiBurger.TabStop = false;
            rdoChickenBurger.TabStop = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!rdoBurger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblTotalCost.ForeColor = Color.Red;
                lblTotalCost.Text = "햄버거를 선택해주세요.";
                return;
            }
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
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Text = ($"총 금액 : {totalCost:N0}원");
        }
    }
}
