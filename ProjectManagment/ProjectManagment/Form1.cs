using System.Windows.Forms;

namespace ProjectManagment
{
    public partial class Form1 : Form
    {
        double[] a;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            textBoxBuy.Enabled = true;
            textBoxSell.Enabled = true;
            textBoxProfit.Enabled = true;
            textBoxLoss.Enabled = true;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                bool isBuyValid = double.TryParse(textBoxBuy.Text, out double buy);
                bool isSellValid = double.TryParse(textBoxSell.Text, out double sell);
                bool isLossValid = double.TryParse(textBoxLoss.Text, out double loss);
                bool isProfitValid = double.TryParse(textBoxProfit.Text, out double profit);

                if (isBuyValid && isSellValid && isLossValid && isProfitValid)
                {
                    MessageBox.Show("Введення успішно виконано!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxBuy.Enabled = false;
                    textBoxSell.Enabled = false;
                    textBoxProfit.Enabled = false;
                    textBoxLoss.Enabled = false;
                    AddColumnsToDataGridView();
                    FillTable();
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть правильні числові значення в усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Сталася помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void AddColumnsToDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Альтернативи", Width = 134 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "0", Width = 134 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "1" , Width = 134 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "2" , Width = 134 });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "3" , Width = 134 });
                        
            dataGridView1.Rows.Add("0", "", "", "", "");
            dataGridView1.Rows.Add("1", "", "", "", "");
            dataGridView1.Rows.Add("2", "", "", "", "");
            dataGridView1.Rows.Add("3", "", "", "", "");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FillTable()
        {
            double[] a = new double[4];
            a[0] = Convert.ToDouble(textBoxBuy.Text);
            a[1] = Convert.ToDouble(textBoxSell.Text);
            a[2] = a[1] - a[0];
            a[3] = Convert.ToDouble(textBoxLoss.Text);
            double res = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4;j++)
                {
                    res = 0;
                    if (j > i) res -= (j - i) * a[3];
                    else if (j < i) res -= (i - j) * a[0];
                    else if (j > 0 && i > 0 && i > j) res += j * a[2];
                    else if (j > 0 && i > 0 && i <= j) res += i * a[2];
                    dataGridView1.Rows[i].Cells[j+1].Value = Math.Round(res,2);
                }
            }
        }
    }
}
