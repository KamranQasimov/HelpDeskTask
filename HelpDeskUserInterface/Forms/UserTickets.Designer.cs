namespace HelpDeskUserInterface.Forms
{
    partial class UserTickets
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
            this.dgv_user_tickets = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_tickets)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_user_tickets
            // 
            this.dgv_user_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user_tickets.Location = new System.Drawing.Point(12, 53);
            this.dgv_user_tickets.Name = "dgv_user_tickets";
            this.dgv_user_tickets.Size = new System.Drawing.Size(776, 255);
            this.dgv_user_tickets.TabIndex = 0;
            // 
            // UserTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_user_tickets);
            this.Name = "UserTickets";
            this.Text = "UserTickets";
            this.Load += new System.EventHandler(this.UserTickets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user_tickets)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_user_tickets;
    }
}