using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcdemo {
    public partial class Form1 : Form {
        private double currentValue = 0;	// the current value
        private double storedValue = 0;		// the prev value
        private Operation operation = Operation.None;	// the operation we're going to perform
        private bool isNewEntry = true;

        private enum Operation { // the operations we can perform
            None,
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public Form1() {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e) {
            append("1");
        }

        private void btn2_Click(object sender, EventArgs e) {
            append("2");
        }

        private void btn3_Click(object sender, EventArgs e) {
            append("3");
        }

        private void btn4_Click(object sender, EventArgs e) {
            append("4");
        }

        private void btn5_Click(object sender, EventArgs e) {
            append("5");
        }

        private void btn6_Click(object sender, EventArgs e) {
            append("6");
        }

        private void btn7_Click(object sender, EventArgs e) {
            append("7");
        }

        private void btn8_Click(object sender, EventArgs e) {
            append("8");
        }

        private void btn9_Click(object sender, EventArgs e) {
            append("9");
        }

        private void btn0_Click(object sender, EventArgs e) {
            append("0");
        }

        private void btnSubtract_Click(object sender, EventArgs e) {
            setOperator(Operation.Subtract);
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            setOperator(Operation.Add);
        }

        private void btnMultiply_Click(object sender, EventArgs e) {
            setOperator(Operation.Multiply);
        }

        private void btnDivide_Click(object sender, EventArgs e) {
            setOperator(Operation.Divide);
        }

        private void btnResult_Click(object sender, EventArgs e) {
			// calculate the result
			
            currentValue = double.Parse(textBox1.Text); // get the current contents of the textbox but as a 'double' datatype

			// the actual math
            switch (operation) {
                case Operation.Add: textBox1.Text = (storedValue + currentValue).ToString(); break;
                case Operation.Subtract: textBox1.Text = (storedValue - currentValue).ToString(); break;
                case Operation.Multiply: textBox1.Text = (storedValue * currentValue).ToString(); break;
                case Operation.Divide: textBox1.Text = currentValue != 0 ? (storedValue / currentValue).ToString() : "Error"; break;
            }
            
            isNewEntry = true;
        }

		// reset (not used)
        private void clear() {
            textBox1.Text = "0";
            storedValue = 0;
            currentValue = 0;
            operation = Operation.None;
            isNewEntry = true;
        }

		// initialize
        private void Form1_Load(object sender, EventArgs e) {
            textBox1.Text = "0";
        }

		// append a new number
        private void append(string number) {
            if (isNewEntry) {
                textBox1.Text = number;
                isNewEntry = false;
            }
            else {
                textBox1.Text += number;
            }
        }

		// set the operator we're going to use
        private void setOperator(Operation op) {
            storedValue = double.Parse(textBox1.Text);
            operation = op;
            isNewEntry = true;
        }
    }
}