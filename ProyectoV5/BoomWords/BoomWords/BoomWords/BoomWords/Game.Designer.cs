namespace BoomWords
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GameLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.GamenameLabel = new System.Windows.Forms.Label();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.SyllableLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TurnAttemptLabel = new System.Windows.Forms.Label();
            this.PlayersGrid = new System.Windows.Forms.DataGridView();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lives = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WordBox = new System.Windows.Forms.TextBox();
            this.BoomTimer = new System.Windows.Forms.Timer(this.components);
            this.RunDelay = new System.Windows.Forms.Timer(this.components);
            this.BoomBox = new System.Windows.Forms.PictureBox();
            this.ExplosionPictureBox = new System.Windows.Forms.PictureBox();
            this.ExplosionTimer = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.LeaveButton = new System.Windows.Forms.Button();
            this.InviteButton = new System.Windows.Forms.Button();
            this.StartLabel = new System.Windows.Forms.Label();
            this.InviteGrid = new System.Windows.Forms.DataGridView();
            this.InvitedUsers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendInvitationButton = new System.Windows.Forms.Button();
            this.BackInvitationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoomBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InviteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameLabel.Font = new System.Drawing.Font("Rockwell", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLabel.Location = new System.Drawing.Point(362, 9);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(371, 57);
            this.GameLabel.TabIndex = 0;
            this.GameLabel.Text = "BOOMWORDS";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLabel.Font = new System.Drawing.Font("Rockwell", 15F);
            this.UsernameLabel.Location = new System.Drawing.Point(420, 473);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(192, 32);
            this.UsernameLabel.TabIndex = 24;
            this.UsernameLabel.Text = "User";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // GamenameLabel
            // 
            this.GamenameLabel.BackColor = System.Drawing.Color.Transparent;
            this.GamenameLabel.Font = new System.Drawing.Font("Rockwell", 15F);
            this.GamenameLabel.Location = new System.Drawing.Point(833, 25);
            this.GamenameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GamenameLabel.Name = "GamenameLabel";
            this.GamenameLabel.Size = new System.Drawing.Size(195, 32);
            this.GamenameLabel.TabIndex = 25;
            this.GamenameLabel.Text = "GameName";
            this.GamenameLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TurnLabel
            // 
            this.TurnLabel.BackColor = System.Drawing.Color.Transparent;
            this.TurnLabel.Font = new System.Drawing.Font("Rockwell", 15F);
            this.TurnLabel.Location = new System.Drawing.Point(859, 460);
            this.TurnLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(195, 32);
            this.TurnLabel.TabIndex = 26;
            this.TurnLabel.Text = "Turn";
            this.TurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SyllableLabel
            // 
            this.SyllableLabel.BackColor = System.Drawing.Color.Transparent;
            this.SyllableLabel.Font = new System.Drawing.Font("Rockwell", 15F);
            this.SyllableLabel.Location = new System.Drawing.Point(860, 492);
            this.SyllableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SyllableLabel.Name = "SyllableLabel";
            this.SyllableLabel.Size = new System.Drawing.Size(195, 32);
            this.SyllableLabel.TabIndex = 27;
            this.SyllableLabel.Text = "Syllable";
            this.SyllableLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 15F);
            this.label1.Location = new System.Drawing.Point(725, 460);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 32);
            this.label1.TabIndex = 28;
            this.label1.Text = "Turno:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 15F);
            this.label2.Location = new System.Drawing.Point(721, 492);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 32);
            this.label2.TabIndex = 29;
            this.label2.Text = "Syllable:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TurnAttemptLabel
            // 
            this.TurnAttemptLabel.BackColor = System.Drawing.Color.Transparent;
            this.TurnAttemptLabel.Font = new System.Drawing.Font("Rockwell", 15F);
            this.TurnAttemptLabel.Location = new System.Drawing.Point(201, 505);
            this.TurnAttemptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TurnAttemptLabel.Name = "TurnAttemptLabel";
            this.TurnAttemptLabel.Size = new System.Drawing.Size(195, 32);
            this.TurnAttemptLabel.TabIndex = 30;
            this.TurnAttemptLabel.Text = "Attempt";
            this.TurnAttemptLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // PlayersGrid
            // 
            this.PlayersGrid.ColumnHeadersHeight = 29;
            this.PlayersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.User,
            this.Lives});
            this.PlayersGrid.Location = new System.Drawing.Point(801, 59);
            this.PlayersGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayersGrid.Name = "PlayersGrid";
            this.PlayersGrid.RowHeadersVisible = false;
            this.PlayersGrid.RowHeadersWidth = 51;
            this.PlayersGrid.RowTemplate.Height = 24;
            this.PlayersGrid.Size = new System.Drawing.Size(253, 236);
            this.PlayersGrid.TabIndex = 31;
            // 
            // User
            // 
            this.User.HeaderText = "Username";
            this.User.MinimumWidth = 6;
            this.User.Name = "User";
            this.User.Width = 125;
            // 
            // Lives
            // 
            this.Lives.HeaderText = "Lives";
            this.Lives.MinimumWidth = 6;
            this.Lives.Name = "Lives";
            this.Lives.Width = 125;
            // 
            // WordBox
            // 
            this.WordBox.Enabled = false;
            this.WordBox.Font = new System.Drawing.Font("Rockwell", 9.75F);
            this.WordBox.ForeColor = System.Drawing.Color.Black;
            this.WordBox.Location = new System.Drawing.Point(388, 510);
            this.WordBox.Margin = new System.Windows.Forms.Padding(5);
            this.WordBox.Name = "WordBox";
            this.WordBox.Size = new System.Drawing.Size(249, 27);
            this.WordBox.TabIndex = 33;
            this.WordBox.TabStop = false;
            this.WordBox.Text = "Word";
            this.WordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckWord);
            // 
            // BoomTimer
            // 
            this.BoomTimer.Interval = 20000;
            this.BoomTimer.Tick += new System.EventHandler(this.BoomTimer_Tick);
            // 
            // RunDelay
            // 
            this.RunDelay.Interval = 1000;
            this.RunDelay.Tick += new System.EventHandler(this.RunDelay_Tick);
            // 
            // BoomBox
            // 
            this.BoomBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoomBox.BackColor = System.Drawing.Color.Transparent;
            this.BoomBox.Image = global::BoomWords.Properties.Resources.bomba;
            this.BoomBox.Location = new System.Drawing.Point(460, 237);
            this.BoomBox.Name = "BoomBox";
            this.BoomBox.Size = new System.Drawing.Size(116, 92);
            this.BoomBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BoomBox.TabIndex = 34;
            this.BoomBox.TabStop = false;
            // 
            // ExplosionPictureBox
            // 
            this.ExplosionPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExplosionPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.ExplosionPictureBox.Image = global::BoomWords.Properties.Resources.explosion;
            this.ExplosionPictureBox.Location = new System.Drawing.Point(460, 237);
            this.ExplosionPictureBox.Name = "ExplosionPictureBox";
            this.ExplosionPictureBox.Size = new System.Drawing.Size(116, 92);
            this.ExplosionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExplosionPictureBox.TabIndex = 39;
            this.ExplosionPictureBox.TabStop = false;
            // 
            // ExplosionTimer
            // 
            this.ExplosionTimer.Interval = 1000;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.Black;
            this.StartButton.FlatAppearance.BorderSize = 0;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(31, 48);
            this.StartButton.Margin = new System.Windows.Forms.Padding(2);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(157, 39);
            this.StartButton.TabIndex = 59;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LeaveButton
            // 
            this.LeaveButton.BackColor = System.Drawing.Color.Maroon;
            this.LeaveButton.FlatAppearance.BorderSize = 0;
            this.LeaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.LeaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.LeaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LeaveButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.LeaveButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LeaveButton.Location = new System.Drawing.Point(18, 505);
            this.LeaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(131, 29);
            this.LeaveButton.TabIndex = 60;
            this.LeaveButton.Text = "Leave";
            this.LeaveButton.UseVisualStyleBackColor = false;
            this.LeaveButton.Click += new System.EventHandler(this.LeaveButton_Click);
            // 
            // InviteButton
            // 
            this.InviteButton.BackColor = System.Drawing.Color.Black;
            this.InviteButton.FlatAppearance.BorderSize = 0;
            this.InviteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InviteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InviteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InviteButton.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.InviteButton.ForeColor = System.Drawing.Color.White;
            this.InviteButton.Location = new System.Drawing.Point(31, 101);
            this.InviteButton.Margin = new System.Windows.Forms.Padding(2);
            this.InviteButton.Name = "InviteButton";
            this.InviteButton.Size = new System.Drawing.Size(157, 39);
            this.InviteButton.TabIndex = 61;
            this.InviteButton.Text = "Invite";
            this.InviteButton.UseVisualStyleBackColor = false;
            this.InviteButton.Visible = false;
            this.InviteButton.Click += new System.EventHandler(this.InviteButton_Click);
            // 
            // StartLabel
            // 
            this.StartLabel.BackColor = System.Drawing.Color.Transparent;
            this.StartLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.StartLabel.Location = new System.Drawing.Point(482, 175);
            this.StartLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(71, 59);
            this.StartLabel.TabIndex = 62;
            this.StartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InviteGrid
            // 
            this.InviteGrid.AllowUserToAddRows = false;
            this.InviteGrid.AllowUserToDeleteRows = false;
            this.InviteGrid.AllowUserToResizeColumns = false;
            this.InviteGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Rockwell", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InviteGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.InviteGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.InviteGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.InviteGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.InviteGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InviteGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.InviteGrid.ColumnHeadersHeight = 29;
            this.InviteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.InviteGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvitedUsers});
            this.InviteGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.InviteGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.InviteGrid.EnableHeadersVisualStyles = false;
            this.InviteGrid.Location = new System.Drawing.Point(31, 101);
            this.InviteGrid.MultiSelect = false;
            this.InviteGrid.Name = "InviteGrid";
            this.InviteGrid.ReadOnly = true;
            this.InviteGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.InviteGrid.RowHeadersVisible = false;
            this.InviteGrid.RowHeadersWidth = 51;
            this.InviteGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Rockwell", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.InviteGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.InviteGrid.RowTemplate.Height = 24;
            this.InviteGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InviteGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InviteGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InviteGrid.ShowCellErrors = false;
            this.InviteGrid.ShowCellToolTips = false;
            this.InviteGrid.ShowEditingIcon = false;
            this.InviteGrid.ShowRowErrors = false;
            this.InviteGrid.Size = new System.Drawing.Size(157, 189);
            this.InviteGrid.TabIndex = 63;
            this.InviteGrid.Visible = false;
            this.InviteGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.InviteGrid_CellClick);
            // 
            // InvitedUsers
            // 
            this.InvitedUsers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.InvitedUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.InvitedUsers.FillWeight = 30F;
            this.InvitedUsers.HeaderText = "Invite Users";
            this.InvitedUsers.MinimumWidth = 2;
            this.InvitedUsers.Name = "InvitedUsers";
            this.InvitedUsers.ReadOnly = true;
            this.InvitedUsers.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.InvitedUsers.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SendInvitationButton
            // 
            this.SendInvitationButton.BackColor = System.Drawing.Color.Black;
            this.SendInvitationButton.FlatAppearance.BorderSize = 0;
            this.SendInvitationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendInvitationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SendInvitationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendInvitationButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.SendInvitationButton.ForeColor = System.Drawing.Color.White;
            this.SendInvitationButton.Location = new System.Drawing.Point(101, 274);
            this.SendInvitationButton.Margin = new System.Windows.Forms.Padding(2);
            this.SendInvitationButton.Name = "SendInvitationButton";
            this.SendInvitationButton.Size = new System.Drawing.Size(77, 31);
            this.SendInvitationButton.TabIndex = 64;
            this.SendInvitationButton.Text = "Send Invitation";
            this.SendInvitationButton.UseVisualStyleBackColor = false;
            this.SendInvitationButton.Visible = false;
            this.SendInvitationButton.Click += new System.EventHandler(this.SendInvitationButton_Click);
            // 
            // BackInvitationButton
            // 
            this.BackInvitationButton.BackColor = System.Drawing.Color.Black;
            this.BackInvitationButton.FlatAppearance.BorderSize = 0;
            this.BackInvitationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackInvitationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackInvitationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackInvitationButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.BackInvitationButton.ForeColor = System.Drawing.Color.White;
            this.BackInvitationButton.Location = new System.Drawing.Point(19, 274);
            this.BackInvitationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackInvitationButton.Name = "BackInvitationButton";
            this.BackInvitationButton.Size = new System.Drawing.Size(36, 31);
            this.BackInvitationButton.TabIndex = 65;
            this.BackInvitationButton.Text = "◀️";
            this.BackInvitationButton.UseVisualStyleBackColor = false;
            this.BackInvitationButton.Visible = false;
            this.BackInvitationButton.Click += new System.EventHandler(this.BackInvitationButton_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BoomWords.Properties.Resources.fondo_letras;
            this.ClientSize = new System.Drawing.Size(1097, 565);
            this.ControlBox = false;
            this.Controls.Add(this.BackInvitationButton);
            this.Controls.Add(this.SendInvitationButton);
            this.Controls.Add(this.StartLabel);
            this.Controls.Add(this.InviteButton);
            this.Controls.Add(this.LeaveButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExplosionPictureBox);
            this.Controls.Add(this.BoomBox);
            this.Controls.Add(this.WordBox);
            this.Controls.Add(this.PlayersGrid);
            this.Controls.Add(this.TurnAttemptLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SyllableLabel);
            this.Controls.Add(this.TurnLabel);
            this.Controls.Add(this.GamenameLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.InviteGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlayersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoomBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExplosionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InviteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label GamenameLabel;
        private System.Windows.Forms.Label TurnLabel;
        private System.Windows.Forms.Label SyllableLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TurnAttemptLabel;
        private System.Windows.Forms.DataGridView PlayersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lives;
        private System.Windows.Forms.TextBox WordBox;
        private System.Windows.Forms.Timer BoomTimer;
        private System.Windows.Forms.Timer RunDelay;
        private System.Windows.Forms.PictureBox BoomBox;
        private System.Windows.Forms.PictureBox ExplosionPictureBox;
        private System.Windows.Forms.Timer ExplosionTimer;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button LeaveButton;
        private System.Windows.Forms.Button InviteButton;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.DataGridView InviteGrid;
        private System.Windows.Forms.Button SendInvitationButton;
        private System.Windows.Forms.Button BackInvitationButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvitedUsers;
    }
}