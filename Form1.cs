namespace _07_12_2022_win_form_1_Forum
{
    public partial class Form1 : Form
    {
        string mess = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string mess = textBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
                           string mess = textBox1.Text;
                MessageBox.Show(mess);
                
                    
            
        }

       
      
    }
}