namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbBrush.Checked && cbCode.Checked && cbPrayer.Checked && cbRemaining.Checked && cbEmails.Checked && cbBreakfast.Checked)
            {
                lblDaily.Text = ("Perfect!");
            }
            else
            {
                MessageBox.Show("Oh no, you have not completed your daily tasks, please make sure you complete your tasks");
            }
            if (cbRoom.Checked && cbGrocery.Checked && cbHouse.Checked && cbLaundry.Checked && cbProjects.Checked && cbFamily.Checked)
            {
                lblOnce.Text = ("Well Done!");
            }
            else
            {
                MessageBox.Show("Don't forget your once a week to do list!");
            }
            if (cbFootball.Checked && cbGraveyard.Checked)
            {
                lblTwice.Text = ("Nice Work!");
            }
            else
            {
                MessageBox.Show("Don't forget about your twice a week tasks.");
            }
        }
    }
}