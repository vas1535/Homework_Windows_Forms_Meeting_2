namespace Homework_Windows_Forms_Meeting_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += StartGama;
        }

        private void StartGama(object sender, EventArgs e)
        {
            DialogResult result;
            int numDialog = 1;
            while (true)
            {
                result = MessageBox.Show($"{new Random().Next(1, 2000)}", "�������� �����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) 
                {
                    MessageBox.Show($"���������� �������� {numDialog}", "�����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    numDialog = 0;
                    result = MessageBox.Show($"������ ����������?", "�����", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) this.Close();
                }
                numDialog++;
            }
        }
    }
}