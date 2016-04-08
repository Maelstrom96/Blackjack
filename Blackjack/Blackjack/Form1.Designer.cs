using System.Drawing;
namespace Blackjack
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_Joueur2_Piger = new Blackjack.RoundedButton();
            this.bt_Joueur2_Abandonner = new Blackjack.RoundedButton();
            this.bt_Joueur1_Piger = new Blackjack.RoundedButton();
            this.bt_Joueur1_Abandonner = new Blackjack.RoundedButton();
            this.SuspendLayout();
            // 
            // bt_Joueur2_Piger
            // 
            this.bt_Joueur2_Piger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Joueur2_Piger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Joueur2_Piger.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_Joueur2_Piger.FlatAppearance.BorderSize = 5;
            this.bt_Joueur2_Piger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Joueur2_Piger.Font = new System.Drawing.Font("David", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Joueur2_Piger.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Joueur2_Piger.Image = ((System.Drawing.Image)(resources.GetObject("bt_Joueur2_Piger.Image")));
            this.bt_Joueur2_Piger.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Joueur2_Piger.Left = false;
            this.bt_Joueur2_Piger.Location = new System.Drawing.Point(987, 113);
            this.bt_Joueur2_Piger.Name = "bt_Joueur2_Piger";
            this.bt_Joueur2_Piger.Size = new System.Drawing.Size(148, 136);
            this.bt_Joueur2_Piger.TabIndex = 0;
            this.bt_Joueur2_Piger.Text = "Piger";
            this.bt_Joueur2_Piger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Joueur2_Piger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_Joueur2_Piger.UseVisualStyleBackColor = false;
            this.bt_Joueur2_Piger.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Joueur2_Abandonner
            // 
            this.bt_Joueur2_Abandonner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Joueur2_Abandonner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Joueur2_Abandonner.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_Joueur2_Abandonner.FlatAppearance.BorderSize = 5;
            this.bt_Joueur2_Abandonner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Joueur2_Abandonner.Font = new System.Drawing.Font("David", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Joueur2_Abandonner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Joueur2_Abandonner.Image = ((System.Drawing.Image)(resources.GetObject("bt_Joueur2_Abandonner.Image")));
            this.bt_Joueur2_Abandonner.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Joueur2_Abandonner.Left = false;
            this.bt_Joueur2_Abandonner.Location = new System.Drawing.Point(987, 268);
            this.bt_Joueur2_Abandonner.Name = "bt_Joueur2_Abandonner";
            this.bt_Joueur2_Abandonner.Size = new System.Drawing.Size(148, 136);
            this.bt_Joueur2_Abandonner.TabIndex = 0;
            this.bt_Joueur2_Abandonner.Text = "Abandonner";
            this.bt_Joueur2_Abandonner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Joueur2_Abandonner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_Joueur2_Abandonner.UseVisualStyleBackColor = false;
            this.bt_Joueur2_Abandonner.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Joueur1_Piger
            // 
            this.bt_Joueur1_Piger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Joueur1_Piger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Joueur1_Piger.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_Joueur1_Piger.FlatAppearance.BorderSize = 5;
            this.bt_Joueur1_Piger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Joueur1_Piger.Font = new System.Drawing.Font("David", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Joueur1_Piger.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Joueur1_Piger.Image = ((System.Drawing.Image)(resources.GetObject("bt_Joueur1_Piger.Image")));
            this.bt_Joueur1_Piger.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Joueur1_Piger.Left = true;
            this.bt_Joueur1_Piger.Location = new System.Drawing.Point(1, 113);
            this.bt_Joueur1_Piger.Name = "bt_Joueur1_Piger";
            this.bt_Joueur1_Piger.Size = new System.Drawing.Size(148, 136);
            this.bt_Joueur1_Piger.TabIndex = 0;
            this.bt_Joueur1_Piger.Text = "Piger";
            this.bt_Joueur1_Piger.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Joueur1_Piger.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_Joueur1_Piger.UseVisualStyleBackColor = false;
            this.bt_Joueur1_Piger.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_Joueur1_Abandonner
            // 
            this.bt_Joueur1_Abandonner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bt_Joueur1_Abandonner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Joueur1_Abandonner.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_Joueur1_Abandonner.FlatAppearance.BorderSize = 5;
            this.bt_Joueur1_Abandonner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Joueur1_Abandonner.Font = new System.Drawing.Font("David", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Joueur1_Abandonner.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bt_Joueur1_Abandonner.Image = ((System.Drawing.Image)(resources.GetObject("bt_Joueur1_Abandonner.Image")));
            this.bt_Joueur1_Abandonner.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_Joueur1_Abandonner.Left = true;
            this.bt_Joueur1_Abandonner.Location = new System.Drawing.Point(1, 268);
            this.bt_Joueur1_Abandonner.Name = "bt_Joueur1_Abandonner";
            this.bt_Joueur1_Abandonner.Size = new System.Drawing.Size(148, 136);
            this.bt_Joueur1_Abandonner.TabIndex = 0;
            this.bt_Joueur1_Abandonner.Text = "Abandonner";
            this.bt_Joueur1_Abandonner.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_Joueur1_Abandonner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bt_Joueur1_Abandonner.UseVisualStyleBackColor = false;
            this.bt_Joueur1_Abandonner.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Blackjack.Properties.Resources.tableBackground;
            this.ClientSize = new System.Drawing.Size(1134, 642);
            this.Controls.Add(this.bt_Joueur2_Piger);
            this.Controls.Add(this.bt_Joueur2_Abandonner);
            this.Controls.Add(this.bt_Joueur1_Piger);
            this.Controls.Add(this.bt_Joueur1_Abandonner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton bt_Joueur1_Abandonner;
        private RoundedButton bt_Joueur1_Piger;
        private RoundedButton bt_Joueur2_Abandonner;
        private RoundedButton bt_Joueur2_Piger;

    }
}

