using System.Diagnostics.Eventing.Reader;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BurgerKiosk
{

    public partial class Form1 : Form
    {
        // 키보드 네비게이션 상태
        private List<Control[]> groupItems = new List<Control[]>();
        private List<GroupBox> groupsList = new List<GroupBox>();
        private int currentGroupIndex = -1;
        private int[] currentChildIndices;

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
            // 폼 수준 키 처리 활성화
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            // 더미 라디오를 탭 대상으로 제외하고 체크 해제
            rdoNone.Checked = false;
            rdoNone.TabStop = false;
            rdoNone.Visible = false;

            // Shown 이벤트에서 시작 상태를 보정
            this.Shown += Form1_Shown;

            // 그룹 항목 준비 (순서 중요)
            groupItems.Add(new Control[] { rdoBurger, rdoBulgogiBurger, rdoChickenBurger });
            groupItems.Add(new Control[] { chkPotato, chkCola, chkCheese, chkSauce });
            groupItems.Add(new Control[] { lstOrder });
            // Tab 키로 포커스할 그룹 목록
            groupsList.Add(grpBurger);
            groupsList.Add(grpOption);
            groupsList.Add(grpOrder);
            currentChildIndices = new int[groupItems.Count];
            // GotFocus를 연결하여 포커스 변경(마우스, 런타임 등) 시 상태 동기화
            for (int gi = 0; gi < groupItems.Count; gi++)
            {
                var group = groupItems[gi];
                for (int ci = 0; ci < group.Length; ci++)
                {
                    var c = group[ci];
                    int g = gi; int ch = ci;
                    c.GotFocus += (s, ev) =>
                    {
                        currentGroupIndex = g;
                        currentChildIndices[g] = ch;
                    };
                }
            }
            // 그룹 박스가 포커스를 받을 때도 상태 동기화 (자식 자동 포커스 방지)
            grpBurger.GotFocus += (s, e) => { currentGroupIndex = 0; };
            grpOption.GotFocus += (s, e) => { currentGroupIndex = 1; };
            grpOrder.GotFocus += (s, e) => { currentGroupIndex = 2; };
        }
        int totalCost = 0;

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            rdoNone.Checked = false;
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
            rdoNone.Checked = false;
            // 내부 컨트롤이 프로그램으로 포커스될 수 있도록 TabStop 기본값 유지
            rdoBurger.TabStop = true;
            rdoBulgogiBurger.TabStop = true;
            rdoChickenBurger.TabStop = true;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            // 시작 시 햄버거 선택 해제 및 폼 타이틀에 포커스
            rdoBurger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            currentGroupIndex = -1;
            // 폼의 상단 레이블에 포커스를 두어 Tab으로 그룹으로 이동하게 함
            lblAppName.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Tab 키는 여기서 처리하여 폼의 기본 Tab 동작을 우회
            if ((keyData & Keys.KeyCode) == Keys.Tab)
            {
                bool shift = (keyData & Keys.Shift) == Keys.Shift;
                int next;
                if (currentGroupIndex < 0)
                {
                    // 시작 상태면 Shift+Tab은 마지막 그룹, Tab은 첫 그룹
                    next = shift ? groupItems.Count - 1 : 0;
                }
                else
                {
                    next = currentGroupIndex + (shift ? -1 : 1);
                    if (next < 0) next = groupItems.Count - 1;
                    if (next >= groupItems.Count) next = 0;
                }
                // 그룹으로 포커스 이동
                if (next == 0)
                {
                    // 항상 첫 햄버거 항목으로 포커스 및 선택을 강제
                    currentChildIndices[0] = 0;
                    currentGroupIndex = 0;
                    // ActiveControl 설정과 Select/Focus를 함께 호출하여 안정적으로 포커스 이동
                    this.ActiveControl = rdoBurger;
                    rdoBurger.Select();
                    rdoBurger.Focus();
                    bool anyBurgerChecked = rdoBurger.Checked || rdoBulgogiBurger.Checked || rdoChickenBurger.Checked;
                    if (!anyBurgerChecked)
                        rdoBurger.Checked = true;
                }
                else
                {
                    FocusChild(next, currentChildIndices[next]);
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            // 실제 포커스된 컨트롤과 상태 동기화
            UpdateStateFromFocusedControl();



            // 방향키로 현재 그룹의 항목을 이동
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                int dir = (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left) ? -1 : 1;
                MoveChildIndex(dir);
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            // Space 키는 현재 포커스된 컨트롤을 선택/토글
            if (e.KeyCode == Keys.Space)
            {
                var ctrl = GetCurrentChild();
                if (ctrl is RadioButton rb)
                {
                    rb.Checked = true;
                }
                else if (ctrl is CheckBox cb)
                {
                    cb.Checked = !cb.Checked;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            // Enter는 주문 실행, Escape는 초기화 실행
            if (e.KeyCode == Keys.Enter)
            {
                btnOrder.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnReset.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void FocusChild(int groupIndex, int childIndex)
        {
            currentGroupIndex = groupIndex;
            currentChildIndices[groupIndex] = Math.Max(0, Math.Min(childIndex, groupItems[groupIndex].Length - 1));
            var ctrl = groupItems[groupIndex][currentChildIndices[groupIndex]];
            ctrl.Focus();
            // 햄버거 그룹에 들어갈 때 아직 선택된 햄버거가 없으면 포커스된 항목을 선택
            if (groupIndex == 0)
            {
                bool anyBurgerChecked = rdoBurger.Checked || rdoBulgogiBurger.Checked || rdoChickenBurger.Checked;
                if (!anyBurgerChecked && ctrl is RadioButton rb)
                {
                    rb.Checked = true;
                }
            }
        }

        private void UpdateStateFromFocusedControl()
        {
            Control focused = this.ActiveControl;
            if (focused == null)
                return;

            // 포커스된 컨트롤이 추적 중인 자식이면 인덱스 업데이트
            for (int gi = 0; gi < groupItems.Count; gi++)
            {
                var group = groupItems[gi];
                for (int ci = 0; ci < group.Length; ci++)
                {
                    if (group[ci] == focused)
                    {
                        currentGroupIndex = gi;
                        currentChildIndices[gi] = ci;
                        return;
                    }
                }
            }

            // 그룹 박스 자체가 포커스되면 그룹 인덱스 설정
            for (int gi = 0; gi < groupsList.Count; gi++)
            {
                if (groupsList[gi] == focused)
                {
                    currentGroupIndex = gi;
                    return;
                }
            }
        }

        private void MoveChildIndex(int direction)
        {
            int len = groupItems[currentGroupIndex].Length;
            int idx = currentChildIndices[currentGroupIndex];
            idx += direction;
            if (idx < 0) idx = 0;
            if (idx >= len) idx = len - 1;
            currentChildIndices[currentGroupIndex] = idx;
            var ctrl = groupItems[currentGroupIndex][idx];
            ctrl.Focus();
        }

        private void FocusGroup(int groupIndex)
        {
            currentGroupIndex = groupIndex;
            // focus the group box itself so Tab moves between groups
            groupsList[groupIndex].Focus();
        }

        private Control GetCurrentChild()
        {
            return groupItems[currentGroupIndex][currentChildIndices[currentGroupIndex]];
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
