using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Numerics;


namespace BoomWords
{
    public partial class Game : Form
    {
        bool host = false;
        string username;
        string gamename;
        Socket userSocket;
        string start;
        List<Label> userLabels = new List<Label>(); // Agregamos una lista de Labels para los usuarios
        int totalPlayers = 0;
        public bool end = false;
        public Game(string user_name, string game_name, Socket userSocket)
        {
            InitializeComponent();
            this.username = user_name;
            this.gamename = game_name;
            this.userSocket = userSocket;
            ExplosionPictureBox.Visible = false;
            ExplosionTimer.Interval = 1000;
            ExplosionTimer.Tick += ExplosionTimer_Tick;
        }
        private void ExplosionTimer_Tick(object sender, EventArgs e)
        {
            ExplosionPictureBox.Visible = false;
            ExplosionTimer.Stop();
        }


        private void Game_Load(object sender, EventArgs e)
        {
            this.UsernameLabel.Text = this.username;
            this.GamenameLabel.Text = this.gamename;
            if (host)
            {
                InviteButton.Visible = true;    
            }
                
            string mensaje = $"Game/{gamename}/Join";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);

            userSocket.Send(msg);
        }
       

        public void DeclareHost()
        { 
            this.host = true;   
        }

        private void DistribuirUsuarios()
        {
            int centerX = (this.ClientSize.Width / 2)-30;
            int centerY = this.ClientSize.Height / 2;
            int radio = 130;


            foreach (var label in userLabels)
            {
                this.Controls.Remove(label);
            }
            userLabels.Clear();

            foreach (Control control in this.Controls.OfType<PictureBox>().Where(p => p.Tag?.ToString() == "Vidas").ToList())
            {
                this.Controls.Remove(control);                     //Esto es para poner el picturebox con el png de el corazón
            }

            int numUsuarios = PlayersGrid.Rows.Count;

            for (int i = 0; i < totalPlayers; i++)
            {
                string vidas = PlayersGrid.Rows[i].Cells["Lives"].Value.ToString(); //obtenemos vidas
                string nombreUsuario = PlayersGrid.Rows[i].Cells["User"].Value.ToString(); //obtenemos nombre usuario desde player grid


                double angle = (360.0 / totalPlayers) * i;
                double radians = (angle + 90) * (Math.PI / 180);
                int userX = (int)(centerX + radio * Math.Cos(radians)) - 20;
                int userY = (int)(centerY + radio * Math.Sin(radians)) - 10;

                //LABEL USUARIO
                Label userLabel = new Label();
                userLabel.Text = nombreUsuario;
                userLabel.AutoSize = true;
                userLabel.TextAlign = ContentAlignment.MiddleCenter;
                userLabel.Location = new Point(userX, userY);
                userLabel.BackColor = Color.Black;            // Fondo negro
                userLabel.ForeColor = Color.White;            // Texto blanco   //    PARA CAMBIAR CUALQUIER COSA DE LAS LABEL HACERLO DESDE AQUI
                userLabel.Font = new Font("Rockwell", 10, FontStyle.Regular); // Fuente Rockwell

                //IMAGEN VIDAS
                PictureBox heartIcon = new PictureBox();
                heartIcon.Image = Properties.Resources.vida; // Accede al recurso con el nombre de la foto
                heartIcon.SizeMode = PictureBoxSizeMode.StretchImage;
                heartIcon.Size = new Size(30, 30);
                heartIcon.Location = new Point(userX + userLabel.Width -55, userY -6);
                heartIcon.Tag = "vida"; // Etiqueta para identificarlos y eliminarlos más fácilmente


                // CREAS LABEL VIDAS
                Label vidasLabel = new Label();
                vidasLabel.Text = vidas;
                vidasLabel.AutoSize = true;
                vidasLabel.TextAlign = ContentAlignment.MiddleLeft;
                vidasLabel.Font = new Font("Rockwell", 10, FontStyle.Bold);
                vidasLabel.ForeColor = Color.Black;
                vidasLabel.Location = new Point(heartIcon.Right +5, userY);

                //AÑADES TODO LO ANTERIOR
                this.Controls.Add(userLabel);
                userLabels.Add(userLabel);
                this.Controls.Add(heartIcon);
                this.Controls.Add(vidasLabel);
                userLabels.Add(vidasLabel);
            }
        }

