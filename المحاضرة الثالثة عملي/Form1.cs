using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace المحاضرة_الثالثة_عملي
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        { //تضعيف الاحداث للعدد الثاني والثالث
            secondN.KeyPress += fristN_KeyPress;
            thirdN.KeyPress += fristN_KeyPress;
            //تضعيف الداله التي تقوم بفحص العملية 
            opertion2.KeyPress += opertion1_KeyPress;
          }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, number3;
            string op1 = opertion1.Text;
            string op2 = opertion2.Text;
            string fristRoust;
            string fainalRoust;

            if (double.TryParse(fristN.Text, out number1) &&
                double.TryParse(secondN.Text, out number2) &&
                double.TryParse(thirdN.Text, out number3))
            {//فحص العمليات الاولا قي العملية الاولا
                if ((op1 == "/" || op1 == "*") || op1==op2)  //الاولويه للعملية / و * ثم اذا كانت العمليات متساوية نفذ من هذا الاتجاه
                {
                    fristRoust = sumNumber(number1, number2, op1).ToString();
                    if (fristRoust == "NaN") 
                    {
                        MessageBox.Show("غلط في العمليه الاولى");
                        opertion1.Focus();
                        return;
                    }

                    fainalRoust = sumNumber(Convert.ToDouble(fristRoust), number3, op2).ToString();
                    if (fainalRoust == "NaN")
                    {
                        MessageBox.Show("العملية الثانية غلط");
                        opertion2.Focus();
                        return;
                    }

                    result.Text = fainalRoust.ToString();

                }
                    //فحص العملية الثانية اذا كنت هيا الاولا للعملية الحسابيه
                else if ((op2 == "*" || op2 == "/") )
                {
                    fristRoust = sumNumber(number2, number3, op2).ToString();
                    if (fristRoust == "NaN")
                    {
                        MessageBox.Show("العملية الثانية غلط");
                        opertion2.Focus();
                        return;
                    }
                    fainalRoust = sumNumber(Convert.ToDouble(fristRoust), number1, op1).ToString();
                    if (fainalRoust == "NaN")
                    {
                        MessageBox.Show("العملية الاوللى غلط");
                        opertion1.Focus();
                        return;
                    }
                    result.Text = fainalRoust.ToString();
                }
            }

            else
            {
                MessageBox.Show("يرجو ادخال قيم صحيحة");
            }
            }
        //الداله التي تقوم بالعملية الحسابية
            private double sumNumber(double n1,double n2,string op)
            {
                    switch (op)
                    { case "+":
                            return n1+n2;
                        case "-":
                            return n1-n2;
                        case "*":
                            return n1*n2;
                        case "/":
                            {
                                if (n2 == 0)
                                    return 0;
                                else
                                    return n1 / n2;
                            }
                        default:
                            return double.NaN;
                    }

            }
            private void fristN_KeyPress(object sender, KeyPressEventArgs e)
            {
                //دالة لاتقبل الحروف 
                if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && e.KeyChar!=46)
                    e.Handled = true;
            }

            private void opertion1_KeyPress(object sender, KeyPressEventArgs e)
            {// لا تقبل في خانات العملية الا عملية الجمع والضرب والطرح والقسمة فقط
                if (e.KeyChar != 43 && e.KeyChar != 42 && e.KeyChar != 45 && e.KeyChar != 47 && e.KeyChar!=8)
                    e.Handled = true;
            }


        }
    }

