namespace RemoveDuplicateFromList
{
    public partial class Form1 : Form
    {
        string path = "";
        string LineTemp = "";
        List<string> listBrut = new();
        List<string> listClean = new();
        List<string> listTemp = new();


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                textBox1.Text = path;
            }
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            RemoveDuplicate();   
        }

        private void RemoveDuplicate()
        {
            int i = 0;

            foreach (string line in File.ReadAllLines(path))
            {
                LineTemp += line;

                foreach (string mot in LineTemp.Split(" "))
                {
                    listBrut.Add(mot);
                }

                LineTemp = "";
            }    

            foreach (string mot in listBrut)
            {
                if (!listTemp.Contains(mot))
                {
                    listTemp.Add(mot);
                    LineTemp += mot + " ";
                    i++;

                    if (i == 6)
                    {
                        listClean.Add(LineTemp);
                        LineTemp = "";
                        i = 0;
                    } 
                }
            }

            File.WriteAllLines(path, listClean);

            MessageBox.Show("Done !");
        }
    }
}
