namespace jogo_velha
{
    public partial class Form1 : Form
    {
        string[,] matriz = {{ "button1", "button2", "button3" },
                            { "button4", "button5", "button6" },
                            { "button7", "button8", "button9" }};

        int[,] matriz1 = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        int qtd = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (button.Name == matriz[i, j])
                    {
                        if (button.Text == "" && (qtd % 2 == 0))
                        {
                            button.Text = "x";
                            matriz1[i, j] = 1;
                            qtd++;
                        }
                        else if (button.Text == "" && (qtd % 2 != 0))
                        {
                            button.Text = "o";
                            matriz1[i, j] = 2;
                            qtd++;
                        }
                        else
                        {
                            MessageBox.Show("Você está tentando clickar em algo que já foi utilizado", "Alerta");
                        }
                    }
                }
            }
            if (verification() == 1 || verification() == 2)
            {
                int ganhador = verification();

                MessageBox.Show("Parabéns o " + ((ganhador == 1) ? "X" : "O") + " ganhou!! :)", "Fim de jogo");
                restartFim();
                return;
            }
            if (verification() == 9)
            {
                MessageBox.Show("Deu velha", "Fim de jogo");
                restartFim();
                return;
            }
        }
        private int verification()
        {
            int velha = 0;



            for (int i = 0; i < 3; i++)
            {
                if (matriz1[i, 0] != 0 && matriz1[i, 1] == matriz1[i, 0] && matriz1[i, 2] == matriz1[i, 0])
                {
                    return matriz1[i, 0];
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (matriz1[0, j] != 0 && matriz1[1, j] == matriz1[0, j] && matriz1[2, j] == matriz1[0, j])
                {
                    return matriz1[0, j];
                }
            }

            if (matriz1[0, 0] != 0 && matriz1[1, 1] == matriz1[0, 0] && matriz1[2, 2] == matriz1[0, 0])
            {
                return matriz1[0, 0];
            }
            if (matriz1[0, 2] != 0 && matriz1[1, 1] == matriz1[0, 2] && matriz1[2, 0] == matriz1[0, 2])
            {
                return matriz1[0, 2];
            }

            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    if (matriz1[k, l] != 0)
                    {
                        velha++;
                    }
                }
            }

            if (velha == 9)
            {
                return velha;
            }

            return 0;
        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            qtd = 0;

            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Control ctrl = this.Controls.Find(matriz[k, l], true).FirstOrDefault();
                    if (ctrl is Button)
                    {
                        ((Button)ctrl).Text = "";
                    }
                    matriz1[k, l] = 0;
                }
            }
        }

        private void restartFim()
        {
            qtd = 0;

            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Control ctrl = this.Controls.Find(matriz[k, l], true).FirstOrDefault();
                    if (ctrl is Button)
                    {
                        ((Button)ctrl).Text = "";
                    }
                    matriz1[k, l] = 0;
                }
            }
        }
    } 
}
 