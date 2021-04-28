namespace ChuckNorrisWinForm
{
    partial class ChuckNorrisJokeFrm
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
            this.randomJokeBtn = new System.Windows.Forms.Button();
            this.randomJokeRtx = new System.Windows.Forms.RichTextBox();
            this.jokeCategoriesCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // randomJokeBtn
            // 
            this.randomJokeBtn.Location = new System.Drawing.Point(281, 41);
            this.randomJokeBtn.Name = "randomJokeBtn";
            this.randomJokeBtn.Size = new System.Drawing.Size(242, 111);
            this.randomJokeBtn.TabIndex = 0;
            this.randomJokeBtn.Text = "Get Random Joke";
            this.randomJokeBtn.UseVisualStyleBackColor = true;
            this.randomJokeBtn.Click += new System.EventHandler(this.randomJokeBtn_Click);
            // 
            // randomJokeRtx
            // 
            this.randomJokeRtx.Location = new System.Drawing.Point(35, 176);
            this.randomJokeRtx.Name = "randomJokeRtx";
            this.randomJokeRtx.Size = new System.Drawing.Size(734, 96);
            this.randomJokeRtx.TabIndex = 2;
            this.randomJokeRtx.Text = "";
            // 
            // jokeCategoriesCmb
            // 
            this.jokeCategoriesCmb.FormattingEnabled = true;
            this.jokeCategoriesCmb.Location = new System.Drawing.Point(35, 61);
            this.jokeCategoriesCmb.Name = "jokeCategoriesCmb";
            this.jokeCategoriesCmb.Size = new System.Drawing.Size(187, 28);
            this.jokeCategoriesCmb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Joke Categories:";
            // 
            // ChuckNorrisJokeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jokeCategoriesCmb);
            this.Controls.Add(this.randomJokeRtx);
            this.Controls.Add(this.randomJokeBtn);
            this.Name = "ChuckNorrisJokeFrm";
            this.Text = "Chuck Norris Joke Generator";
            this.Load += new System.EventHandler(this.ChuckNorrisJokeFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomJokeBtn;
        private System.Windows.Forms.RichTextBox randomJokeRtx;
        private System.Windows.Forms.ComboBox jokeCategoriesCmb;
        private System.Windows.Forms.Label label1;
    }
}

