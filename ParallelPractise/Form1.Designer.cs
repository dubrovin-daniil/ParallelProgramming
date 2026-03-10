namespace ParallelPractise
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
            tbExtension = new TextBox();
            tbPath = new TextBox();
            Path = new Label();
            FileExtension = new Label();
            btnNotParallel = new Button();
            btnParallel = new Button();
            rtbConsole = new RichTextBox();
            SuspendLayout();
            // 
            // tbExtension
            // 
            tbExtension.BackColor = SystemColors.InactiveCaption;
            tbExtension.Cursor = Cursors.Hand;
            tbExtension.Location = new Point(694, 71);
            tbExtension.Name = "tbExtension";
            tbExtension.PlaceholderText = "File Extension";
            tbExtension.Size = new Size(103, 23);
            tbExtension.TabIndex = 0;
            // 
            // tbPath
            // 
            tbPath.BackColor = SystemColors.InactiveCaption;
            tbPath.Cursor = Cursors.Hand;
            tbPath.Location = new Point(240, 71);
            tbPath.Name = "tbPath";
            tbPath.PlaceholderText = "Path";
            tbPath.Size = new Size(398, 23);
            tbPath.TabIndex = 1;
            tbPath.TextChanged += tbPath_TextChanged;
            // 
            // Path
            // 
            Path.AutoSize = true;
            Path.Location = new Point(240, 53);
            Path.Name = "Path";
            Path.Size = new Size(31, 15);
            Path.TabIndex = 2;
            Path.Text = "Path";
            // 
            // FileExtension
            // 
            FileExtension.AutoSize = true;
            FileExtension.Location = new Point(694, 53);
            FileExtension.Name = "FileExtension";
            FileExtension.Size = new Size(79, 15);
            FileExtension.TabIndex = 3;
            FileExtension.Text = "File Extension";
            // 
            // btnNotParallel
            // 
            btnNotParallel.BackColor = Color.FromArgb(255, 192, 192);
            btnNotParallel.Location = new Point(226, 358);
            btnNotParallel.Name = "btnNotParallel";
            btnNotParallel.Size = new Size(571, 57);
            btnNotParallel.TabIndex = 4;
            btnNotParallel.Text = "Not Paralel";
            btnNotParallel.UseVisualStyleBackColor = false;
            btnNotParallel.Click += btnStart_Click;
            // 
            // btnParallel
            // 
            btnParallel.BackColor = Color.FromArgb(192, 255, 192);
            btnParallel.Location = new Point(226, 421);
            btnParallel.Name = "btnParallel";
            btnParallel.Size = new Size(571, 57);
            btnParallel.TabIndex = 5;
            btnParallel.Text = "Paralel";
            btnParallel.UseVisualStyleBackColor = false;
            btnParallel.Click += btnParallel_Click;
            // 
            // rtbConsole
            // 
            rtbConsole.Location = new Point(280, 154);
            rtbConsole.Name = "rtbConsole";
            rtbConsole.Size = new Size(482, 157);
            rtbConsole.TabIndex = 6;
            rtbConsole.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1086, 584);
            Controls.Add(rtbConsole);
            Controls.Add(btnParallel);
            Controls.Add(btnNotParallel);
            Controls.Add(FileExtension);
            Controls.Add(Path);
            Controls.Add(tbPath);
            Controls.Add(tbExtension);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbExtension;
        private TextBox tbPath;
        private Label Path;
        private Label FileExtension;
        private Button btnNotParallel;
        private Button btnParallel;
        private RichTextBox rtbConsole;
    }
}
