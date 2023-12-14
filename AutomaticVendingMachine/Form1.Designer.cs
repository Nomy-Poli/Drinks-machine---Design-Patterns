namespace AutomaticVendingMachine
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
            pictureBox1 = new PictureBox();
            tropitBtn = new Button();
            OrangeJuiceBtn = new Button();
            fuzeTeeBtn = new Button();
            chipsBtn = new Button();
            bislliBtn = new Button();
            bambaBtn = new Button();
            apropoBtn = new Button();
            CocaColaBtn = new Button();
            pictureBox2 = new PictureBox();
            DalCaloriesIcecofeeBtn = new Button();
            PaymentBtn = new Button();
            BagCB = new CheckBox();
            GiftCB = new CheckBox();
            IceCoffe = new Button();
            WithoutDEC = new CheckBox();
            BlackChocolateCB = new CheckBox();
            WhiteChocolateCB = new CheckBox();
            RibatChalavCB = new CheckBox();
            IsMOkaCB = new CheckBox();
            CreamCB = new CheckBox();
            priceLabel = new Label();
            label1 = new Label();
            finishLabel = new Label();
            HotCofeeBtn = new Button();
            addMilkCB = new CheckBox();
            addCoffeeCB = new CheckBox();
            addWaterCB = new CheckBox();
            addSugarCB = new CheckBox();
            addShokoCB = new CheckBox();
            addWhippedMilkCB = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._30751;
            pictureBox1.Location = new Point(-37, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(609, 877);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // tropitBtn
            // 
            tropitBtn.BackColor = Color.Brown;
            tropitBtn.ForeColor = SystemColors.ButtonFace;
            tropitBtn.Location = new Point(294, 132);
            tropitBtn.Name = "tropitBtn";
            tropitBtn.Size = new Size(59, 55);
            tropitBtn.TabIndex = 16;
            tropitBtn.Tag = "tropit";
            tropitBtn.Text = "טרופית";
            tropitBtn.UseVisualStyleBackColor = false;
            tropitBtn.Click += tropitBtn_Click_1;
            // 
            // OrangeJuiceBtn
            // 
            OrangeJuiceBtn.BackColor = SystemColors.ActiveCaption;
            OrangeJuiceBtn.ForeColor = Color.FromArgb(64, 0, 0);
            OrangeJuiceBtn.Location = new Point(100, 132);
            OrangeJuiceBtn.Name = "OrangeJuiceBtn";
            OrangeJuiceBtn.Size = new Size(53, 55);
            OrangeJuiceBtn.TabIndex = 15;
            OrangeJuiceBtn.Tag = "orange Juice";
            OrangeJuiceBtn.Text = "מיץ תפוזים";
            OrangeJuiceBtn.UseVisualStyleBackColor = false;
            OrangeJuiceBtn.Click += OrangeJuiceBtn_Click;
            // 
            // fuzeTeeBtn
            // 
            fuzeTeeBtn.BackColor = Color.Thistle;
            fuzeTeeBtn.Location = new Point(165, 142);
            fuzeTeeBtn.Name = "fuzeTeeBtn";
            fuzeTeeBtn.Size = new Size(55, 38);
            fuzeTeeBtn.TabIndex = 14;
            fuzeTeeBtn.Tag = "fuze-tee";
            fuzeTeeBtn.Text = "פיוז טי";
            fuzeTeeBtn.UseVisualStyleBackColor = false;
            fuzeTeeBtn.Click += fuzeTeeBtn_Click;
            // 
            // chipsBtn
            // 
            chipsBtn.BackColor = SystemColors.HotTrack;
            chipsBtn.ForeColor = SystemColors.ButtonHighlight;
            chipsBtn.Location = new Point(100, 303);
            chipsBtn.Name = "chipsBtn";
            chipsBtn.Size = new Size(47, 55);
            chipsBtn.TabIndex = 20;
            chipsBtn.Tag = "chips";
            chipsBtn.Text = "צ'יפס";
            chipsBtn.UseVisualStyleBackColor = false;
            chipsBtn.Click += chipsBtn_Click;
            // 
            // bislliBtn
            // 
            bislliBtn.BackColor = Color.OrangeRed;
            bislliBtn.ForeColor = SystemColors.ButtonHighlight;
            bislliBtn.Location = new Point(170, 304);
            bislliBtn.Name = "bislliBtn";
            bislliBtn.Size = new Size(48, 55);
            bislliBtn.TabIndex = 19;
            bislliBtn.Tag = "bislli";
            bislliBtn.Text = "ביסלי";
            bislliBtn.UseVisualStyleBackColor = false;
            bislliBtn.Click += bislliBtn_Click;
            // 
            // bambaBtn
            // 
            bambaBtn.BackColor = Color.LightSalmon;
            bambaBtn.Location = new Point(235, 317);
            bambaBtn.Name = "bambaBtn";
            bambaBtn.Size = new Size(48, 42);
            bambaBtn.TabIndex = 18;
            bambaBtn.Tag = "bamba";
            bambaBtn.Text = "במבה";
            bambaBtn.UseVisualStyleBackColor = false;
            bambaBtn.Click += bambaBtn_Click_1;
            // 
            // apropoBtn
            // 
            apropoBtn.BackColor = Color.FromArgb(192, 192, 0);
            apropoBtn.Location = new Point(299, 324);
            apropoBtn.Name = "apropoBtn";
            apropoBtn.Size = new Size(56, 29);
            apropoBtn.TabIndex = 17;
            apropoBtn.Tag = "apropo";
            apropoBtn.Text = "אפרופו";
            apropoBtn.UseVisualStyleBackColor = false;
            apropoBtn.Click += apropoBtn_Click;
            // 
            // CocaColaBtn
            // 
            CocaColaBtn.BackColor = Color.Black;
            CocaColaBtn.ForeColor = SystemColors.ButtonHighlight;
            CocaColaBtn.Location = new Point(238, 136);
            CocaColaBtn.Name = "CocaColaBtn";
            CocaColaBtn.Size = new Size(44, 47);
            CocaColaBtn.TabIndex = 21;
            CocaColaBtn.Tag = "coca cola";
            CocaColaBtn.Text = "קולה";
            CocaColaBtn.UseVisualStyleBackColor = false;
            CocaColaBtn.Click += CocaColaBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._16992;
            pictureBox2.Location = new Point(573, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(885, 877);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // DalCaloriesIcecofeeBtn
            // 
            DalCaloriesIcecofeeBtn.Location = new Point(888, 192);
            DalCaloriesIcecofeeBtn.Name = "DalCaloriesIcecofeeBtn";
            DalCaloriesIcecofeeBtn.Size = new Size(209, 43);
            DalCaloriesIcecofeeBtn.TabIndex = 27;
            DalCaloriesIcecofeeBtn.Tag = "dal Calories Ice-Cofee";
            DalCaloriesIcecofeeBtn.Text = "אייס קפה דל קלוריות";
            DalCaloriesIcecofeeBtn.UseVisualStyleBackColor = true;
            DalCaloriesIcecofeeBtn.Click += DalCaloriesIcecofeeBtn_Click;
            // 
            // PaymentBtn
            // 
            PaymentBtn.BackColor = Color.SteelBlue;
            PaymentBtn.Font = new Font("Swis721 BlkEx BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            PaymentBtn.Location = new Point(547, 673);
            PaymentBtn.Name = "PaymentBtn";
            PaymentBtn.Size = new Size(183, 78);
            PaymentBtn.TabIndex = 34;
            PaymentBtn.Text = "לתשלום";
            PaymentBtn.UseVisualStyleBackColor = false;
            PaymentBtn.Click += PaymentBtn_Click_1;
            // 
            // BagCB
            // 
            BagCB.AutoSize = true;
            BagCB.Enabled = false;
            BagCB.Location = new Point(660, 757);
            BagCB.Name = "BagCB";
            BagCB.Size = new Size(60, 19);
            BagCB.TabIndex = 36;
            BagCB.Text = "?שקית";
            BagCB.UseVisualStyleBackColor = true;
            // 
            // GiftCB
            // 
            GiftCB.AutoSize = true;
            GiftCB.Enabled = false;
            GiftCB.Location = new Point(553, 757);
            GiftCB.Name = "GiftCB";
            GiftCB.Size = new Size(101, 19);
            GiftCB.TabIndex = 35;
            GiftCB.Text = "?אריזה למתנה";
            GiftCB.UseVisualStyleBackColor = true;
            // 
            // IceCoffe
            // 
            IceCoffe.Location = new Point(889, 245);
            IceCoffe.Name = "IceCoffe";
            IceCoffe.Size = new Size(209, 43);
            IceCoffe.TabIndex = 37;
            IceCoffe.Tag = "ice Cofee";
            IceCoffe.Text = "אייס קפה";
            IceCoffe.UseVisualStyleBackColor = true;
            IceCoffe.Click += IceCoffe_Click;
            // 
            // WithoutDEC
            // 
            WithoutDEC.AutoSize = true;
            WithoutDEC.Enabled = false;
            WithoutDEC.Location = new Point(896, 358);
            WithoutDEC.Name = "WithoutDEC";
            WithoutDEC.Size = new Size(91, 19);
            WithoutDEC.TabIndex = 44;
            WithoutDEC.Text = "ללא תוספות";
            WithoutDEC.UseVisualStyleBackColor = true;
            WithoutDEC.CheckedChanged += WithoutDEC_CheckedChanged;
            // 
            // BlackChocolateCB
            // 
            BlackChocolateCB.AutoSize = true;
            BlackChocolateCB.Enabled = false;
            BlackChocolateCB.Location = new Point(896, 326);
            BlackChocolateCB.Name = "BlackChocolateCB";
            BlackChocolateCB.Size = new Size(89, 19);
            BlackChocolateCB.TabIndex = 43;
            BlackChocolateCB.Text = "?שוקולד חום";
            BlackChocolateCB.UseVisualStyleBackColor = true;
            BlackChocolateCB.CheckedChanged += BlackChocolateCB_CheckedChanged;
            // 
            // WhiteChocolateCB
            // 
            WhiteChocolateCB.AutoSize = true;
            WhiteChocolateCB.Enabled = false;
            WhiteChocolateCB.Location = new Point(896, 294);
            WhiteChocolateCB.Name = "WhiteChocolateCB";
            WhiteChocolateCB.Size = new Size(87, 19);
            WhiteChocolateCB.TabIndex = 42;
            WhiteChocolateCB.Text = "?שוקולד לבן";
            WhiteChocolateCB.UseVisualStyleBackColor = true;
            WhiteChocolateCB.CheckedChanged += WhiteChocolateCB_CheckedChanged;
            // 
            // RibatChalavCB
            // 
            RibatChalavCB.AutoSize = true;
            RibatChalavCB.Enabled = false;
            RibatChalavCB.Location = new Point(1012, 358);
            RibatChalavCB.Name = "RibatChalavCB";
            RibatChalavCB.Size = new Size(82, 19);
            RibatChalavCB.TabIndex = 41;
            RibatChalavCB.Text = "?ריבת חלב";
            RibatChalavCB.UseVisualStyleBackColor = true;
            RibatChalavCB.CheckedChanged += RibatChalavCB_CheckedChanged;
            // 
            // IsMOkaCB
            // 
            IsMOkaCB.AutoSize = true;
            IsMOkaCB.Enabled = false;
            IsMOkaCB.Location = new Point(1011, 326);
            IsMOkaCB.Name = "IsMOkaCB";
            IsMOkaCB.Size = new Size(84, 19);
            IsMOkaCB.TabIndex = 40;
            IsMOkaCB.Text = "?טעם מוקה";
            IsMOkaCB.UseVisualStyleBackColor = true;
            IsMOkaCB.CheckedChanged += IsMOkaCB_CheckedChanged;
            // 
            // CreamCB
            // 
            CreamCB.AutoSize = true;
            CreamCB.Enabled = false;
            CreamCB.Location = new Point(1022, 294);
            CreamCB.Name = "CreamCB";
            CreamCB.Size = new Size(63, 19);
            CreamCB.TabIndex = 39;
            CreamCB.Text = "?קצפת";
            CreamCB.UseVisualStyleBackColor = true;
            CreamCB.CheckedChanged += CreamCB_CheckedChanged;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(584, 589);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(0, 20);
            priceLabel.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Brown;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(573, 557);
            label1.Name = "label1";
            label1.Size = new Size(128, 27);
            label1.TabIndex = 46;
            label1.Text = ":מחיר לתשלום";
            // 
            // finishLabel
            // 
            finishLabel.AutoSize = true;
            finishLabel.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            finishLabel.Location = new Point(348, 55);
            finishLabel.Name = "finishLabel";
            finishLabel.Size = new Size(0, 44);
            finishLabel.TabIndex = 47;
            // 
            // HotCofeeBtn
            // 
            HotCofeeBtn.Location = new Point(896, 562);
            HotCofeeBtn.Name = "HotCofeeBtn";
            HotCofeeBtn.Size = new Size(209, 43);
            HotCofeeBtn.TabIndex = 48;
            HotCofeeBtn.Tag = "hot drink";
            HotCofeeBtn.Text = "קפה חם";
            HotCofeeBtn.UseVisualStyleBackColor = true;
            HotCofeeBtn.Click += HotCofeeBtn_Click;
            // 
            // addMilkCB
            // 
            addMilkCB.AutoSize = true;
            addMilkCB.Enabled = false;
            addMilkCB.Location = new Point(895, 613);
            addMilkCB.Name = "addMilkCB";
            addMilkCB.Size = new Size(48, 19);
            addMilkCB.TabIndex = 49;
            addMilkCB.Text = "חלב";
            addMilkCB.UseVisualStyleBackColor = true;
            // 
            // addCoffeeCB
            // 
            addCoffeeCB.AutoSize = true;
            addCoffeeCB.Enabled = false;
            addCoffeeCB.Location = new Point(895, 638);
            addCoffeeCB.Name = "addCoffeeCB";
            addCoffeeCB.Size = new Size(50, 19);
            addCoffeeCB.TabIndex = 50;
            addCoffeeCB.Text = "קפה";
            addCoffeeCB.UseVisualStyleBackColor = true;
            // 
            // addWaterCB
            // 
            addWaterCB.AutoSize = true;
            addWaterCB.Enabled = false;
            addWaterCB.Location = new Point(1030, 613);
            addWaterCB.Name = "addWaterCB";
            addWaterCB.Size = new Size(75, 19);
            addWaterCB.TabIndex = 51;
            addWaterCB.Text = "מים חמים";
            addWaterCB.UseVisualStyleBackColor = true;
            // 
            // addSugarCB
            // 
            addSugarCB.AutoSize = true;
            addSugarCB.Enabled = false;
            addSugarCB.Location = new Point(1054, 638);
            addSugarCB.Name = "addSugarCB";
            addSugarCB.Size = new Size(51, 19);
            addSugarCB.TabIndex = 52;
            addSugarCB.Text = "סוכר";
            addSugarCB.UseVisualStyleBackColor = true;
            // 
            // addShokoCB
            // 
            addShokoCB.AutoSize = true;
            addShokoCB.Enabled = false;
            addShokoCB.Location = new Point(1021, 663);
            addShokoCB.Name = "addShokoCB";
            addShokoCB.Size = new Size(84, 19);
            addShokoCB.TabIndex = 53;
            addShokoCB.Text = "אבקת שוקו";
            addShokoCB.UseVisualStyleBackColor = true;
            // 
            // addWhippedMilkCB
            // 
            addWhippedMilkCB.AutoSize = true;
            addWhippedMilkCB.Enabled = false;
            addWhippedMilkCB.Location = new Point(896, 663);
            addWhippedMilkCB.Name = "addWhippedMilkCB";
            addWhippedMilkCB.Size = new Size(84, 19);
            addWhippedMilkCB.TabIndex = 54;
            addWhippedMilkCB.Text = "חלב מוקצף";
            addWhippedMilkCB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 907);
            Controls.Add(addWhippedMilkCB);
            Controls.Add(addShokoCB);
            Controls.Add(addSugarCB);
            Controls.Add(addWaterCB);
            Controls.Add(addCoffeeCB);
            Controls.Add(addMilkCB);
            Controls.Add(HotCofeeBtn);
            Controls.Add(finishLabel);
            Controls.Add(label1);
            Controls.Add(priceLabel);
            Controls.Add(WithoutDEC);
            Controls.Add(BlackChocolateCB);
            Controls.Add(WhiteChocolateCB);
            Controls.Add(RibatChalavCB);
            Controls.Add(IsMOkaCB);
            Controls.Add(CreamCB);
            Controls.Add(IceCoffe);
            Controls.Add(BagCB);
            Controls.Add(GiftCB);
            Controls.Add(PaymentBtn);
            Controls.Add(DalCaloriesIcecofeeBtn);
            Controls.Add(pictureBox2);
            Controls.Add(CocaColaBtn);
            Controls.Add(chipsBtn);
            Controls.Add(bislliBtn);
            Controls.Add(bambaBtn);
            Controls.Add(apropoBtn);
            Controls.Add(tropitBtn);
            Controls.Add(OrangeJuiceBtn);
            Controls.Add(fuzeTeeBtn);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private PictureBox pictureBox1;
        private Button tropitBtn;
        private Button OrangeJuiceBtn;
        private Button fuzeTeeBtn;
        private Button chipsBtn;
        private Button bislliBtn;
        private Button bambaBtn;
        private Button apropoBtn;
        private Button CocaColaBtn;
        private PictureBox pictureBox2;
        private Button DalCaloriesIcecofeeBtn;
        private Button PaymentBtn;
        private CheckBox BagCB;
        private CheckBox GiftCB;
        private Button IceCoffe;
        private CheckBox WithoutDEC;
        private CheckBox BlackChocolateCB;
        private CheckBox WhiteChocolateCB;
        private CheckBox RibatChalavCB;
        private CheckBox IsMOkaCB;
        private CheckBox CreamCB;
        private Label label1;
        private Label finishLabel;
        public Label priceLabel;
        private Button HotCofeeBtn;
        private CheckBox addMilkCB;
        private CheckBox addCoffeeCB;
        private CheckBox addWaterCB;
        private CheckBox addSugarCB;
        private CheckBox addShokoCB;
        private CheckBox addWhippedMilkCB;
    }
}