        public void GameResponses(string userResponse)
        {
            string[] gameResponse = userResponse.Split('/');
            switch (gameResponse[0])
            {
                case "Start":
                    this.Invoke(new Action(() =>
                    {
                        this.StartButton.Visible = false;
                        this.InviteButton.Visible = false;
                        this.LeaveButton.Visible = false;
                        foreach (DataGridViewRow row in PlayersGrid.Rows)
                        {
                            row.Cells["Lives"].Value = Convert.ToInt32(gameResponse[1]);
                        }
                        RunDelay.Start();
                    }));
                    break;

                case "Turn":
                    string user_turn = gameResponse[1];
                    string syllable = gameResponse[2];

                    this.Invoke(new Action(() =>
                    {
                        WordBox.BackColor = Color.White;
                        WordBox.ForeColor = Color.Black;
                        WordBox.Text = "";
                        this.TurnLabel.Text = user_turn;
                        this.SyllableLabel.Text = syllable;
                        if (user_turn == this.username)
                        {
                            WordBox.Enabled = true;
                            WordBox.Focus();
                        }
                        else
                        {
                            WordBox.Enabled = false;
                        }
                    }));
                    break;
                case "Word":
                    this.Invoke(new Action(() =>
                    {
                        WordBox.Text = gameResponse[1];
                        if (TurnLabel.Text == this.username)
                        {
                            if (gameResponse[2][0] == '1')
                            {
                                WordBox.BackColor = Color.Green;
                            }
                            else
                            {
                                WordBox.BackColor = Color.Red;
                            }

                        }
                        else
                        {
                            if (gameResponse[2][0] == '1')
                            {
                                WordBox.ForeColor = Color.Green;
                            }
                            else
                            {
                                WordBox.ForeColor = Color.Red;
                            }
                        }
                    }));
                    break;

                case "Boom":
                    this.Invoke(new Action(() =>
                    {
                        foreach (DataGridViewRow row in PlayersGrid.Rows)
                        {
                            
                            if (row.Cells["User"].Value.ToString() == gameResponse[1])
                            {
                                row.Cells["lives"].Value = Convert.ToInt32(row.Cells["lives"].Value)-1;
                                break;
                            }
                        }
                        if (host)
                        {
                            RunDelay.Start();
                        }
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.ExplosionBomba);
                        player.Play();

                        ExplosionPictureBox.Visible = true;
                        ExplosionTimer.Start();
                        
                    }));
                        
                    break;

                case "Win":
                    BoomTimer.Stop();
                    MessageBox.Show($"Winner: {gameResponse[1]}");
                    Close();
                    break;

                case "Load":
                    this.Invoke(new Action(() =>
                    {
                        PlayersGrid.Rows.Clear();
                        var Players = gameResponse[1].Split('|')
                            .Select(t => t.Trim())
                            .Select(t =>
                            {
                                var part = t.Split(',');
                                return new { name = part[0], lives = int.Parse(part[1]) };
                            })
                            .ToList();
                        totalPlayers = Players.Count;

                        foreach (var player in Players)
                        {
                            PlayersGrid.Rows.Add(player.name, player.lives);
                        }
                        DistribuirUsuarios();
                        LeaveButton.Visible = true;
                        if (host)
                        {
                            InviteButton.Enabled = true;
                            if (totalPlayers >= 2)
                                StartButton.Visible = true;
                            else
                                StartButton.Visible = false;
                        }
                        
                    }));
                    break;
                case "Update":
                    
                    break;

                case "Invite":
                    this.Invoke(new Action(() =>
                    {
                        InviteGrid.Rows.Clear();
                        var InviteBoard = gameResponse[1].Split('|')
                            .Select(t => t.Trim())
                            .Select(t =>
                            {
                                return new { name = t };
                            })
                            .Where(user => user != null)
                            .ToList();

                        foreach (var user in InviteBoard)
                        {
                            InviteGrid.Rows.Add(user.name);
                        }

                        
                    }));
                    InviteGrid.ClearSelection();
                    break;

                case "End":
                    end = true;
                    this.Invoke(new Action(() =>
                    {
                        Close();
                    }));
                    break;

            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            string mensaje = $"Game/{gamename}/Start";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            userSocket.Send(msg);
        }

        private void RunDelay_Tick(object sender, EventArgs e)
        {
            RunDelay.Stop();
            List<string> startCountDown = new List<string> { "3", "2", "1", "GO!" };
            int position = startCountDown.IndexOf(StartLabel.Text);
            
            if (position == -1)
            {
                StartLabel.Text = startCountDown[0];
                RunDelay.Start();
            }
            else if (position == 3)
            {
                StartLabel.Text = "";
            }
            else
            {
                StartLabel.Text = startCountDown[position + 1];
                RunDelay.Start();
                if (position == 2 && host)
                {
                    string mensaje = $"Game/{gamename}/Run";
                    // Enviamos al servidor el nombre tecleado
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    userSocket.Send(msg);
                    BoomTimer.Start();
                }
            }
        }

        private void BoomTimer_Tick(object sender, EventArgs e)
        {
            BoomTimer.Stop();
            string mensaje = $"Game/{gamename}/Boom";
            // Enviamos al servidor el nombre tecleado
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);

            userSocket.Send(msg);
        }
        private void CheckWord(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                string mensaje = $"Game/{gamename}/Word/{WordBox.Text}";
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                userSocket.Send(msg);
            }
        }

        private void LeaveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InviteButton_Click(object sender, EventArgs e)
        {
            StartButton.Visible = false;
            InviteButton.Visible = false;
            string mensaje = $"Game/{gamename}/Invite";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            userSocket.Send(msg);
            InviteGrid.ClearSelection();
            InviteGrid.Visible = true;
            BackInvitationButton.Visible = true;
        }

        private void InviteGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            SendInvitationButton.Visible = true;
        }

        private void BackInvitationButton_Click(object sender, EventArgs e)
        {
            StartButton.Visible = true; 
            InviteButton.Visible = true;
            InviteGrid.Visible = false;
            SendInvitationButton.Visible = false;
            BackInvitationButton.Visible = false;
        }

        private void SendInvitationButton_Click(object sender, EventArgs e)
        {
            string invitedUser = InviteGrid.SelectedRows[0].Cells["InvitedUsers"].Value.ToString();
            string mensaje = $"Game/{gamename}/Invite/{invitedUser}";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            userSocket.Send(msg);
            InviteGrid.ClearSelection();
            SendInvitationButton.Visible = false;
        }
    }
}
