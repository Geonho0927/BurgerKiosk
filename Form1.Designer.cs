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
            rdoHamBurger = new RadioButton();
            rdoBulgogiBurger = new RadioButton();
            rdoChickenBurger = new RadioButton();
            picHamBurger = new PictureBox();
            picBulgogiBurger = new PictureBox();
            picChickenBurger = new PictureBox();
            chkPotato = new CheckBox();
            chkCola = new CheckBox();
            chkCheese = new CheckBox();
            chkSauce = new CheckBox();
            grpMenu = new GroupBox();
            grpOption = new GroupBox();
            grpOrder = new GroupBox();
            lblTotalCost = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnInit = new Button();
            ((System.ComponentModel.ISupportInitialize)picHamBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).BeginInit();
            grpMenu.SuspendLayout();
            grpOption.SuspendLayout();
            grpOrder.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 36.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.ForeColor = Color.Blue;
            lblAppName.Location = new Point(12, 20);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(454, 66);
            lblAppName.TabIndex = 90;
            lblAppName.Text = "버거 주문 키오스크";
            // 
            // rdoHamBurger
            // 
            rdoHamBurger.AutoSize = true;
            rdoHamBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            rdoHamBurger.ForeColor = Color.Black;
            rdoHamBurger.Location = new Point(23, 61);
            rdoHamBurger.Name = "rdoHamBurger";
            rdoHamBurger.Size = new Size(104, 36);
            rdoHamBurger.TabIndex = 0;
            rdoHamBurger.TabStop = true;
            rdoHamBurger.Text = "햄버거";
            rdoHamBurger.UseVisualStyleBackColor = true;
            // 
            // rdoBulgogiBurger
            // 
            rdoBulgogiBurger.AutoSize = true;
            rdoBulgogiBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            rdoBulgogiBurger.ForeColor = Color.Black;
            rdoBulgogiBurger.Location = new Point(23, 162);
            rdoBulgogiBurger.Name = "rdoBulgogiBurger";
            rdoBulgogiBurger.Size = new Size(152, 36);
            rdoBulgogiBurger.TabIndex = 1;
            rdoBulgogiBurger.Text = "불고기버거";
            rdoBulgogiBurger.UseVisualStyleBackColor = true;
            // 
            // rdoChickenBurger
            // 
            rdoChickenBurger.AutoSize = true;
            rdoChickenBurger.Font = new Font("맑은 고딕", 18F, FontStyle.Bold);
            rdoChickenBurger.ForeColor = Color.Black;
            rdoChickenBurger.Location = new Point(23, 270);
            rdoChickenBurger.Name = "rdoChickenBurger";
            rdoChickenBurger.Size = new Size(128, 36);
            rdoChickenBurger.TabIndex = 2;
            rdoChickenBurger.Text = "치킨버거";
            rdoChickenBurger.UseVisualStyleBackColor = true;
            // 
            // picHamBurger
            // 
            picHamBurger.Image = (Image)resources.GetObject("picHamBurger.Image");
            picHamBurger.Location = new Point(181, 29);
            picHamBurger.Name = "picHamBurger";
            picHamBurger.Size = new Size(100, 100);
            picHamBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picHamBurger.TabIndex = 4;
            picHamBurger.TabStop = false;
            // 
            // picBulgogiBurger
            // 
            picBulgogiBurger.Image = (Image)resources.GetObject("picBulgogiBurger.Image");
            picBulgogiBurger.Location = new Point(181, 135);
            picBulgogiBurger.Name = "picBulgogiBurger";
            picBulgogiBurger.Size = new Size(100, 100);
            picBulgogiBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picBulgogiBurger.TabIndex = 4;
            picBulgogiBurger.TabStop = false;
            // 
            // picChickenBurger
            // 
            picChickenBurger.Image = (Image)resources.GetObject("picChickenBurger.Image");
            picChickenBurger.Location = new Point(181, 241);
            picChickenBurger.Name = "picChickenBurger";
            picChickenBurger.Size = new Size(100, 100);
            picChickenBurger.SizeMode = PictureBoxSizeMode.Zoom;
            picChickenBurger.TabIndex = 4;
            picChickenBurger.TabStop = false;
            // 
            // chkPotato
            // 
            chkPotato.AutoSize = true;
            chkPotato.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkPotato.ForeColor = Color.Black;
            chkPotato.Location = new Point(23, 68);
            chkPotato.Name = "chkPotato";
            chkPotato.Size = new Size(107, 29);
            chkPotato.TabIndex = 0;
            chkPotato.Text = "감자튀김";
            chkPotato.UseVisualStyleBackColor = true;
            // 
            // chkCola
            // 
            chkCola.AutoSize = true;
            chkCola.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCola.ForeColor = Color.Black;
            chkCola.Location = new Point(23, 135);
            chkCola.Name = "chkCola";
            chkCola.Size = new Size(69, 29);
            chkCola.TabIndex = 1;
            chkCola.Text = "콜라";
            chkCola.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            chkCheese.AutoSize = true;
            chkCheese.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkCheese.ForeColor = Color.Black;
            chkCheese.Location = new Point(23, 206);
            chkCheese.Name = "chkCheese";
            chkCheese.Size = new Size(114, 29);
            chkCheese.TabIndex = 2;
            chkCheese.Text = "치즈 추가";
            chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkSauce
            // 
            chkSauce.AutoSize = true;
            chkSauce.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 129);
            chkSauce.ForeColor = Color.Black;
            chkSauce.Location = new Point(23, 277);
            chkSauce.Name = "chkSauce";
            chkSauce.Size = new Size(114, 29);
            chkSauce.TabIndex = 3;
            chkSauce.Text = "소스 추가";
            chkSauce.UseVisualStyleBackColor = true;
            // 
            // grpMenu
            // 
            grpMenu.Controls.Add(rdoBulgogiBurger);
            grpMenu.Controls.Add(picChickenBurger);
            grpMenu.Controls.Add(rdoHamBurger);
            grpMenu.Controls.Add(picBulgogiBurger);
            grpMenu.Controls.Add(picHamBurger);
            grpMenu.Controls.Add(rdoChickenBurger);
            grpMenu.Font = new Font("맑은 고딕", 25F);
            grpMenu.ForeColor = Color.Red;
            grpMenu.Location = new Point(29, 85);
            grpMenu.Name = "grpMenu";
            grpMenu.Size = new Size(305, 353);
            grpMenu.TabIndex = 1;
            grpMenu.TabStop = false;
            grpMenu.Text = "메뉴 선택";
            // 
            // grpOption
            // 
            grpOption.Controls.Add(chkPotato);
            grpOption.Controls.Add(chkSauce);
            grpOption.Controls.Add(chkCola);
            grpOption.Controls.Add(chkCheese);
            grpOption.Font = new Font("맑은 고딕", 25F);
            grpOption.ForeColor = Color.Red;
            grpOption.Location = new Point(351, 85);
            grpOption.Name = "grpOption";
            grpOption.Size = new Size(186, 353);
            grpOption.TabIndex = 2;
            grpOption.TabStop = false;
            grpOption.Text = "추가 옵션";
            // 
            // grpOrder
            // 
            grpOrder.Controls.Add(lblTotalCost);
            grpOrder.Controls.Add(lstOrder);
            grpOrder.Font = new Font("맑은 고딕", 25F);
            grpOrder.ForeColor = Color.Red;
            grpOrder.Location = new Point(555, 85);
            grpOrder.Name = "grpOrder";
            grpOrder.Size = new Size(233, 269);
            grpOrder.TabIndex = 3;
            grpOrder.TabStop = false;
            grpOrder.Text = "주문 내역";
            // 
            // lblTotalCost
            // 
            lblTotalCost.AutoSize = true;
            lblTotalCost.Font = new Font("맑은 고딕", 16F);
            lblTotalCost.ForeColor = Color.Blue;
            lblTotalCost.Location = new Point(18, 220);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(134, 30);
            lblTotalCost.TabIndex = 1;
            lblTotalCost.Text = "총 금액: 0원";
            // 
            // lstOrder
            // 
            lstOrder.Font = new Font("맑은 고딕", 12F);
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(18, 51);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(200, 151);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.FromArgb(128, 255, 128);
            btnOrder.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnOrder.Location = new Point(555, 370);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(123, 56);
            btnOrder.TabIndex = 4;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnInit
            // 
            btnInit.BackColor = Color.FromArgb(255, 128, 128);
            btnInit.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnInit.Location = new Point(684, 370);
            btnInit.Name = "btnInit";
            btnInit.Size = new Size(104, 56);
            btnInit.TabIndex = 5;
            btnInit.Text = "초기화";
            btnInit.UseVisualStyleBackColor = false;
            btnInit.Click += btnInit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInit);
            Controls.Add(btnOrder);
            Controls.Add(grpOrder);
            Controls.Add(grpOption);
            Controls.Add(lblAppName);
            Controls.Add(grpMenu);
            Name = "Form1";
            Text = "1";
            Shown += Form1_Shown;
            ((System.ComponentModel.ISupportInitialize)picHamBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBulgogiBurger).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChickenBurger).EndInit();
            grpMenu.ResumeLayout(false);
            grpMenu.PerformLayout();
            grpOption.ResumeLayout(false);
            grpOption.PerformLayout();
            grpOrder.ResumeLayout(false);
            grpOrder.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private RadioButton rdoHamBurger;
        private RadioButton rdoBulgogiBurger;
        private RadioButton rdoChickenBurger;
        private PictureBox picHamBurger;
        private PictureBox picBulgogiBurger;
        private PictureBox picChickenBurger;
        private CheckBox chkPotato;
        private CheckBox chkCola;
        private CheckBox chkCheese;
        private CheckBox chkSauce;
        private GroupBox grpMenu;
        private GroupBox grpOption;
        private GroupBox grpOrder;
        private Label lblTotalCost;
        private ListBox lstOrder;
        private Button btnOrder;
        private Button btnInit;
    }
}
