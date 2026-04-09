namespace BurgerKiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblAppName = new Label();
            grpBurger = new GroupBox();
            picChickenBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picBurger = new PictureBox();
            rdoChickenBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoBurger = new RadioButton();
            rdoNone = new RadioButton();
            grpOption = new GroupBox();
            chkSauce = new CheckBox();
            chkCheese = new CheckBox();
            chkCola = new CheckBox();
            chkPotato = new CheckBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            grpBurger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBurger).BeginInit();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
// 
// lblAppName
// 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 24F);
            lblAppName.ForeColor = SystemColors.HotTrack;
            lblAppName.Location = new Point(24, 26);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(371, 54);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // grpBurger
            // 
            grpBurger.Controls.Add(picChickenBurger); // Updated to include chicken burger
            grpBurger.Controls.Add(picBulgogiBurger);
            grpBurger.Controls.Add(picBurger);
            grpBurger.Controls.Add(rdoChickenBurger);
            grpBurger.Controls.Add(rdoBulgogiBurger);
            grpBurger.Controls.Add(rdoBurger);
            grpBurger.Font = new Font("맑은 고딕", 14F);
            grpBurger.ForeColor = Color.Red;
            grpBurger.Location = new Point(28, 119);
            grpBurger.Name = "grpBurger";
            grpBurger.Size = new Size(286, 294);
            grpBurger.TabIndex = 1;
            grpBurger.Text = "메뉴 선택";
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = (Image)resources.GetObject("picChickenBurger.Image");
            picChickenBurger.InitialImage = null;
            picChickenBurger.Location = new Point(163, 212);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(106, 76);
            picChickenBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picChickenBurger.TabIndex = 4;
            picChickenBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = (Image)resources.GetObject("picBulgogiBurger.Image");
            picBulgogiBurger.InitialImage = null;
            picBulgogiBurger.Location = new Point(163, 123);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(106, 76);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBulgogiBurger.TabIndex = 4;
            picBulgogiBurger.TabStop = false;
            // 
            // picBurger
            // 
            picBurger.Image = (Image)resources.GetObject("picBurger.Image");
            picBurger.InitialImage = null;
            picBurger.Location = new Point(163, 36);
            picBurger.Name = "picBurger";
            picBurger.Size = new Size(106, 76);
            picBurger.SizeMode = PictureBoxSizeMode.StretchImage;
            picBurger.TabIndex = 3;
            picBurger.TabStop = false;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 12F);
            rdoChickenBurger.ForeColor = Color.DarkSlateBlue;
            rdoChickenBurger.Location = new Point(21, 229);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(113, 32);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.TabStop = true;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 12F);
            rdoBulgogiBurger.ForeColor = Color.DarkSlateBlue;
            rdoBulgogiBurger.Location = new Point(21, 132);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(133, 32);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.TabStop = true;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBurger
            // 
            rdoBurger.AutoSize = true;
            rdoBurger.Font = new Font("맑은 고딕", 12F);
            rdoBurger.ForeColor = Color.DarkSlateBlue;
            rdoBurger.Location = new Point(21, 36);
            rdoBurger.Name = "rdoBurger";
            rdoBurger.Size = new Size(93, 32);
            rdoBurger.TabIndex = 0;
            rdoBurger.TabStop = true;
            rdoBurger.Text = "햄버거";
            rdoBurger.UseVisualStyleBackColor = true;
            // 
            // rdoNone
            // 
            rdoNone.AutoSize = true;
            rdoNone.Checked = true;
            rdoNone.Location = new Point(-19, -18);
            rdoNone.Name = "rdoNone";
            rdoNone.Size = new Size(17, 16);
            rdoNone.TabIndex = 99;
            rdoNone.TabStop = true;
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCheese);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkPotato);
            grpOption.Font = new Font("맑은 고딕", 14F);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(334, 119);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(192, 199);
            grpOption.TabIndex = 2;
            grpOption.Text = "추가 옵션";
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 12F);
            chkSauce.ForeColor = Color.DarkSlateBlue;
            chkSauce.Location = new Point(6, 113);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(121, 32);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 12F);
            chkCheese.ForeColor = Color.DarkSlateBlue;
            chkCheese.Location = new Point(6, 151);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(121, 32);
            chkCheese.TabIndex = 3;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 12F);
            chkCola.ForeColor = Color.DarkSlateBlue;
            chkCola.Location = new Point(6, 75);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(74, 32);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 12F);
            chkPotato.ForeColor = Color.DarkSlateBlue;
            chkPotato.Location = new Point(6, 37);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(114, 32);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 14F);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(544, 119);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(229, 261);
            grpOrder.TabIndex = 3;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 12F);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(11, 225);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(128, 28);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 12F);
            lstOrder.ForeColor = Color.Blue;
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(11, 46);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(209, 172);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Lime;
            btnOrder.Font = new Font("맑은 고딕", 12F);
            btnOrder.ForeColor = SystemColors.MenuText;
            btnOrder.Location = new Point(553, 386);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(106, 52);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.Font = new Font("맑은 고딕", 12F);
            btnReset.Location = new Point(665, 386);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(106, 52);
            btnReset.TabIndex = 5;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(rdoNone);
            Controls.Add(grpOption);
            Controls.Add(grpBurger);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            grpBurger.ResumeLayout(false);
            grpBurger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBurger).EndInit();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private GroupBox grpBurger;
        private RadioButton rdoNone;
        private RadioButton rdoChickenBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoBurger;
        private PictureBox picBurger;
        private PictureBox picChickenBurger;
        private PictureBox picBulgogiBurger;
        private GroupBox grpOption;
        private CheckBox chkCheese;
        private CheckBox chkCola;
        private CheckBox chkPotato;
        private CheckBox chkSauce;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnReset;
    }
}
