namespace HelpDeskUserInterface.Forms
{
    partial class CardsForm
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
            this.dgv_cards = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cards)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cards
            // 
            this.dgv_cards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cards.Location = new System.Drawing.Point(57, 68);
            this.dgv_cards.Name = "dgv_cards";
            this.dgv_cards.ReadOnly = true;
            this.dgv_cards.Size = new System.Drawing.Size(680, 345);
            this.dgv_cards.TabIndex = 0;
            // 
            // CardsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 474);
            this.Controls.Add(this.dgv_cards);
            this.Name = "CardsForm";
            this.Text = " CardsForm";
            this.Load += new System.EventHandler(this.CardsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cards;
    }
}