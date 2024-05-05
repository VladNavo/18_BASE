using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Zad4Calculator
{
    public partial class Form1 : Form
    {
        private readonly CalculatorPrezenter prezenter;
        public Form1()
        {
            InitializeComponent();
            InitializeCombobox();
            prezenter = new CalculatorPrezenter(this);
        }

        private void InitializeCombobox()
        {
            string[] operation = { "Сложение", "Вычитание", "Умножение", "Деление" };
            comboBox1.Items.AddRange(operation);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var text1 = textBox1.Text;
            var text2 = textBox2.Text;
            if (TextBoxValidate(text1, text2))
            {
                prezenter.calculate();
            }
            else
            {
                MessageBox.Show("Проверте корректность вводимых данных");
            }
        }

        private bool TextBoxValidate(string text1,string text2 )
        {
            double number;
            var flag = true;
            
            if (text1 != null && text2 != null  && double.TryParse(text1, out number)&& double.TryParse(text2, out number)) 
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
           
        }
    }
    class CalculatorModel
    {
        public string calculate(double number1, double number2, string operation)
        {
            var rezult = "";
            switch (operation)
            {
                case "Сложение": rezult = Convert.ToString(number1 + number2); break;
                case "Вычитание": rezult = Convert.ToString(number1 - number2); break;
                case "Умножение": rezult = Convert.ToString(number1 * number2); break;
                case "Деление":

                    if (number2 == 0)
                    {
                        throw new Exception("Нельзя делить на 0");
                    }
                    else
                    {
                        rezult = Convert.ToString(number1 / number2);
                    }
                    break;

            }
            return rezult;

        }
    }
    class CalculatorPrezenter
    {
        private readonly Form1 view;
        private readonly CalculatorModel model;
        private double number1;
        private double number2;
        private string operation;

        public CalculatorPrezenter(Form1 view)
        {
            this.view = view;
            model = new CalculatorModel();
        }

        public void calculate()
        {
            var number1 = Convert.ToDouble(view.textBox1.Text);
            var number2 = Convert.ToDouble(view.textBox2.Text);
            var operation = view.comboBox1.SelectedItem.ToString();

            try
            {
                var result = model.calculate(number1, number2, operation);
                view.richTextBox1.Text = $"Результатом операции {operation} над числами(цифрами):{number1} и {number2} является число(цифра):{result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}