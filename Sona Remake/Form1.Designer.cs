namespace Sona_Remake
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            Execute = new Button();
            KillRoblox = new Button();
            ClearText = new Button();
            Inject = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(776, 328);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "--Sona Remake By thebeeswarmfarmer--";
            // 
            // Execute
            // 
            Execute.Location = new Point(12, 346);
            Execute.Name = "Execute";
            Execute.Size = new Size(172, 77);
            Execute.TabIndex = 1;
            Execute.Text = "Execute";
            Execute.UseVisualStyleBackColor = true;
            Execute.Click += Execute_Click;
            // 
            // KillRoblox
            // 
            KillRoblox.Location = new Point(440, 344);
            KillRoblox.Name = "KillRoblox";
            KillRoblox.Size = new Size(170, 77);
            KillRoblox.TabIndex = 2;
            KillRoblox.Text = "Kill Roblox";
            KillRoblox.UseVisualStyleBackColor = true;
            KillRoblox.Click += KillRoblox_Click;
            // 
            // ClearText
            // 
            ClearText.Location = new Point(190, 346);
            ClearText.Name = "ClearText";
            ClearText.Size = new Size(174, 77);
            ClearText.TabIndex = 3;
            ClearText.Text = "Clear Text";
            ClearText.UseVisualStyleBackColor = true;
            ClearText.Click += ClearText_Click;
            // 
            // Inject
            // 
            Inject.Location = new Point(616, 344);
            Inject.Name = "Inject";
            Inject.Size = new Size(172, 79);
            Inject.TabIndex = 4;
            Inject.Text = "Inject";
            Inject.UseVisualStyleBackColor = true;
            Inject.Click += Inject_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Inject);
            Controls.Add(ClearText);
            Controls.Add(KillRoblox);
            Controls.Add(Execute);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Sona Remake";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button Execute;
        private Button KillRoblox;
        private Button ClearText;
        private Button Inject;
    }
}
