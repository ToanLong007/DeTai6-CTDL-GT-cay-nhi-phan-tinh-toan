using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTai6_CTDL_DT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Node
        {
            public string Value;
            public Node Left, Right;

            public Node(string value)
            {
                Value = value;
                Left = Right = null;
            }
        }

        bool IsOperator(string c)
        {
            return c == "+" || c == "-" || c == "*" || c == "/";
        }
        int Priority(string op)
        {
            if (op == "+" || op == "-") return 1;
            if (op == "*" || op == "/") return 2;
            return 0;
        }
        // ===== 4. Tách chuỗi =====
        List<string> Tokenize(string input)
        {
            List<string> tokens = new List<string>();
            string number = "";

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    number += c;
                }
                else
                {
                    if (number != "")
                    {
                        tokens.Add(number);
                        number = "";
                    }

                    if (c != ' ')
                        tokens.Add(c.ToString());
                }
            }

            if (number != "")
                tokens.Add(number);

            return tokens;
        }
        // ===== 5. Tạo node =====
        void Process(Stack<Node> values, Stack<string> ops)
        {
            string op = ops.Pop();

            Node right = values.Pop();
            Node left = values.Pop();

            Node node = new Node(op);
            node.Left = left;
            node.Right = right;

            values.Push(node);
        }
        Node BuildTree(string input)
        {
            var tokens = Tokenize(input);

            Stack<Node> values = new Stack<Node>();
            Stack<string> ops = new Stack<string>();

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out _))
                {
                    values.Push(new Node(token));
                }
                else if (token == "(")
                {
                    ops.Push(token);
                }
                else if (token == ")")
                {
                    while (ops.Peek() != "(")
                    {
                        Process(values, ops);
                    }
                    ops.Pop();
                }
                else if (IsOperator(token))
                {
                    while (ops.Count > 0 && Priority(ops.Peek()) >= Priority(token))
                    {
                        Process(values, ops);
                    }
                    ops.Push(token);
                }
            }

            while (ops.Count > 0)
            {
                Process(values, ops);
            }

            return values.Pop();
        }
        double Evaluate(Node root)
        {
            if (root == null) return 0;

            if (!IsOperator(root.Value))
                return double.Parse(root.Value);

            double left = Evaluate(root.Left);
            double right = Evaluate(root.Right);

            switch (root.Value)
            {
                case "+": return left + right;
                case "-": return left - right;
                case "*": return left * right;
                case "/": return left / right;
            }

            return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void so4_Click(object sender, EventArgs e)
        {
            textbox.Text += "4";
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            if (textbox.Text.Length > 0)
            {
                textbox.Text = textbox.Text.Substring(0, textbox.Text.Length - 1);
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            textbox.Text += "(";
        }

        private void close_Click(object sender, EventArgs e)
        {
            textbox.Text += ")";
        }

        private void chia_Click(object sender, EventArgs e)
        {
            textbox.Text += "/";
        }

        private void so2_Click(object sender, EventArgs e)
        {
            textbox.Text += "2";
        }

        private void so3_Click(object sender, EventArgs e)
        {
            textbox.Text += "3";
        }

        private void so5_Click(object sender, EventArgs e)
        {
            textbox.Text += "5";
        }

        private void so6_Click_1(object sender, EventArgs e)
        {
            textbox.Text += "6";
        }

        private void cong_Click(object sender, EventArgs e)
        {
            textbox.Text += "+";
        }

        private void so7_Click(object sender, EventArgs e)
        {
            textbox.Text += "7";
        }

        private void so8_Click(object sender, EventArgs e)
        {
            textbox.Text += "8";
        }

        private void so9_Click(object sender, EventArgs e)
        {
            textbox.Text += "9";
        }

        private void tru_Click(object sender, EventArgs e)
        {
            textbox.Text += "-";
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            textbox.Text += "*";
        }

        private void bang_Click(object sender, EventArgs e)
        {
            try
            {
                Node root = BuildTree(textbox.Text);
                double result = Evaluate(root);

                textbox1.Text = "=";
                textbox1.Text += result.ToString();
            }
            catch
            {
                textbox1.Text = "Lỗi!";
            }
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
