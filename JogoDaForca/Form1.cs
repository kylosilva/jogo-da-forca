using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        string[] palavras; //arrays para guardar as palavras do dicionário
        string palavra;
        char[] PalEscondida; //array de caracteres para a palavra advinhar
        bool acertou = false;
        string grau = "facil";
        short NumImag;
        bool soundON = false;
        int pontos = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SomInicial();
            IniciarJogo();
        }

        private void IniciarJogo()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            buttonStart.Visible = false;
            buttonSom.Visible = false;
            groupBoxDificuldade.Visible = false;
            buttonDificuldad.Visible = false;
            groupBoxTeclado.Visible = false;
            labelLetras.Visible = false;
            pictureBoxForca.Visible = false;
            acertou = false;
            NumImag = 0;
            ApresentarImg(NumImag);
            pictureBoxPerdeu.Visible = false;
            pictureBoxGanhou.Visible = false;
            groupBoxCarModes.Visible = false;
            pictureBoxMonitor.Visible = true;
            pictureBoxDancinha.Visible = false;
            pictureBoxTriste.Visible = false;
            pictureBoxLobo.Visible = false;
            labelInformacaoSobreEspaco.Visible = false;
            label1.Visible = false;
            pictureBoxCredits.Visible = false;
            buttonBackMenu.Visible = false;
            buttonCredits.Visible = false;
            buttonRestart.Visible = false;
            buttonQuit.Visible = false;
            buttonLigarEcraTele.Visible = true;
            pictureBoxXau.Visible = false;
            labelParaComecar.Visible = true;
            labelInformacaoNumeros.Visible = false;
            groupBoxSettings.Visible = false;
            labelAPalEra.Visible = false;
            labelPalEscondida.Visible = false;
            labelPontos.Visible = false;
            labelPontoss.Visible = false;
 
        }

        private void ApresentarImg(short nI)
        {
            try
            {
                if (nI == 0)
                    pictureBoxForca.Image = Properties.Resources.forca0;
                else if (nI == 1)
                    pictureBoxForca.Image = Properties.Resources.forca1;
                else if (nI == 2)
                    pictureBoxForca.Image = Properties.Resources.forca2;
                else if (nI == 3)
                    pictureBoxForca.Image = Properties.Resources.forca3;
                else if (nI == 4)
                    pictureBoxForca.Image = Properties.Resources.forca4;
                else if (nI == 5)
                    pictureBoxForca.Image = Properties.Resources.forca5;
                else if (nI == 6)
                    pictureBoxForca.Image = Properties.Resources.forca6;
                else if (nI == 7)
                    pictureBoxForca.Image = Properties.Resources.forca7;
                else if (nI == 8)
                    pictureBoxForca.Image = Properties.Resources.forca8;
                else if (nI == 9)
                    pictureBoxForca.Image = Properties.Resources.forcaMorto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void IniciarDicionario()
        {
            palavras = new string[30];
            try
            {
                if (grau == "facil")
                {
                    palavras[0] = "Banana";
                    palavras[1] = "Melão";
                    palavras[2] = "Maça";
                    palavras[3] = "Ananás";
                    palavras[4] = "Papaia";
                    palavras[5] = "Mamão";
                    palavras[6] = "Cereja";
                    palavras[7] = "Laranja";
                    palavras[8] = "Tangerina";
                    palavras[9] = "Tângera";
                    palavras[10] = "Pera";
                    palavras[11] = "Kiwi";
                    palavras[12] = "Pêssego";
                    palavras[13] = "Ameixa";
                    palavras[14] = "Abacate";
                    palavras[15] = "Melância";
                    palavras[16] = "Damasco";
                    palavras[17] = "Uvas";
                    palavras[18] = "Morango";
                    palavras[19] = "Limão";
                    palavras[20] = "Manga";
                    palavras[21] = "Nêspera";
                    palavras[22] = "Marmelo";
                    palavras[23] = "Framboesa";
                    palavras[24] = "Amora";
                    palavras[25] = "Mirtilio";
                    palavras[26] = "Romã";
                    palavras[27] = "Tâmara";
                    palavras[28] = "Figo";
                    palavras[29] = "Lima";
                }
                else if (grau == "medio")
                {
                    palavras[0] = "Botswana";
                    palavras[1] = "Angola";
                    palavras[2] = "Libéria";
                    palavras[3] = "Tanzânia";
                    palavras[4] = "Serra Leoa";
                    palavras[5] = "Zimbabwe";
                    palavras[6] = "Moçambique";
                    palavras[7] = "Afeganistão";
                    palavras[8] = "Zâmbia";
                    palavras[9] = "Malawi";
                    palavras[10] = "Namíbia";
                    palavras[11] = "Nigéria";
                    palavras[12] = "Somália";
                    palavras[13] = "Guiné Bissau";
                    palavras[14] = "Ruanda";
                    palavras[15] = "Etiópia";
                    palavras[16] = "Rússia";
                    palavras[17] = "Ucrânia";
                    palavras[18] = "Bulgária";
                    palavras[19] = "Bielorrúsia";
                    palavras[20] = "Quénia";
                    palavras[21] = "Letônia";
                    palavras[22] = "Camarões";
                    palavras[23] = "Burundi";
                    palavras[24] = "Estónia";
                    palavras[25] = "Gâmbia";
                    palavras[26] = "Moldávia";
                    palavras[27] = "Eslovénia";
                    palavras[28] = "Gabão";
                    palavras[29] = "Uganda";
                }
                else if (grau == "dificil")
                {
                    palavras[0] = "Butão";
                    palavras[1] = "Guernsey";
                    palavras[2] = "Mianmar";
                    palavras[3] = "Azerbaijão";
                    palavras[4] = "Eritreia";
                    palavras[5] = "Cazaquistão";
                    palavras[6] = "Gana";
                    palavras[7] = "Togo";
                    palavras[8] = "Senegal";
                    palavras[9] = "Jersey";
                    palavras[10] = "Belize";
                    palavras[11] = "Comboja";
                    palavras[12] = "Bahamas";
                    palavras[13] = "Turquemenistão";
                    palavras[14] = "Lêmen";
                    palavras[15] = "Kiribati";
                    palavras[16] = "Bangladesh";
                    palavras[17] = "Tajiquistão";
                    palavras[18] = "Uzbequistão";
                    palavras[19] = "Vanuatu";
                    palavras[20] = "Mayotte";
                    palavras[21] = "Suriname";
                    palavras[22] = "Papua nova Guiné";
                    palavras[23] = "Liechtenstein";
                    palavras[24] = "Tuvalu";
                    palavras[25] = "Quirguistão";
                    palavras[26] = "Palau";
                    palavras[27] = "Nauru";
                    palavras[28] = "Samoa";
                    palavras[29] = "Seicheles";
                }
                else if (grau == "CarNormal")
                {
                    palavras[0] = "Bmw";
                    palavras[1] = "Mercedes";
                    palavras[2] = "Opel";
                    palavras[3] = "Honda";
                    palavras[4] = "Hyundai";
                    palavras[5] = "Renault";
                    palavras[6] = "Mazda";
                    palavras[7] = "Nissan";
                    palavras[8] = "Jeep";
                    palavras[9] = "Mini";
                    palavras[10] = "Smart";
                    palavras[11] = "Volvo";
                    palavras[12] = "Seat";
                    palavras[13] = "Toyota";
                    palavras[14] = "Peugeot";
                    palavras[15] = "Lancia";
                    palavras[16] = "Ferrari";
                    palavras[17] = "Fiat";
                    palavras[18] = "Lamborghini";
                    palavras[19] = "Bugatti";
                    palavras[20] = "Polestar";
                    palavras[21] = "Subaru";
                    palavras[22] = "Skoda";
                    palavras[23] = "Ford";
                    palavras[24] = "Audi";
                    palavras[25] = "Dacia";
                    palavras[26] = "Bentley";
                    palavras[27] = "Porsche";
                    palavras[28] = "Suzuki";
                    palavras[29] = "Mustang";
                }
                else if (grau == "CarImpossible")
                {
                    palavras[0] = "koenigsegg";
                    palavras[1] = "McLaren";
                    palavras[2] = "Maserati";
                    palavras[3] = "Rolls Royce";
                    palavras[4] = "Daihatsu";
                    palavras[5] = "Dodge";
                    palavras[6] = "Chevrolet";
                    palavras[7] = "Lincoln";
                    palavras[8] = "Alpine";
                    palavras[9] = "Cupra";
                    palavras[10] = "Volkswagen";
                    palavras[11] = "Abarth";
                    palavras[12] = "Aiways";
                    palavras[13] = "Ds";
                    palavras[14] = "Jaguar";
                    palavras[15] = "Lotus";
                    palavras[16] = "Mg";
                    palavras[17] = "LandRover";
                    palavras[18] = "Ssangyong";
                    palavras[19] = "Mitsubishi";
                    palavras[20] = "Pars";
                    palavras[21] = "Wuling";
                    palavras[22] = "Proton";
                    palavras[23] = "Innoson";
                    palavras[24] = "Venirauto";
                    palavras[25] = "W motors";
                    palavras[26] = "Hennessey";
                    palavras[27] = "Acura";
                    palavras[28] = "UMM";
                    palavras[29] = "Portaro";
                }
                else if (grau == "Games")
                {
                    palavras[0] = "Minecraft";
                    palavras[1] = "Roblox";
                    palavras[2] = "Valorant";
                    palavras[3] = "Rocket League";
                    palavras[4] = "Call Of Dutty";
                    palavras[5] = "Clash Royal";
                    palavras[6] = "God Of War";
                    palavras[7] = "Need For Speed";
                    palavras[8] = "Fifa";
                    palavras[9] = "Pes";
                    palavras[10] = "GTA 5";
                    palavras[11] = "Mario Kart";
                    palavras[12] = "Grand Turismo";
                    palavras[13] = "Far Cry";
                    palavras[14] = "Fortnite";
                    palavras[15] = "F1 Manager";
                    palavras[16] = "Bad Piggies";
                    palavras[17] = "Car Mecanic";
                    palavras[18] = "Terraria";
                    palavras[19] = "Fall Guys";
                    palavras[20] = "Tetris";
                    palavras[21] = "The Last Of Us";
                    palavras[22] = "Pokémon Go";
                    palavras[23] = "Geometry Dash";
                    palavras[24] = "Standoff";
                    palavras[25] = "Mortal Kombat";
                    palavras[26] = "Brawlhalla";
                    palavras[27] = "RAID";
                    palavras[28] = "Monopoly";
                    palavras[29] = "Forza Horizon";
                }
                else if (grau == "Films")
                {
                    palavras[0] = "Velocidade Furiosa";
                    palavras[1] = "Star Wars";
                    palavras[2] = "Rio";
                    palavras[3] = "Carros";
                    palavras[4] = "IT";
                    palavras[5] = "Bad Boys";
                    palavras[6] = "Shrek";
                    palavras[7] = "Uncharted";
                    palavras[8] = "Homem Aranha";
                    palavras[9] = "American Pie";
                    palavras[10] = "Batman";
                    palavras[11] = "Super Homem";
                    palavras[12] = "Joker";
                    palavras[13] = "A Freira";
                    palavras[14] = "Creed";
                    palavras[15] = "Harry Potter";
                    palavras[16] = "Top Gun";
                    palavras[17] = "Pantera Negra";
                    palavras[18] = "Gato Das Botas";
                    palavras[19] = "Avatar";
                    palavras[20] = "Titanic";
                    palavras[21] = "Matrix";
                    palavras[22] = "Deadpool";
                    palavras[23] = "Jurasic Park";
                    palavras[24] = "Mad Max";
                    palavras[25] = "007";
                    palavras[26] = "Terrifier";
                    palavras[27] = "Minions";
                    palavras[28] = "Jogador n1";
                    palavras[29] = "Venom";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            IniciarDicionario();
            buttonDificuldad.Visible = false;
            groupBoxDificuldade.Visible = false;
            buttonSom.Visible = false;
            buttonStart.Visible = false;
            groupBoxCarModes.Visible = false;
            pictureBoxDancinha.Visible = false;
            pictureBoxTriste.Visible = false;
            pictureBoxLobo.Visible = true;
            labelInformacaoSobreEspaco.Visible = true;
            labelInformacaoNumeros.Visible = false;

            MostrarLetras();
            string word = SelecionarPalavra();
            ApresentarPalavra(word);
            Stream sta = Properties.Resources.SomFundo;
            System.Media.SoundPlayer sv = new System.Media.SoundPlayer(sta);
            sv.PlayLooping();
        }

        private void MostrarLetras()
        {
            groupBoxTeclado.Visible = true;
            labelLetras.Visible = true;
            pictureBoxForca.Visible = true;
        }

        private string SelecionarPalavra()
        {
            Random rnd = new Random();
            int n = rnd.Next(30);
            return (palavras[n]);
        }

        private void ApresentarPalavra(string w)
        {
            int t = w.Length;
            PalEscondida = new char[t];
            for (int i = 0; i < t; i++)
                PalEscondida[i] = '-';
            string wf = new string(PalEscondida);
            labelLetras.Text = wf;
            palavra = w;
        }

        private void SomInicial()
        {
            Stream sta = Properties.Resources.SomFundo;
            System.Media.SoundPlayer sv = new System.Media.SoundPlayer(sta);
            sv.PlayLooping();

            buttonSom.BackgroundImage = Properties.Resources.iconVolume;
            soundON = true;
        }

        private void buttonSom_Click(object sender, EventArgs e)
        {
            Stream sv = Properties.Resources.SomFundo;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(sv);
            if (soundON)
            {
                sp.Stop();
                soundON = false;
                buttonSom.BackgroundImage = Properties.Resources.iconVolume2;
            }
            else
            {
                sp.PlayLooping();
                soundON = true;
                buttonSom.BackgroundImage = Properties.Resources.iconVolume;
            }
        }

        private void VerificarLetra(char c)
        {
            char[] pal = palavra.ToCharArray();
            for (int i = 0; i < palavra.Length; i++)
            {
                if (pal[i] == c)
                {
                    acertou = true;
                    PalEscondida[i] = c;
                }
            }
            string s = new string(PalEscondida);
            labelLetras.Text = s;
        }

        private void AtualizarJogo()
        {
            if (!acertou)
            {
                NumImag++;
                ApresentarImg(NumImag);
                if (NumImag == 9)
                {
                    FimDeJogo(false);
                }
            }
            else
                VerificarSeGanhou();
        }

        private void VerificarSeGanhou()
        {
            string s = new string(PalEscondida);
            if (string.Compare(s, palavra) == 0)
            {
                FimDeJogo(true);
            }
        }

        private void FimDeJogo(bool gf)
        {
            Stream st = Properties.Resources.SomFundo;
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(st);
            sp.Stop();
            soundON = false;
            groupBoxTeclado.Visible = false;
            groupBoxDificuldade.Visible = false;
            pictureBoxForca.Visible = false;
            pictureBoxPerdeu.Visible = true;
            buttonDificuldad.Visible = false;
            labelLetras.Visible = false;
            if (gf)
            {
                pictureBoxDancinha.Visible = true;
                pictureBoxGanhou.Visible = true;
                pictureBoxPerdeu.Visible = false;
                pictureBoxLobo.Visible = false;
                labelInformacaoSobreEspaco.Visible = false;
                buttonCredits.Visible = true;
                buttonRestart.Visible = true;
                buttonQuit.Visible = true;
                labelInformacaoNumeros.Visible = false;
                labelAPalEra.Visible = true;
                labelPalEscondida.Visible = true;
                labelPalEscondida.Text = palavra;
                labelPontos.Visible = true;
                labelPontoss.Visible = true;
                Stream win = Properties.Resources.GanhouSom;
                System.Media.SoundPlayer Win = new System.Media.SoundPlayer(win);
                Win.Play();
            }
            else
            {
                pictureBoxPerdeu.Visible = true;
                pictureBoxTriste.Visible = true;
                pictureBoxGanhou.Visible = false;
                pictureBoxLobo.Visible = false;
                labelInformacaoSobreEspaco.Visible = false;
                buttonCredits.Visible = true;
                buttonRestart.Visible = true;
                buttonQuit.Visible = true;
                labelInformacaoNumeros.Visible = false;
                labelAPalEra.Visible = true;
                labelPalEscondida.Visible = true;
                labelPalEscondida.Text = palavra;
                labelPontos.Visible = true;
                labelPontoss.Visible = true;
                Stream Lost = Properties.Resources.PerdeuSom;
                System.Media.SoundPlayer lost = new System.Media.SoundPlayer(Lost);
                lost.Play();
            }

            if (gf)
            {
                pontos += 5;
            }
            else 
            {
                pontos -= 5;
            }

            labelPontos.Text = pontos.ToString();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Visible = false;
            acertou = false;
            VerificarLetra('A');
            VerificarLetra('a');
            VerificarLetra('Á');
            VerificarLetra('À');
            VerificarLetra('Ã');
            VerificarLetra('á');
            VerificarLetra('à');
            VerificarLetra('ã');
            AtualizarJogo();
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonB.Visible = false;
            acertou = false;
            VerificarLetra('B');
            VerificarLetra('b');
            AtualizarJogo();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonC.Visible = false;
            acertou = false;
            VerificarLetra('C');
            VerificarLetra('c');
            VerificarLetra('ç');
            AtualizarJogo();
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonD.Visible = false;
            acertou = false;
            VerificarLetra('D');
            VerificarLetra('d');
            AtualizarJogo();
        }

        private void buttonE_Click(object sender, EventArgs e)
        {
            buttonE.Visible = false;
            acertou = false;
            VerificarLetra('E');
            VerificarLetra('É');
            VerificarLetra('e');
            VerificarLetra('é');
            AtualizarJogo();
        }

        private void buttonF_Click(object sender, EventArgs e)
        {
            buttonF.Visible = false;
            acertou = false;
            VerificarLetra('F');
            VerificarLetra('f');
            AtualizarJogo();
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            buttonG.Visible = false;
            acertou = false;
            VerificarLetra('G');
            VerificarLetra('g');
            AtualizarJogo();
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            buttonH.Visible = false;
            acertou = false;
            VerificarLetra('H');
            VerificarLetra('h');
            AtualizarJogo();
        }

        private void buttonI_Click(object sender, EventArgs e)
        {
            buttonI.Visible = false;
            acertou = false;
            VerificarLetra('I');
            VerificarLetra('Í');
            VerificarLetra('i');
            VerificarLetra('í');
            AtualizarJogo();
        }

        private void buttonJ_Click(object sender, EventArgs e)
        {
            buttonJ.Visible = false;
            acertou = false;
            VerificarLetra('J');
            VerificarLetra('j');
            AtualizarJogo();
        }

        private void buttonK_Click(object sender, EventArgs e)
        {
            buttonK.Visible = false;
            acertou = false;
            VerificarLetra('K');
            VerificarLetra('k');
            AtualizarJogo();
        }

        private void buttonL_Click(object sender, EventArgs e)
        {
            buttonL.Visible = false;
            acertou = false;
            VerificarLetra('L');
            VerificarLetra('l');
            AtualizarJogo();
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            buttonM.Visible = false;
            acertou = false;
            VerificarLetra('M');
            VerificarLetra('m');
            AtualizarJogo();
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            buttonN.Visible = false;
            acertou = false;
            VerificarLetra('N');
            VerificarLetra('n');
            AtualizarJogo();
        }

        private void buttonO_Click(object sender, EventArgs e)
        {
            buttonO.Visible = false;
            acertou = false;
            VerificarLetra('O');
            VerificarLetra('Ó');
            VerificarLetra('Õ');
            VerificarLetra('o');
            VerificarLetra('ó');
            VerificarLetra('õ');
            AtualizarJogo();
        }

        private void buttonP_Click(object sender, EventArgs e)
        {
            buttonP.Visible = false;
            acertou = false;
            VerificarLetra('P');
            VerificarLetra('p');
            AtualizarJogo();
        }

        private void buttonQ_Click(object sender, EventArgs e)
        {
            buttonQ.Visible = false;
            acertou = false;
            VerificarLetra('Q');
            VerificarLetra('q');
            AtualizarJogo();
        }

        private void buttonR_Click(object sender, EventArgs e)
        {
            buttonR.Visible = false;
            acertou = false;
            VerificarLetra('R');
            VerificarLetra('r');
            AtualizarJogo();
        }

        private void buttonS_Click(object sender, EventArgs e)
        {
            buttonS.Visible = false;
            acertou = false;
            VerificarLetra('S');
            VerificarLetra('s');
            AtualizarJogo();
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            buttonT.Visible = false;
            acertou = false;
            VerificarLetra('T');
            VerificarLetra('t');
            AtualizarJogo();
        }

        private void buttonU_Click(object sender, EventArgs e)
        {
            buttonU.Visible = false;
            acertou = false;
            VerificarLetra('U');
            VerificarLetra('Ú');
            VerificarLetra('u');
            VerificarLetra('ú');
            AtualizarJogo();

        }

        private void buttonV_Click(object sender, EventArgs e)
        {
            buttonV.Visible = false;
            acertou = false;
            VerificarLetra('V');
            VerificarLetra('v');
            AtualizarJogo();
        }

        private void buttonW_Click(object sender, EventArgs e)
        {
            buttonW.Visible = false;
            acertou = false;
            VerificarLetra('W');
            VerificarLetra('w');
            AtualizarJogo();
        }

        private void buttonX_Click(object sender, EventArgs e)
        {
            buttonX.Visible = false;
            acertou = false;
            VerificarLetra('X');
            VerificarLetra('x');
            AtualizarJogo();
        }

        private void buttonY_Click(object sender, EventArgs e)
        {
            buttonY.Visible = false;
            acertou = false;
            VerificarLetra('Y');
            VerificarLetra('y');
            AtualizarJogo();
        }

        private void buttonZ_Click(object sender, EventArgs e)
        {
            buttonZ.Visible = false;
            acertou = false;
            VerificarLetra('Z');
            VerificarLetra('z');
            AtualizarJogo();
        }

        private void buttonDificuldad_Click(object sender, EventArgs e)
        {
            groupBoxDificuldade.Visible = true;
            buttonDificuldad.Visible = false;
            labelInformacaoNumeros.Visible = true;
        }

        private void buttonFacil_Click(object sender, EventArgs e)
        {
            grau = "facil";
            buttonStart.Visible = true;
        }

        private void buttonMedio_Click(object sender, EventArgs e)
        {
            grau = "medio";
            buttonStart.Visible = true;
        }

        private void buttonDificil_Click(object sender, EventArgs e)
        {
            grau = "dificil";
            buttonStart.Visible = true;
        }

        private void buttonCarEdition_Click(object sender, EventArgs e)
        {
            groupBoxCarModes.Visible = true;
            groupBoxDificuldade.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grau = "Games";
            buttonStart.Visible = true;
        }

        private void buttonCarNormal_Click(object sender, EventArgs e)
        {
            grau = "CarNormal";
            buttonStart.Visible = true;
        }

        private void buttonBackCars_Click(object sender, EventArgs e)
        {
            groupBoxCarModes.Visible = false;
            groupBoxDificuldade.Visible = true;
        }

        private void buttonImpossibleCars_Click(object sender, EventArgs e)
        {
            grau = "CarImpossible";
            buttonStart.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEspaco_Click(object sender, EventArgs e)
        {
            buttonEspaco.Visible = false;
            acertou = false;
            labelInformacaoSobreEspaco.Visible = false;
            VerificarLetra(' ');
            AtualizarJogo();
        }

        private void buttonLigarEcraTele_Click(object sender, EventArgs e)
        {
            buttonDificuldad.Visible = true;
            buttonLigarEcraTele.Visible = false;
            label1.Visible = true;
            labelParaComecar.Visible = false;
        }

        private void buttonBackMenu_Click(object sender, EventArgs e)
        {
            buttonBackMenu.Visible = false;
            pictureBoxCredits.Visible = false;
        }

        private void buttonCredits_Click(object sender, EventArgs e)
        {
            buttonBackMenu.Visible = true;
            pictureBoxCredits.Visible = true;
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            IniciarJogo();
            buttonA.Visible = true;
            buttonB.Visible = true;
            buttonC.Visible = true;
            buttonD.Visible = true;
            buttonE.Visible = true;
            buttonF.Visible = true;
            buttonG.Visible = true;
            buttonH.Visible = true;
            buttonI.Visible = true;
            buttonJ.Visible = true;
            buttonK.Visible = true;
            buttonL.Visible = true;
            buttonM.Visible = true;
            buttonN.Visible = true;
            buttonO.Visible = true;
            buttonP.Visible = true;
            buttonQ.Visible = true;
            buttonR.Visible = true;
            buttonS.Visible = true;
            buttonT.Visible = true;
            buttonU.Visible = true;
            buttonV.Visible = true;
            buttonW.Visible = true;
            buttonX.Visible = true;
            buttonY.Visible = true;
            buttonZ.Visible = true;
            buttonEspaco.Visible = true;
            buttonZero.Visible = true;
            buttonUm.Visible = true;
            buttonDois.Visible = true;
            buttonTres.Visible = true;
            buttonQuatro.Visible = true;
            buttonCinco.Visible = true;
            buttonSeis.Visible = true;
            buttonSete.Visible = true;
            buttonOito.Visible = true;
            buttonNove.Visible = true;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            buttonStart.Visible = false;
            buttonSom.Visible = false;
            groupBoxDificuldade.Visible = false;
            buttonDificuldad.Visible = false;
            groupBoxTeclado.Visible = false;
            labelLetras.Visible = false;
            pictureBoxForca.Visible = false;
            acertou = false;
            pictureBoxPerdeu.Visible = false;
            pictureBoxGanhou.Visible = false;
            groupBoxCarModes.Visible = false;
            pictureBoxMonitor.Visible = true;
            pictureBoxDancinha.Visible = false;
            pictureBoxTriste.Visible = false;
            pictureBoxLobo.Visible = false;
            labelInformacaoSobreEspaco.Visible = false;
            label1.Visible = false;
            pictureBoxCredits.Visible = false;
            buttonBackMenu.Visible = false;
            buttonCredits.Visible = false;
            buttonRestart.Visible = false;
            buttonQuit.Visible = false;
            buttonLigarEcraTele.Visible = false;
            pictureBoxMonitor.Visible = false;
            pictureBoxTele.Visible = false;
            pictureBoxXau.Visible = true;
            labelPalEscondida.Visible = false;
            labelAPalEra.Visible = false;
            labelPontos.Visible = false;
            labelPontoss.Visible = false;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            buttonZero.Visible = false;
            acertou = false;
            VerificarLetra('0');
            AtualizarJogo();
        }

        private void buttonUm_Click(object sender, EventArgs e)
        {
            buttonUm.Visible = false;
            acertou = false;
            VerificarLetra('1');
            AtualizarJogo();
        }

        private void buttonDois_Click(object sender, EventArgs e)
        {
            buttonDois.Visible = false;
            acertou = false;
            VerificarLetra('2');
            AtualizarJogo();
        }

        private void buttonTres_Click(object sender, EventArgs e)
        {
            buttonTres.Visible = false;
            acertou = false;
            VerificarLetra('3');
            AtualizarJogo();
        }

        private void buttonQuatro_Click(object sender, EventArgs e)
        {
            buttonQuatro.Visible = false;
            acertou = false;
            VerificarLetra('4');
            AtualizarJogo();
        }

        private void buttonCinco_Click(object sender, EventArgs e)
        {
            buttonCinco.Visible = false;
            acertou = false;
            VerificarLetra('5');
            AtualizarJogo();
        }

        private void buttonSeis_Click(object sender, EventArgs e)
        {
            buttonSeis.Visible = false;
            acertou = false;
            VerificarLetra('6');
            AtualizarJogo();
        }

        private void buttonSete_Click(object sender, EventArgs e)
        {
            buttonSete.Visible = false;
            acertou = false;
            VerificarLetra('7');
            AtualizarJogo();
        }

        private void buttonOito_Click(object sender, EventArgs e)
        {
            buttonOito.Visible = false;
            acertou = false;
            VerificarLetra('8');
            AtualizarJogo();
        }

        private void buttonNove_Click(object sender, EventArgs e)
        {
            buttonNove.Visible = false;
            acertou = false;
            VerificarLetra('9');
            AtualizarJogo();
        }

        private void buttonComecar_Click(object sender, EventArgs e)
        {
            IniciarJogo();
            pictureBoxFundoMenu.Visible = false;
            labelTitulo.Visible = false;
            pictureBoxForcaDoMenu.Visible = false;
            buttonComecar.Visible = false;
            buttonDefinicoes.Visible = false;
        }

        private void buttonDificuldadeFilmes_Click(object sender, EventArgs e)
        {
            grau = "Films";
            buttonStart.Visible = true;
        }

        private void buttonDefinicoes_Click(object sender, EventArgs e)
        {
            groupBoxSettings.Visible = true;
            buttonDefinicoes.Visible = false;
            buttonComecar.Visible = false;
            buttonSom.Visible = true;
        }

        private void buttonVoltarMenu_Click(object sender, EventArgs e)
        {
            groupBoxSettings.Visible = false;
            buttonDefinicoes.Visible = true;
            buttonComecar.Visible = true;
            buttonSom.Visible = false;
        }

        private void pictureBoxTriste_Click(object sender, EventArgs e)
        {

        }
    }
}