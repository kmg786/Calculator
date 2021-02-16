//AUTHORS - Kunal, Feroz
//Basic C# windows form application
//1.Standard Calculator - Feroz
//2.Date Calculator - Kunal
//3.Currency Converter - Kunal
// Application Integration - Feroz


using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Calc_App
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            this.Width = 518;
            
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            this.Width = 518;
        }

        private void currencyConverterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox2.Location = new Point(0, 27);
            this.Width = 255;
        }

        private void dateCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox3.Location = new Point(0, 27);
            this.Width = 240;
        }
        
        //Currency Converter - Kunal

        private void conv_btn_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> currency = new Dictionary<string, double>()
            {
                {"US DOLLAR",72.94},{"AUS DOLLAR",56.58},{"CHN YUAN",11.29},{"JAPAN YEN",0.70}
            };
            try
            {
                string from = currency_from.Text;
                from = from.ToUpper();
                double amt = int.Parse(currency_amt.Text);
                string to = currency_to.Text;
                to = to.ToUpper();
                double val = 0;
                double valfrom = 0;
                double valto = 0;
                if (from.Equals(to))
                {
                    Result.Clear();
                    Result.AppendText("Same Currency Selected");
                }
                else
                {
                    if ((to == "INDIAN RUPEE") && (from == "US DOLLAR" || from == "AUS DOLLAR" || from == "CHN YUAN" || from == "JAPAN YEN"))
                    {
                        foreach (var item in currency)
                        {
                            if (item.Key == from)
                            {
                                val = Math.Round(item.Value * amt, 2);
                            }
                        }
                        Result.Clear();
                        Result.AppendText(string.Concat(val.ToString(), ' ', to));
                    }

                    else if ((from == "INDIAN RUPEE") && (to == "US DOLLAR" || to == "AUS DOLLAR" || to == "CHN YUAN" || to == "JAPAN YEN"))
                    {
                        foreach (var item in currency)
                        {
                            if (item.Key == to)
                            {
                                val = Math.Round((1 / item.Value) * amt, 2);
                            }
                        }
                        Result.Clear();
                        Result.AppendText(string.Concat(val.ToString(), "   ", to));
                    }

                    else
                    {
                        foreach (var item in currency)
                        {
                            if (item.Key == from)
                            {
                                valfrom = (item.Value);
                            }
                        }
                        foreach (var item in currency)
                        {
                            if (item.Key == to)
                            {
                                valto = (item.Value);
                            }
                        }
                        double res = Math.Round((valfrom / valto) * amt, 2);
                        Result.Clear();
                        Result.AppendText(string.Concat(res.ToString(), "     ", to));
                    }

                }
            }
            catch (Exception)
            {
                Result.Clear();
                Result.AppendText("Enter Correct Amount");
            }
        }
        // Date Calculator - Kunal
        private void button18_Click(object sender, EventArgs e)
        {
            DateTime fromDate;
            DateTime toDate;

            // the from date is greater than or less than the to date 
            if(FromDate.Value > ToDate.Value)
            {
                fromDate = FromDate.Value;
                toDate = ToDate.Value;
            }
            else
            {
                fromDate = ToDate.Value;
                toDate = FromDate.Value;
            }

            string complete = "";
            try
            {
                //get number of days
                int no_of_days = Math.Abs(int.Parse((toDate.Date - fromDate.Date).ToString().Split('.')[0]));
                if (no_of_days >= 7)
                {
                    total_days.Clear();
                    total_days.AppendText($"{no_of_days.ToString()} days");
                }

                DateDiff dateDiff = new DateDiff(fromDate, toDate);// while integrating form, error at this line.
                //Using Elapsed
                int yrs = Math.Abs(dateDiff.ElapsedYears);
                int mts = Math.Abs(dateDiff.ElapsedMonths);
                int week = 0;
                int days = Math.Abs(dateDiff.ElapsedDays);
                //Get weeks and days
                if (days >= 7)
                {
                    week = days / 7;
                    days %= 7;
                }
                //Output Formatting Conditions
                string years = (yrs > 1) ? $"{yrs} years" : (yrs == 0) ? "" : $"{yrs} year";
                string months = (mts > 1) ? $"{mts} months" : (mts == 0) ? "" : $"{mts} month";
                string weeks = (week > 1) ? $"{week} weeks" : (week == 0) ? "" : $"{week} week";
                string days_count = (days > 1) ? $"{days} days" : (days == 0) ? "" : $"{days} day";

                //Output formatting 
                string result = "";
                if (years.Length == 0) result += "";
                else result += $"{years} ";
                if (months.Length == 0) result += "";
                else result += $"{months} ";
                if (weeks.Length == 0) result += "";
                else result += $"{weeks} ";
                if (days_count.Length == 0) result += "";
                else result += $"{days_count} ";
               // string t = string.Concat(a,' ', b,' ', c,' ', d);

                Result.Clear();
                Result.AppendText(result); //append to textbox
             }
            //Same Date msg
            catch (Exception)
            {
                complete = "Same Dates";
                Result.Clear();
                Result.AppendText(complete);
            }
        }
        // Standard Calculator - Feroz
        
        private void button4_Click(object sender, EventArgs e)
        {
            
            if ((text.Text == "0") || (isOperationPerformed))
                text.Clear();

            isOperationPerformed = false;
            Button b1 = (Button)sender;
            if (b1.Text == ".")
            {
                if (!text.Text.Contains("."))
                    text.Text = text.Text + b1.Text;

            }
            else
                text.Text = text.Text + b1.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button b2 = (Button)sender;
           

            if (value != 0)
            {
                /*if (!(Convert.ToDouble(text.Text) >= 0))
                {
                    text.Text = "NaN";
                }
                else
                {*/
                    button3.PerformClick();
                button19.Enabled = true;
                operationPerformed = b2.Text;
                    label2.Text = value + " " + operationPerformed;
                
                isOperationPerformed = true;
                //}
            
            }
            else
            {

                operationPerformed = b2.Text;
               value = Double.Parse(text.Text);
                label2.Text = value + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            switch (operationPerformed)
            {
                case "+":
                    text.Text = (value + Double.Parse(text.Text)).ToString();
                    break;
                case "-":
                    text.Text = (value - Double.Parse(text.Text)).ToString();
                    break;
                case "*":
                    text.Text = (value * Double.Parse(text.Text)).ToString();
                    break;
                case "/":


                    //double v = Convert.ToDouble(text.Text);
                    //if (v >= 0)
                    //{
                    //double value1 = value / Double.Parse(text.Text);
                    text.Text = (value / Double.Parse(text.Text)).ToString();
                    
                    
                    //}
                    /*else
                    {
                        text.Text = "NaN";
                    }*/
                        break; 
                default:
                    break;
            }
            
            button19.Enabled = false;
            value = Double.Parse(text.Text);
            label2.Text = "";
            

        }

        private void button17_Click(object sender, EventArgs e)
        {
            text.Text = "0";
            button19.Enabled = true;
            label2.Text = " ";
            value = 0;
        }
        

        private void button19_Click(object sender, EventArgs e)
        {
            //double text_remove=Convert.ToDouble(text.Text) - 1;
            //text.Text = text_remove.ToString();
            if (text.Text.Length > 0)
            {
                if (text.Text.Length>1) 
                { 
                    text.Text = text.Text.Remove(text.Text.Length - 1, 1);
                }
                else
                {
                    text.Text = "0";
                }
            }
            //else if(text.Text.Length==0)
            //{
            //    //button17.PerformClick();
            //   // text.Text = "0";
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* text.Text = " ";
             if (e.KeyChar >= 45 && e.KeyChar <= 57)
             {

                 text.Text += e.KeyChar.ToString();
             }
             else
                 text.Text = "0";*/
            //text.Text = " ";
            
            if (char.IsDigit(e.KeyChar))
            {
                if (text.Text == "0")
                {
                    text.Clear();
                }
                
                text.Text += e.KeyChar.ToString();

               value= Convert.ToDouble(text.Text);
            }

            if (e.KeyChar == '.')
            {
                if (!text.Text.Contains('.'))
                {
                    text.Text += e.KeyChar.ToString();
                }
            }
            if (e.KeyChar == '+' || e.KeyChar == '-' || e.KeyChar == '/' || e.KeyChar == '*')
            {
                
                char op = e.KeyChar;
                label2.Text = text.Text + op;
                text.Clear();
                value = Convert.ToDouble(text.Text);
                //double value1 = Convert.ToDouble(text.Text);
                
                if (e.KeyChar == '+')
                {
                    text.Text = (value + Double.Parse(text.Text)).ToString();
                }
                
            }
           
           
            





        }
    }
}
