using System;
using System.Drawing;
using System.Windows.Forms;
using Love; // DLL Project 1

namespace LoveWinForm
{
    public class MainForm : Form
    {
        Label lblTitle, lblResult;
        DateTimePicker dtpStartDate;
        Button btnCalculate;

        public MainForm()
        {
            // Form
            this.Text = "Đếm ngày yêu ❤️";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightPink;

            // Title
            lblTitle = new Label();
            lblTitle.Text = "Đếm ngày yêu ❤️";
            lblTitle.Font = new Font("Arial", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.Red;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(100, 20);
            this.Controls.Add(lblTitle);

            // DateTimePicker
            dtpStartDate = new DateTimePicker();
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(120, 70);
            dtpStartDate.Width = 150;
            this.Controls.Add(dtpStartDate);

            // Button
            btnCalculate = new Button();
            btnCalculate.Text = "Tính số ngày";
            btnCalculate.Location = new Point(140, 110);
            btnCalculate.Click += BtnCalculate_Click;
            this.Controls.Add(btnCalculate);

            // Result
            lblResult = new Label();
            lblResult.Text = "";
            lblResult.Font = new Font("Arial", 12, FontStyle.Bold);
            lblResult.AutoSize = true;
            lblResult.Location = new Point(50, 160);
            this.Controls.Add(lblResult);
        }

        void BtnCalculate_Click(object sender, EventArgs e)
        {
            LoveCalculator calc = new LoveCalculator();
            calc.StartDate = dtpStartDate.Value;
            calc.Calculate();
            lblResult.Text = "💖 " + calc.Message + " 💖";
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
