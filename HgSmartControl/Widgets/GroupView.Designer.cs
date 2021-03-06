﻿namespace HgSmartControl.Widgets
{
    partial class GroupView
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.centerPanelView = new HgSmartControl.Controls.CenterPanel(this.components);
            this.SuspendLayout();
            // 
            // centerPanelView
            // 
            this.centerPanelView.AutoSize = true;
            this.centerPanelView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanelView.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.centerPanelView.ForeColor = System.Drawing.Color.Yellow;
            this.centerPanelView.Location = new System.Drawing.Point(0, 0);
            this.centerPanelView.Margin = new System.Windows.Forms.Padding(0);
            this.centerPanelView.Name = "centerPanelView";
            this.centerPanelView.Size = new System.Drawing.Size(320, 240);
            this.centerPanelView.TabIndex = 13;
            this.centerPanelView.Text = "Untitled";
            this.centerPanelView.TextClicked += new System.EventHandler<string>(this.centerPanelView_TextClicked);
            // 
            // GroupView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.centerPanelView);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GroupView";
            this.Size = new System.Drawing.Size(320, 240);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.CenterPanel centerPanelView;

    }
}
