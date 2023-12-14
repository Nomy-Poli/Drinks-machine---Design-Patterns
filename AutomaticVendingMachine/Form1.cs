
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using AutomaticVendingMachine;
using AutomaticVendingmechin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AutomaticVendingMachine
{
    public partial class Form1 : Form
    {
        #region the machine members
        private HotDrinkBuilder builder;
        List<CheckBox> SelectedDecorators = new List<CheckBox>();
        CheckBox[] decoratorCheckboxes;
        CheckBox[] builderCheckboxes;
        Machine machine = new Machine();

        #endregion

        #region when the show ran
        public Form1()
        {
            InitializeComponent();

            //This is a function that is applied to all the buttons of the machine
            foreach (Button button in Controls.OfType<Button>())
            {
                if (button != PaymentBtn)
                {
                    button.Click += Button_Click;
                }
            }

            builder = new HotDrinkBuilder();
            decoratorCheckboxes = new CheckBox[] { WhiteChocolateCB, BlackChocolateCB, IsMOkaCB, CreamCB, RibatChalavCB };
            builderCheckboxes = new CheckBox[] { addCoffeeCB, addMilkCB, addShokoCB, addSugarCB, addMilkCB, addWhippedMilkCB, addWaterCB };

            //the machines products-buttons
            machine.AddProduct("coca cola", 6, 12, "product");
            machine.AddProduct("tropit", 2, 5, "product");
            machine.AddProduct("orange Juice", 9, 10, "product");
            machine.AddProduct("chips", 9, 6, "product");
            machine.AddProduct("bislli", 8, 6.5, "product");
            machine.AddProduct("bamba", 9, 6.90, "product");
            machine.AddProduct("apropo", 15, 8, "product");
            machine.AddProduct("fuze-tee", 30, 8, "product");
            //the machines products(drinks)-buttons
            machine.AddProduct("ice Cofee", 9, 6.90, "drink");
            machine.AddProduct("dal Calories Ice-Cofee", 15, 8, "drink");
            machine.AddProduct("hot drink", 15, 8, "drink");
        }

        private string lastPressedButtonName;
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            string buttonName = clickedButton.Tag?.ToString();
            lastPressedButtonName = buttonName;
            PaymentBtn.Enabled = true;
            if (lastPressedButtonName != null && machine.Products.ContainsKey(lastPressedButtonName))
            {
                priceLabel.Text = clickedButton.Text + " : " + machine.Products[lastPressedButtonName]?.Price.ToString();
            }
            else
            {
                priceLabel.Text = string.Empty;
            }
        }
        #endregion

        #region payment button
        ColdDrink coldDrink;
        private int clickCount = 0;
        public void PaymentBtn_Click_1(object sender, EventArgs e)
        {
            #region at the second click
            clickCount++;

            if (clickCount == 2)
            {
                priceLabel.Text = string.Empty;
                MessageBox.Show("!תודה שהשתמשת במכונת המכירות שלנו");
                foreach (Button button in Controls.OfType<Button>())
                {
                    button.Enabled = true;
                }
                foreach (Control control in Controls)
                {
                    if (control is CheckBox checkbox)
                    {
                        checkbox.Checked = false;
                        checkbox.Enabled = false;
                    }
                }
                PaymentBtn.Enabled = false;
                clickCount = 0;
                lastPressedButtonName = "";
            }
            #endregion

            #region at the firat click
            else
            {
                MessageBox.Show("הזמנתך נקלטה.לאישור והשלמת התשלום אני בחר האם אתה מעוניין בשקית או מתנה.ולאחר מכן לחץ על תשלום");
                #region When ordering a cold drink
                if (lastPressedButtonName == "ice-Cofee" || lastPressedButtonName == "dal Calories Ice-Cofee")
                {
                    SelectedDecorators.Clear();
                    foreach (CheckBox checkBox in decoratorCheckboxes)
                    {
                        if (checkBox.Checked)
                        {
                            SelectedDecorators.Add(checkBox);
                        }
                    }
                    if (lastPressedButtonName == "ice-Cofee")
                    {
                        coldDrink = new IceCofee();
                    }
                    else if (lastPressedButtonName == "dal Calories Ice-Cofee")
                    {
                        coldDrink = new DalKaloriesIceCofee();
                    }
                    //int c = coldDrink.GetCost();
                    foreach (CheckBox checkBox in SelectedDecorators)
                    {
                        switch (checkBox.Name)
                        {
                            case "WhiteChocolateCB":
                                coldDrink = new WhiteChocolate(coldDrink);

                                break;
                            case "BlackChocolateCB":
                                coldDrink = new BlackChocolate(coldDrink);
                                break;
                            case "CreamCB":
                                coldDrink = new Cream(coldDrink);

                                break;
                            case "RibatChalavCB":
                                coldDrink = new RibatChalav(coldDrink);

                                break;
                            case "IsMOkaCB":
                                coldDrink = new IsMOka(coldDrink);

                                break;
                        }
                      
                    }
                    MessageBox.Show(coldDrink.GetCost().ToString(), ":כעת המשקה שלך עולה");
                    priceLabel.Text = coldDrink.GetCost().ToString();
                }
                #endregion

                #region when ordering a hot drink
                else if (lastPressedButtonName == "hot drink")
                {
                    HotDrink hotDrink = new HotDrink();
                    foreach (CheckBox item in builderCheckboxes)
                    {
                        if (item.Checked)
                        {
                            switch (item.Name)
                            {
                                case "addCoffeeCB":
                                    builder.AddCoffee();
                                    break;
                                case "addShokoCB":
                                    builder.AddShoko();
                                    break;
                                case "addWaterCB":
                                    builder.AddWater();
                                    break;
                                case "addSugarCB":
                                    builder.AddSugar();
                                    break;
                                case "addMilkCB":
                                    builder.AddMilk();
                                    break;
                                case "addWhippedMilkCB":
                                    builder.AddWhippedmilk();
                                    break;
                            }
                        }
                    }
                    hotDrink = builder.GetDrink();
                    string listString = string.Join(Environment.NewLine, hotDrink.ingredients);
                    MessageBox.Show(listString, ":המשקה שלך מכיל");
                }
                #endregion

                #region completion of the order reception process
                object message = machine.Execute(lastPressedButtonName);
                if (message == "Succeeded")
                {
                    foreach (Button button in Controls.OfType<Button>())
                    {
                        button.Enabled = false;
                    }
                    foreach (Control control in Controls)
                    {
                        if (control is CheckBox checkbox)
                        {
                            checkbox.Checked = false;
                            checkbox.Enabled = false;
                        }
                    }
                    GiftCB.Enabled = true;
                    BagCB.Enabled = true;
                    PaymentBtn.Enabled = true;
                }
                else
                {
                    MessageBox.Show("המוצר אינו זמין!נסה להזמין מוצר אחר");
                    foreach (Button button in Controls.OfType<Button>())
                    {
                        button.Enabled = true;
                    }
                    foreach (Control control in Controls)
                    {
                        if (control is CheckBox checkbox)
                        {
                            checkbox.Checked = false;
                            checkbox.Enabled = false;
                        }
                    }
                    PaymentBtn.Enabled = false;
                    clickCount = 0;
                }

                #endregion 

            }
            #endregion 
        }

        #endregion

        #region machine products

        private void CocaColaBtn_Click(object sender, EventArgs e)
        {
        }
        private void fuzeTeeBtn_Click(object sender, EventArgs e)
        {
        }
        private void tropitBtn_Click_1(object sender, EventArgs e)
        {
        }
        private void OrangeJuiceBtn_Click(object sender, EventArgs e)
        {
        }
        private void chipsBtn_Click(object sender, EventArgs e)
        {
        }
        private void bislliBtn_Click(object sender, EventArgs e)
        {
        }
        private void bambaBtn_Click_1(object sender, EventArgs e)
        {
        }
        private void apropoBtn_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region machine drinks 

        private void DalCaloriesIcecofeeBtn_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkbox in decoratorCheckboxes)
            {
                checkbox.Enabled = true;
            }
            WithoutDEC.Enabled = true;
            foreach (Button button in Controls.OfType<Button>())
            {
                button.Enabled = false;
            }
        }

        private void IceCoffe_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkbox in decoratorCheckboxes)
            {
                checkbox.Enabled = true;
            }
            WithoutDEC.Enabled = true;
            foreach (Button button in Controls.OfType<Button>())
            {
                button.Enabled = false;
            }

        }

        #region the decorators of the cold drink
        private void WhiteChocolateCB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void BlackChocolateCB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CreamCB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void RibatChalavCB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void IsMOkaCB_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void WithoutDEC_CheckedChanged(object sender, EventArgs e)
        {
            PaymentBtn.Enabled = true;

            foreach (Control control in Controls)
            {
                if (control is CheckBox checkbox)
                {
                    checkbox.Checked = false;
                }
            }

        }
        #endregion

        private void HotCofeeBtn_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkbox in builderCheckboxes)
            {
                checkbox.Enabled = true;
            }
        }

        #endregion

        #region another buttons...
        private void GiftCB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BagCB_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void finishLabel_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void coldDrink_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}