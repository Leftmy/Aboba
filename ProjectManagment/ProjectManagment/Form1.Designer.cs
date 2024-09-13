namespace ProjectManagment
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
            dataGridView1 = new DataGridView();
            labelBuy = new Label();
            labelSell = new Label();
            labelProfit = new Label();
            textBoxBuy = new TextBox();
            textBoxSell = new TextBox();
            textBoxProfit = new TextBox();
            textBoxLoss = new TextBox();
            labelLoss = new Label();
            buttonChange = new Button();
            buttonEnter = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Enabled = false;
            dataGridView1.Location = new Point(82, 216);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(720, 220);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // labelBuy
            // 
            labelBuy.AutoSize = true;
            labelBuy.Enabled = false;
            labelBuy.Location = new Point(75, 39);
            labelBuy.Name = "labelBuy";
            labelBuy.Size = new Size(92, 20);
            labelBuy.TabIndex = 0;
            labelBuy.Text = "Ціна купівлі";
            labelBuy.Click += label1_Click;
            // 
            // labelSell
            // 
            labelSell.AutoSize = true;
            labelSell.Enabled = false;
            labelSell.Location = new Point(199, 39);
            labelSell.Name = "labelSell";
            labelSell.Size = new Size(103, 20);
            labelSell.TabIndex = 1;
            labelSell.Text = "Ціна продажі";
            // 
            // labelProfit
            // 
            labelProfit.AutoSize = true;
            labelProfit.Enabled = false;
            labelProfit.Location = new Point(345, 39);
            labelProfit.Name = "labelProfit";
            labelProfit.Size = new Size(66, 20);
            labelProfit.TabIndex = 2;
            labelProfit.Text = "Виручка";
            // 
            // textBoxBuy
            // 
            textBoxBuy.Enabled = false;
            textBoxBuy.Location = new Point(75, 74);
            textBoxBuy.Name = "textBoxBuy";
            textBoxBuy.Size = new Size(98, 27);
            textBoxBuy.TabIndex = 3;
            textBoxBuy.Text = "0,4";
            // 
            // textBoxSell
            // 
            textBoxSell.Enabled = false;
            textBoxSell.Location = new Point(204, 74);
            textBoxSell.Name = "textBoxSell";
            textBoxSell.Size = new Size(98, 27);
            textBoxSell.TabIndex = 4;
            textBoxSell.Text = "0,75";
            // 
            // textBoxProfit
            // 
            textBoxProfit.Enabled = false;
            textBoxProfit.Location = new Point(332, 74);
            textBoxProfit.Name = "textBoxProfit";
            textBoxProfit.Size = new Size(98, 27);
            textBoxProfit.TabIndex = 5;
            textBoxProfit.Text = "0,35";
            // 
            // textBoxLoss
            // 
            textBoxLoss.Enabled = false;
            textBoxLoss.Location = new Point(459, 74);
            textBoxLoss.Name = "textBoxLoss";
            textBoxLoss.Size = new Size(98, 27);
            textBoxLoss.TabIndex = 9;
            textBoxLoss.Text = "0,5";
            textBoxLoss.TextChanged += textBox1_TextChanged;
            // 
            // labelLoss
            // 
            labelLoss.AutoSize = true;
            labelLoss.Enabled = false;
            labelLoss.Location = new Point(472, 39);
            labelLoss.Name = "labelLoss";
            labelLoss.Size = new Size(57, 20);
            labelLoss.TabIndex = 8;
            labelLoss.Text = "Збитки";
            // 
            // buttonChange
            // 
            buttonChange.Location = new Point(596, 45);
            buttonChange.Name = "buttonChange";
            buttonChange.Size = new Size(203, 56);
            buttonChange.TabIndex = 10;
            buttonChange.Text = "Натисність, щоб змінити";
            buttonChange.UseVisualStyleBackColor = true;
            buttonChange.Click += buttonChange_Click;
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(380, 124);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(203, 56);
            buttonEnter.TabIndex = 11;
            buttonEnter.Text = "Ввести значення";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 525);
            Controls.Add(buttonEnter);
            Controls.Add(buttonChange);
            Controls.Add(textBoxLoss);
            Controls.Add(labelLoss);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxProfit);
            Controls.Add(textBoxSell);
            Controls.Add(textBoxBuy);
            Controls.Add(labelProfit);
            Controls.Add(labelSell);
            Controls.Add(labelBuy);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label labelBuy;
        private Label labelSell;
        private Label labelProfit;
        private TextBox textBoxBuy;
        private TextBox textBoxSell;
        private TextBox textBoxProfit;
        private TextBox textBoxLoss;
        private Label labelLoss;
        private Button buttonChange;
        private Button buttonEnter;
    }
}
