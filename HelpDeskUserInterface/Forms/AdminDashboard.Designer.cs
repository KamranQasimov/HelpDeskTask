namespace HelpDeskUserInterface.Forms
{
    partial class AdminDashboard
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
            this.lbl_greeting = new System.Windows.Forms.Label();
            this.link_add_card = new System.Windows.Forms.LinkLabel();
            this.link_remove_card = new System.Windows.Forms.LinkLabel();
            this.link_user = new System.Windows.Forms.LinkLabel();
            this.link_cards = new System.Windows.Forms.LinkLabel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.link_operator = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_greeting
            // 
            this.lbl_greeting.AutoSize = true;
            this.lbl_greeting.Location = new System.Drawing.Point(452, 58);
            this.lbl_greeting.Name = "lbl_greeting";
            this.lbl_greeting.Size = new System.Drawing.Size(34, 13);
            this.lbl_greeting.TabIndex = 0;
            this.lbl_greeting.Text = "Hello:";
            this.lbl_greeting.Click += new System.EventHandler(this.lbl_greeting_Click);
            // 
            // link_add_card
            // 
            this.link_add_card.AutoSize = true;
            this.link_add_card.Location = new System.Drawing.Point(12, 74);
            this.link_add_card.Name = "link_add_card";
            this.link_add_card.Size = new System.Drawing.Size(51, 13);
            this.link_add_card.TabIndex = 1;
            this.link_add_card.TabStop = true;
            this.link_add_card.Text = "Add Card";
            this.link_add_card.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_add_card_LinkClicked);
            // 
            // link_remove_card
            // 
            this.link_remove_card.AutoSize = true;
            this.link_remove_card.Location = new System.Drawing.Point(12, 118);
            this.link_remove_card.Name = "link_remove_card";
            this.link_remove_card.Size = new System.Drawing.Size(72, 13);
            this.link_remove_card.TabIndex = 2;
            this.link_remove_card.TabStop = true;
            this.link_remove_card.Text = "Remove Card";
            // 
            // link_user
            // 
            this.link_user.AutoSize = true;
            this.link_user.Location = new System.Drawing.Point(12, 162);
            this.link_user.Name = "link_user";
            this.link_user.Size = new System.Drawing.Size(34, 13);
            this.link_user.TabIndex = 3;
            this.link_user.TabStop = true;
            this.link_user.Text = "Users";
            this.link_user.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_user_LinkClicked);
            // 
            // link_cards
            // 
            this.link_cards.AutoSize = true;
            this.link_cards.Location = new System.Drawing.Point(15, 197);
            this.link_cards.Name = "link_cards";
            this.link_cards.Size = new System.Drawing.Size(34, 13);
            this.link_cards.TabIndex = 4;
            this.link_cards.TabStop = true;
            this.link_cards.Text = "Cards";
            this.link_cards.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_cards_LinkClicked);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(560, 12);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 5;
            this.btn_Logout.Text = "LogOut";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // link_operator
            // 
            this.link_operator.AutoSize = true;
            this.link_operator.Location = new System.Drawing.Point(15, 228);
            this.link_operator.Name = "link_operator";
            this.link_operator.Size = new System.Drawing.Size(70, 13);
            this.link_operator.TabIndex = 6;
            this.link_operator.TabStop = true;
            this.link_operator.Text = "Add Operator";
            this.link_operator.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_operator_LinkClicked);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 435);
            this.Controls.Add(this.link_operator);
            this.Controls.Add(this.btn_Logout);
            this.Controls.Add(this.link_cards);
            this.Controls.Add(this.link_user);
            this.Controls.Add(this.link_remove_card);
            this.Controls.Add(this.link_add_card);
            this.Controls.Add(this.lbl_greeting);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_greeting;
        private System.Windows.Forms.LinkLabel link_add_card;
        private System.Windows.Forms.LinkLabel link_remove_card;
        private System.Windows.Forms.LinkLabel link_user;
        private System.Windows.Forms.LinkLabel link_cards;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.LinkLabel link_operator;
    }
}