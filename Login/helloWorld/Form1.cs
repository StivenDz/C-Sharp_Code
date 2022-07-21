namespace helloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e){
            //this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            //this.label2.ForeColor = System.Drawing.Color.Lime;

            string[,] data;
            data = new string[1,2];
            data[0,0] = "stivendz";
            data[0,1] = "diaz";

            void login(string user,string pass)
            {
                string userName = textBox1.Text;
                string password = textBox2.Text;

                if (userName == user && password == pass)
                {
                    label2.ForeColor = System.Drawing.Color.Lime;
                    label2.Text = "Logeado!!!";
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
                else
                {
                    label2.ForeColor = System.Drawing.Color.Red;
                    label2.Text = "Credenciales Incorrectas!!!";
                };
                
            };

            login(data[0,0], data[0,1]);

            //string helloWorld, cadena;
            //int numeroEntero = 123;
            //const double NUMERO_CONSTANTE = 3.1416;

            //helloWorld = "Hello World With C#";
            //cadena = ((numeroEntero + NUMERO_CONSTANTE) + helloWorld);
            //Console.WriteLine(cadena);
            //label1.Text = cadena;
        }

    }
}