namespace Speech_Recognition
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LstCommands = new System.Windows.Forms.ListBox();
            this.TimerSpeak = new System.Windows.Forms.Timer(this.components);
            this.voice_list = new System.Windows.Forms.ComboBox();
            this.select_voice = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstCommands
            // 
            this.LstCommands.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.LstCommands.ForeColor = System.Drawing.SystemColors.Window;
            this.LstCommands.FormattingEnabled = true;
            this.LstCommands.Location = new System.Drawing.Point(12, 57);
            this.LstCommands.Name = "LstCommands";
            this.LstCommands.Size = new System.Drawing.Size(405, 316);
            this.LstCommands.TabIndex = 0;
            // 
            // TimerSpeak
            // 
            this.TimerSpeak.Enabled = true;
            this.TimerSpeak.Interval = 1000;
            this.TimerSpeak.Tick += new System.EventHandler(this.TimerSpeak_Tick);
            // 
            // voice_list
            // 
            this.voice_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voice_list.FormattingEnabled = true;
            this.voice_list.Location = new System.Drawing.Point(487, 84);
            this.voice_list.Name = "voice_list";
            this.voice_list.Size = new System.Drawing.Size(164, 21);
            this.voice_list.TabIndex = 1;
            // 
            // select_voice
            // 
            this.select_voice.Location = new System.Drawing.Point(487, 111);
            this.select_voice.Name = "select_voice";
            this.select_voice.Size = new System.Drawing.Size(164, 23);
            this.select_voice.TabIndex = 2;
            this.select_voice.Text = "select_voice";
            this.select_voice.UseVisualStyleBackColor = true;
            this.select_voice.Click += new System.EventHandler(this.select_voice_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Commands_List";
            // 
            // info
            // 
            this.info.Location = new System.Drawing.Point(217, 4);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(200, 47);
            this.info.TabIndex = 4;
            this.info.Text = "Say \'Show commands\' to show the command list.\r\nSay \"Wake up\" if the program has s" +
    "lept.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(484, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "select the voice and hit select\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 385);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_voice);
            this.Controls.Add(this.voice_list);
            this.Controls.Add(this.LstCommands);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstCommands;
        private System.Windows.Forms.Timer TimerSpeak;
        private System.Windows.Forms.ComboBox voice_list;
        private System.Windows.Forms.Button select_voice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Label label2;
    }
}

