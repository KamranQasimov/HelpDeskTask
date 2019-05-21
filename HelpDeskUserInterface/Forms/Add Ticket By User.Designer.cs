namespace HelpDeskUserInterface.Forms
{
    partial class Add_Ticket_By_User
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
            this.txbx_title = new System.Windows.Forms.TextBox();
            this.txbx_description = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_ticket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbx_title
            // 
            this.txbx_title.Location = new System.Drawing.Point(175, 75);
            this.txbx_title.Name = "txbx_title";
            this.txbx_title.Size = new System.Drawing.Size(453, 20);
            this.txbx_title.TabIndex = 0;
            // 
            // txbx_description
            // 
            this.txbx_description.Location = new System.Drawing.Point(175, 176);
            this.txbx_description.Name = "txbx_description";
            this.txbx_description.Size = new System.Drawing.Size(453, 129);
            this.txbx_description.TabIndex = 1;
            this.txbx_description.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(381, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Titile";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // btn_add_ticket
            // 
            this.btn_add_ticket.Location = new System.Drawing.Point(357, 327);
            this.btn_add_ticket.Name = "btn_add_ticket";
            this.btn_add_ticket.Size = new System.Drawing.Size(75, 23);
            this.btn_add_ticket.TabIndex = 4;
            this.btn_add_ticket.Text = "Send Ticket";
            this.btn_add_ticket.UseVisualStyleBackColor = true;
            this.btn_add_ticket.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Ticket_By_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_add_ticket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_description);
            this.Controls.Add(this.txbx_title);
            this.Name = "Add_Ticket_By_User";
            this.Text = "Add_Ticket_By_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbx_title;
        private System.Windows.Forms.RichTextBox txbx_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_ticket;
    }
}