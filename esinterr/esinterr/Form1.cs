namespace esinterr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int righe = 5;
        int colonne = 5;
        Button[] buttons=new Button[25];
        int k = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < righe; i++)
            {
                for (int j = 0; j < colonne; j++)
                {
                   
                    buttons[k]= new Button();
                    buttons[k].Size= new Size(100 * j, 100 * i);
                    buttons[k].Location = new Point(j * 100, i * 100);
                    this.Controls.Add(buttons[k]);
                    k++;
                   
                }
            }
            object oggetto = (object)buttons;
            Thread t1 = new Thread(colora);
            t1.Start(oggetto);
            this.ClientSize = new Size(colonne * 100, righe * 100);
        }
        public void colora(object obj)
        {
            for(int i=0;i<righe*colonne;i++)
            {
                Thread.Sleep(10);
                Button[] arg = (Button[])obj;
                Random casuale = new Random();
                int caso = casuale.Next(righe * colonne);
                arg[caso].BackColor = Color.Lime;
            }
            
        }

    }
}