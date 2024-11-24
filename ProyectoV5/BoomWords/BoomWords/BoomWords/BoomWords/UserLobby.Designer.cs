namespace BoomWords
{
    partial class UserLobby
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EnterGameButton = new System.Windows.Forms.Button();
            this.GamenameBox = new System.Windows.Forms.MaskedTextBox();
            this.PasswordBox = new System.Windows.Forms.MaskedTextBox();
            this.GameNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.GameEnterLabel = new System.Windows.Forms.Label();
            this.UserStatsBox = new System.Windows.Forms.PictureBox();
            this.GameBox = new System.Windows.Forms.PictureBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.GamesGrid = new System.Windows.Forms.DataGridView();
            this.Game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Players = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.RejectInvitationButton = new System.Windows.Forms.Button();
            this.AcceptInvitationButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserStatsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterGameButton
            // 
            this.EnterGameButton.BackColor = System.Drawing.Color.Black;
            this.EnterGameButton.FlatAppearance.BorderSize = 0;
            this.EnterGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnterGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnterGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterGameButton.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.EnterGameButton.ForeColor = System.Drawing.Color.White;
            this.EnterGameButton.Location = new System.Drawing.Point(216, 425);
            this.EnterGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterGameButton.Name = "EnterGameButton";
            this.EnterGameButton.Size = new System.Drawing.Size(209, 48);
            this.EnterGameButton.TabIndex = 41;
            this.EnterGameButton.Text = "Create";
            this.EnterGameButton.UseVisualStyleBackColor = false;
            this.EnterGameButton.Click += new System.EventHandler(this.EnterGameButton_Click);
            // 
            // GamenameBox
            // 
            this.GamenameBox.AsciiOnly = true;
            this.GamenameBox.BackColor = System.Drawing.Color.White;
            this.GamenameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GamenameBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GamenameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.GamenameBox.Location = new System.Drawing.Point(73, 313);
            this.GamenameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GamenameBox.Name = "GamenameBox";
            this.GamenameBox.Size = new System.Drawing.Size(251, 24);
            this.GamenameBox.TabIndex = 44;
            this.GamenameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordBox
            // 
            this.PasswordBox.AsciiOnly = true;
            this.PasswordBox.BackColor = System.Drawing.Color.White;
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Rockwell", 12F);
            this.PasswordBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.PasswordBox.Location = new System.Drawing.Point(73, 390);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(251, 24);
            this.PasswordBox.TabIndex = 45;
            this.PasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameNameLabel
            // 
            this.GameNameLabel.AutoSize = true;
            this.GameNameLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.GameNameLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameNameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameNameLabel.Location = new System.Drawing.Point(65, 282);
            this.GameNameLabel.Name = "GameNameLabel";
            this.GameNameLabel.Size = new System.Drawing.Size(68, 24);
            this.GameNameLabel.TabIndex = 48;
            this.GameNameLabel.Text = "Name";
            this.GameNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.PasswordLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Location = new System.Drawing.Point(67, 358);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 24);
            this.PasswordLabel.TabIndex = 49;
            this.PasswordLabel.Text = "Password";
            // 
            // GameEnterLabel
            // 
            this.GameEnterLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.GameEnterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameEnterLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.GameEnterLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GameEnterLabel.Location = new System.Drawing.Point(56, 225);
            this.GameEnterLabel.Name = "GameEnterLabel";
            this.GameEnterLabel.Size = new System.Drawing.Size(285, 40);
            this.GameEnterLabel.TabIndex = 52;
            this.GameEnterLabel.Text = "CREATE GAME";
            this.GameEnterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserStatsBox
            // 
            this.UserStatsBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserStatsBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.UserStatsBox.Location = new System.Drawing.Point(44, 37);
            this.UserStatsBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserStatsBox.Name = "UserStatsBox";
            this.UserStatsBox.Size = new System.Drawing.Size(394, 173);
            this.UserStatsBox.TabIndex = 53;
            this.UserStatsBox.TabStop = false;
            // 
            // GameBox
            // 
            this.GameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.GameBox.Location = new System.Drawing.Point(44, 249);
            this.GameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(394, 204);
            this.GameBox.TabIndex = 51;
            this.GameBox.TabStop = false;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.UsernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameLabel.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UsernameLabel.Location = new System.Drawing.Point(56, 26);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(285, 40);
            this.UsernameLabel.TabIndex = 54;
            this.UsernameLabel.Text = "User";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.Maroon;
            this.LogOutButton.FlatAppearance.BorderSize = 0;
            this.LogOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.LogOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.LogOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOutButton.Location = new System.Drawing.Point(15, 505);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(175, 36);
            this.LogOutButton.TabIndex = 55;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click_1);
            // 
            // GamesGrid
            // 
            this.GamesGrid.AllowUserToAddRows = false;
            this.GamesGrid.AllowUserToDeleteRows = false;
            this.GamesGrid.AllowUserToResizeColumns = false;
            this.GamesGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Rockwell", 12F);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GamesGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.GamesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GamesGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.GamesGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GamesGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GamesGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.GamesGrid.ColumnHeadersHeight = 29;
            this.GamesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GamesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Game,
            this.Players,
            this.State});
            this.GamesGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GamesGrid.DefaultCellStyle = dataGridViewCellStyle23;
            this.GamesGrid.EnableHeadersVisualStyles = false;
            this.GamesGrid.Location = new System.Drawing.Point(532, 26);
            this.GamesGrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GamesGrid.MultiSelect = false;
            this.GamesGrid.Name = "GamesGrid";
            this.GamesGrid.ReadOnly = true;
            this.GamesGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GamesGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.GamesGrid.RowHeadersVisible = false;
            this.GamesGrid.RowHeadersWidth = 51;
            this.GamesGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Rockwell", 12F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.White;
            this.GamesGrid.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.GamesGrid.RowTemplate.Height = 24;
            this.GamesGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.GamesGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GamesGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GamesGrid.ShowCellErrors = false;
            this.GamesGrid.ShowCellToolTips = false;
            this.GamesGrid.ShowEditingIcon = false;
            this.GamesGrid.ShowRowErrors = false;
            this.GamesGrid.Size = new System.Drawing.Size(340, 233);
            this.GamesGrid.TabIndex = 56;
            this.GamesGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GamesGrid_CellClick);
            // 
            // Game
            // 
            this.Game.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Game.FillWeight = 45F;
            this.Game.HeaderText = "Game";
            this.Game.MinimumWidth = 6;
            this.Game.Name = "Game";
            this.Game.ReadOnly = true;
            this.Game.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Game.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Players
            // 
            this.Players.FillWeight = 20F;
            this.Players.HeaderText = "";
            this.Players.MinimumWidth = 6;
            this.Players.Name = "Players";
            this.Players.ReadOnly = true;
            // 
            // State
            // 
            this.State.FillWeight = 35F;
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.State.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Black;
            this.BackButton.FlatAppearance.BorderSize = 0;
            this.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.BackButton.ForeColor = System.Drawing.Color.White;
            this.BackButton.Location = new System.Drawing.Point(29, 425);
            this.BackButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(53, 48);
            this.BackButton.TabIndex = 57;
            this.BackButton.Text = "◀️";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Visible = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RejectInvitationButton
            // 
            this.RejectInvitationButton.BackColor = System.Drawing.Color.Black;
            this.RejectInvitationButton.FlatAppearance.BorderSize = 0;
            this.RejectInvitationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RejectInvitationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RejectInvitationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RejectInvitationButton.Font = new System.Drawing.Font("Rockwell", 16F, System.Drawing.FontStyle.Bold);
            this.RejectInvitationButton.ForeColor = System.Drawing.Color.White;
            this.RejectInvitationButton.Location = new System.Drawing.Point(290, 425);
            this.RejectInvitationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RejectInvitationButton.Name = "RejectInvitationButton";
            this.RejectInvitationButton.Size = new System.Drawing.Size(60, 48);
            this.RejectInvitationButton.TabIndex = 58;
            this.RejectInvitationButton.Text = "❌";
            this.RejectInvitationButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.RejectInvitationButton.UseVisualStyleBackColor = false;
            this.RejectInvitationButton.Visible = false;
            this.RejectInvitationButton.Click += new System.EventHandler(this.RejectInvitationButton_Click);
            // 
            // AcceptInvitationButton
            // 
            this.AcceptInvitationButton.BackColor = System.Drawing.Color.Black;
            this.AcceptInvitationButton.FlatAppearance.BorderSize = 0;
            this.AcceptInvitationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AcceptInvitationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AcceptInvitationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AcceptInvitationButton.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold);
            this.AcceptInvitationButton.ForeColor = System.Drawing.Color.White;
            this.AcceptInvitationButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AcceptInvitationButton.Location = new System.Drawing.Point(365, 425);
            this.AcceptInvitationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AcceptInvitationButton.Name = "AcceptInvitationButton";
            this.AcceptInvitationButton.Size = new System.Drawing.Size(60, 48);
            this.AcceptInvitationButton.TabIndex = 59;
            this.AcceptInvitationButton.Text = "✔️";
            this.AcceptInvitationButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AcceptInvitationButton.UseVisualStyleBackColor = false;
            this.AcceptInvitationButton.Visible = false;
            this.AcceptInvitationButton.Click += new System.EventHandler(this.AcceptInvitationButton_Click);
            // 
            // UserLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BoomWords.Properties.Resources.fondo_letras;
            this.ClientSize = new System.Drawing.Size(963, 554);
            this.Controls.Add(this.EnterGameButton);
            this.Controls.Add(this.AcceptInvitationButton);
            this.Controls.Add(this.RejectInvitationButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.GamesGrid);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.GameEnterLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.GameNameLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.GamenameBox);
            this.Controls.Add(this.GameBox);
            this.Controls.Add(this.UserStatsBox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "UserLobby";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserLobby_Closed);
            this.Load += new System.EventHandler(this.UserLobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserStatsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GamesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button EnterGameButton;
        private System.Windows.Forms.MaskedTextBox GamenameBox;
        private System.Windows.Forms.MaskedTextBox PasswordBox;
        private System.Windows.Forms.Label GameNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label GameEnterLabel;
        private System.Windows.Forms.PictureBox UserStatsBox;
        private System.Windows.Forms.PictureBox GameBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.DataGridView GamesGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Game;
        private System.Windows.Forms.DataGridViewTextBoxColumn Players;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button RejectInvitationButton;
        private System.Windows.Forms.Button AcceptInvitationButton;
    }
}