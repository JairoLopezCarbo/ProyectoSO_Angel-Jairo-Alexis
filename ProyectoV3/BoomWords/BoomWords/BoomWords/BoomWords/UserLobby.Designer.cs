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
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BoomWordsLabel = new System.Windows.Forms.Label();
            this.JoinButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.JoinGamenameBox = new System.Windows.Forms.MaskedTextBox();
            this.JoinPasswordBox = new System.Windows.Forms.MaskedTextBox();
            this.CreateGamenameBox = new System.Windows.Forms.MaskedTextBox();
            this.CreatePasswordBox = new System.Windows.Forms.MaskedTextBox();
            this.GameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.UsernameLabel.Font = new System.Drawing.Font("Rockwell", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsernameLabel.Location = new System.Drawing.Point(48, 46);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(65, 29);
            this.UsernameLabel.TabIndex = 23;
            this.UsernameLabel.Text = "User";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.LogOutButton.Font = new System.Drawing.Font("Rockwell", 12F);
            this.LogOutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LogOutButton.Location = new System.Drawing.Point(864, 481);
            this.LogOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(187, 58);
            this.LogOutButton.TabIndex = 29;
            this.LogOutButton.Text = "Log Out";
            this.LogOutButton.UseVisualStyleBackColor = false;
            this.LogOutButton.Click += new System.EventHandler(this.LogOutButton_Click);
            // 
            // BoomWordsLabel
            // 
            this.BoomWordsLabel.AutoSize = true;
            this.BoomWordsLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.BoomWordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoomWordsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BoomWordsLabel.Location = new System.Drawing.Point(316, 60);
            this.BoomWordsLabel.Name = "BoomWordsLabel";
            this.BoomWordsLabel.Size = new System.Drawing.Size(453, 69);
            this.BoomWordsLabel.TabIndex = 32;
            this.BoomWordsLabel.Text = "BOOMWORDS";
            // 
            // JoinButton
            // 
            this.JoinButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.JoinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.JoinButton.Location = new System.Drawing.Point(617, 392);
            this.JoinButton.Name = "JoinButton";
            this.JoinButton.Size = new System.Drawing.Size(217, 81);
            this.JoinButton.TabIndex = 40;
            this.JoinButton.Text = "Join";
            this.JoinButton.UseVisualStyleBackColor = false;
            this.JoinButton.Click += new System.EventHandler(this.JoinButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.SystemColors.WindowText;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateButton.Location = new System.Drawing.Point(184, 396);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(250, 77);
            this.CreateButton.TabIndex = 41;
            this.CreateButton.Text = "Create a Party";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // JoinGamenameBox
            // 
            this.JoinGamenameBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.JoinGamenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinGamenameBox.Location = new System.Drawing.Point(617, 251);
            this.JoinGamenameBox.Name = "JoinGamenameBox";
            this.JoinGamenameBox.Size = new System.Drawing.Size(217, 30);
            this.JoinGamenameBox.TabIndex = 42;
            this.JoinGamenameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // JoinPasswordBox
            // 
            this.JoinPasswordBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.JoinPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinPasswordBox.Location = new System.Drawing.Point(617, 322);
            this.JoinPasswordBox.Name = "JoinPasswordBox";
            this.JoinPasswordBox.Size = new System.Drawing.Size(217, 30);
            this.JoinPasswordBox.TabIndex = 43;
            this.JoinPasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateGamenameBox
            // 
            this.CreateGamenameBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CreateGamenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateGamenameBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CreateGamenameBox.Location = new System.Drawing.Point(195, 251);
            this.CreateGamenameBox.Name = "CreateGamenameBox";
            this.CreateGamenameBox.Size = new System.Drawing.Size(239, 30);
            this.CreateGamenameBox.TabIndex = 44;
            this.CreateGamenameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreatePasswordBox
            // 
            this.CreatePasswordBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.CreatePasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePasswordBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CreatePasswordBox.Location = new System.Drawing.Point(195, 322);
            this.CreatePasswordBox.Name = "CreatePasswordBox";
            this.CreatePasswordBox.Size = new System.Drawing.Size(239, 30);
            this.CreatePasswordBox.TabIndex = 45;
            this.CreatePasswordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GameLabel
            // 
            this.GameLabel.AutoSize = true;
            this.GameLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.GameLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameLabel.Location = new System.Drawing.Point(461, 255);
            this.GameLabel.Name = "GameLabel";
            this.GameLabel.Size = new System.Drawing.Size(132, 24);
            this.GameLabel.TabIndex = 48;
            this.GameLabel.Text = "Game Name";
            this.GameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.WindowText;
            this.PasswordLabel.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.PasswordLabel.Location = new System.Drawing.Point(471, 326);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(104, 24);
            this.PasswordLabel.TabIndex = 49;
            this.PasswordLabel.Text = "Password";
            // 
            // UserLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::BoomWords.Properties.Resources.fondo_letras;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.ControlBox = false;
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.GameLabel);
            this.Controls.Add(this.CreatePasswordBox);
            this.Controls.Add(this.CreateGamenameBox);
            this.Controls.Add(this.JoinPasswordBox);
            this.Controls.Add(this.JoinGamenameBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.JoinButton);
            this.Controls.Add(this.BoomWordsLabel);
            this.Controls.Add(this.LogOutButton);
            this.Controls.Add(this.UsernameLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "UserLobby";
            this.Text = "UserLobby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserLobby_Closed);
            this.Load += new System.EventHandler(this.UserLobby_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Label BoomWordsLabel;
        private System.Windows.Forms.Button JoinButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.MaskedTextBox JoinGamenameBox;
        private System.Windows.Forms.MaskedTextBox JoinPasswordBox;
        private System.Windows.Forms.MaskedTextBox CreateGamenameBox;
        private System.Windows.Forms.MaskedTextBox CreatePasswordBox;
        private System.Windows.Forms.Label GameLabel;
        private System.Windows.Forms.Label PasswordLabel;
    }
}