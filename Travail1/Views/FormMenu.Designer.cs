namespace Travail1.Views
{
    partial class FormMenu
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
            this.btnCommencerPartie = new System.Windows.Forms.Button();
            this.lbJoueur1 = new System.Windows.Forms.Label();
            this.txtJoueur1 = new System.Windows.Forms.TextBox();
            this.txtJoueur2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCommencerPartie
            // 
            this.btnCommencerPartie.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCommencerPartie.Location = new System.Drawing.Point(254, 351);
            this.btnCommencerPartie.Name = "btnCommencerPartie";
            this.btnCommencerPartie.Size = new System.Drawing.Size(314, 87);
            this.btnCommencerPartie.TabIndex = 0;
            this.btnCommencerPartie.Text = "Commencer la partie";
            this.btnCommencerPartie.UseVisualStyleBackColor = true;
            this.btnCommencerPartie.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbJoueur1
            // 
            this.lbJoueur1.AutoSize = true;
            this.lbJoueur1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbJoueur1.Location = new System.Drawing.Point(12, 18);
            this.lbJoueur1.Name = "lbJoueur1";
            this.lbJoueur1.Size = new System.Drawing.Size(220, 41);
            this.lbJoueur1.TabIndex = 1;
            this.lbJoueur1.Text = "Nom Joueur 1: ";
            // 
            // txtJoueur1
            // 
            this.txtJoueur1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJoueur1.Location = new System.Drawing.Point(254, 18);
            this.txtJoueur1.Name = "txtJoueur1";
            this.txtJoueur1.Size = new System.Drawing.Size(352, 47);
            this.txtJoueur1.TabIndex = 2;
            // 
            // txtJoueur2
            // 
            this.txtJoueur2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJoueur2.Location = new System.Drawing.Point(254, 128);
            this.txtJoueur2.Name = "txtJoueur2";
            this.txtJoueur2.Size = new System.Drawing.Size(352, 47);
            this.txtJoueur2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom Joueur 2: ";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtJoueur2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtJoueur1);
            this.Controls.Add(this.lbJoueur1);
            this.Controls.Add(this.btnCommencerPartie);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCommencerPartie;
        private Label lbJoueur1;
        private TextBox txtJoueur1;
        private TextBox txtJoueur2;
        private Label label1;
    }
}