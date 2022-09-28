namespace Travail1
{
    partial class FormJeu
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
            this.picPlancheJeu = new System.Windows.Forms.PictureBox();
            this.btnAvancer = new System.Windows.Forms.Button();
            this.lblTour = new System.Windows.Forms.Label();
            this.lblJoueur = new System.Windows.Forms.Label();
            this.userInfoJoueur1 = new Travail1.Controls.UserInfoJoueur();
            this.lstDebug = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlancheJeu
            // 
            this.picPlancheJeu.BackColor = System.Drawing.SystemColors.Control;
            this.picPlancheJeu.Location = new System.Drawing.Point(525, 15);
            this.picPlancheJeu.Margin = new System.Windows.Forms.Padding(6);
            this.picPlancheJeu.Name = "picPlancheJeu";
            this.picPlancheJeu.Size = new System.Drawing.Size(801, 801);
            this.picPlancheJeu.TabIndex = 0;
            this.picPlancheJeu.TabStop = false;
            // 
            // btnAvancer
            // 
            this.btnAvancer.Location = new System.Drawing.Point(300, 761);
            this.btnAvancer.Name = "btnAvancer";
            this.btnAvancer.Size = new System.Drawing.Size(216, 55);
            this.btnAvancer.TabIndex = 1;
            this.btnAvancer.Text = "Jouer";
            this.btnAvancer.UseVisualStyleBackColor = true;
            this.btnAvancer.Click += new System.EventHandler(this.btnAvancer_Click);
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Location = new System.Drawing.Point(12, 711);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(99, 41);
            this.lblTour.TabIndex = 2;
            this.lblTour.Text = "Tour : ";
            // 
            // lblJoueur
            // 
            this.lblJoueur.AutoSize = true;
            this.lblJoueur.Location = new System.Drawing.Point(117, 711);
            this.lblJoueur.Name = "lblJoueur";
            this.lblJoueur.Size = new System.Drawing.Size(220, 41);
            this.lblJoueur.TabIndex = 3;
            this.lblJoueur.Text = "Nom du joueur";
            // 
            // userInfoJoueur1
            // 
            this.userInfoJoueur1.Controleur = null;
            this.userInfoJoueur1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userInfoJoueur1.Location = new System.Drawing.Point(6, 7);
            this.userInfoJoueur1.Name = "userInfoJoueur1";
            this.userInfoJoueur1.Size = new System.Drawing.Size(510, 230);
            this.userInfoJoueur1.TabIndex = 4;
            this.userInfoJoueur1.Load += new System.EventHandler(this.userInfoJoueur1_Load);
            // 
            // lstDebug
            // 
            this.lstDebug.FormattingEnabled = true;
            this.lstDebug.ItemHeight = 41;
            this.lstDebug.Location = new System.Drawing.Point(12, 243);
            this.lstDebug.Name = "lstDebug";
            this.lstDebug.Size = new System.Drawing.Size(492, 455);
            this.lstDebug.TabIndex = 5;
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 836);
            this.Controls.Add(this.lstDebug);
            this.Controls.Add(this.userInfoJoueur1);
            this.Controls.Add(this.lblJoueur);
            this.Controls.Add(this.lblTour);
            this.Controls.Add(this.btnAvancer);
            this.Controls.Add(this.picPlancheJeu);
            this.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormJeu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormJeu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlancheJeu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picPlancheJeu;

        private Button btnAvancer;
        private Label lblTour;
        private Label lblJoueur;
        private Controls.UserInfoJoueur userInfoJoueur1;
        private ListBox lstDebug;
    }
}