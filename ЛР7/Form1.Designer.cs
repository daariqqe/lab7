namespace ЛР7
{
    partial class Form1
    {
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.TextBox tbMinResult; 
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelMinResult; 

        private void InitializeComponent()
        {
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbMinResult = new System.Windows.Forms.TextBox(); 
            this.labelResult = new System.Windows.Forms.Label();
            this.labelMinResult = new System.Windows.Forms.Label(); 
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();

            // labelX1
            this.labelX1.Text = "X1:";
            this.labelX1.Location = new System.Drawing.Point(30, 20);
            this.labelX1.Size = new System.Drawing.Size(50, 20);

            // labelX2
            this.labelX2.Text = "X2:";
            this.labelX2.Location = new System.Drawing.Point(30, 60);
            this.labelX2.Size = new System.Drawing.Size(50, 20);

            // tbX1
            this.tbX1.Location = new System.Drawing.Point(90, 20);
            this.tbX1.Size = new System.Drawing.Size(150, 20); 
            this.tbX1.ForeColor = System.Drawing.Color.Black; 
            this.tbX1.BackColor = System.Drawing.Color.White; 
            // tbX2
            this.tbX2.Location = new System.Drawing.Point(90, 60);
            this.tbX2.Size = new System.Drawing.Size(150, 20);
            this.tbX2.ForeColor = System.Drawing.Color.Black;
            this.tbX2.BackColor = System.Drawing.Color.White;


            // btnCalculate
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.Location = new System.Drawing.Point(30, 100);
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);

            // tbResult
            this.tbResult.Location = new System.Drawing.Point(90, 140);
            this.tbResult.Size = new System.Drawing.Size(150, 20);
            this.tbResult.ReadOnly = true;
            this.tbResult.ForeColor = System.Drawing.Color.Black;
            this.tbResult.BackColor = System.Drawing.Color.LightGray;

            // tbMinResult
            this.tbMinResult.Location = new System.Drawing.Point(105, 180);
            this.tbMinResult.Size = new System.Drawing.Size(150, 20);
            this.tbMinResult.ReadOnly = true;
            this.tbMinResult.ForeColor = System.Drawing.Color.Black;
            this.tbMinResult.BackColor = System.Drawing.Color.LightGray;

            // labelResult
            this.labelResult.Text = "Результат:";
            this.labelResult.Location = new System.Drawing.Point(30, 140);
            this.labelResult.Size = new System.Drawing.Size(60, 20);

            // labelMinResult
            this.labelMinResult.Text = "Мін. значення";
            this.labelMinResult.Location = new System.Drawing.Point(30, 180);
            this.labelMinResult.Size = new System.Drawing.Size(100, 20);

            // btnClear
            this.btnClear.Text = "Очистити";
            this.btnClear.Location = new System.Drawing.Point(30, 220);
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);

            // btnExit
            this.btnExit.Text = "Вихід";
            this.btnExit.Location = new System.Drawing.Point(130, 220);
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbMinResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelMinResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Text = "Лабораторна робота 7";
        }
    }
}
