namespace HelpDeskUserInterface
{
    partial class AddCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_card_number = new System.Windows.Forms.TextBox();
            this.txbx_card_amoun = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_card_expire_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_generate_card = new System.Windows.Forms.Button();
            this.btn_add_card = new System.Windows.Forms.Button();
            this.link_item_count = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Card Number:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbx_card_number
            // 
            this.txbx_card_number.Location = new System.Drawing.Point(24, 49);
            this.txbx_card_number.Name = "txbx_card_number";
            this.txbx_card_number.Size = new System.Drawing.Size(299, 20);
            this.txbx_card_number.TabIndex = 1;
            // 
            // txbx_card_amoun
            // 
            this.txbx_card_amoun.Location = new System.Drawing.Point(24, 122);
            this.txbx_card_amoun.Name = "txbx_card_amoun";
            this.txbx_card_amoun.Size = new System.Drawing.Size(299, 20);
            this.txbx_card_amoun.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Amount:";
            // 
            // txbx_card_expire_date
            // 
            this.txbx_card_expire_date.Location = new System.Drawing.Point(24, 199);
            this.txbx_card_expire_date.Name = "txbx_card_expire_date";
            this.txbx_card_expire_date.Size = new System.Drawing.Size(299, 20);
            this.txbx_card_expire_date.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Expire Date:";
            // 
            // btn_generate_card
            // 
            this.btn_generate_card.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_generate_card.Location = new System.Drawing.Point(387, 49);
            this.btn_generate_card.Name = "btn_generate_card";
            this.btn_generate_card.Size = new System.Drawing.Size(105, 69);
            this.btn_generate_card.TabIndex = 6;
            this.btn_generate_card.Text = "Generate";
            this.btn_generate_card.UseVisualStyleBackColor = true;
            this.btn_generate_card.Click += new System.EventHandler(this.btn_generate_card_Click);
            // 
            // btn_add_card
            // 
            this.btn_add_card.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_card.Location = new System.Drawing.Point(118, 250);
            this.btn_add_card.Name = "btn_add_card";
            this.btn_add_card.Size = new System.Drawing.Size(95, 55);
            this.btn_add_card.TabIndex = 7;
            this.btn_add_card.Text = "Add";
            this.btn_add_card.UseVisualStyleBackColor = true;
            this.btn_add_card.Click += new System.EventHandler(this.btn_add_card_Click);
            // 
            // link_item_count
            // 
            this.link_item_count.AutoSize = true;
            this.link_item_count.Location = new System.Drawing.Point(367, 250);
            this.link_item_count.Name = "link_item_count";
            this.link_item_count.Size = new System.Drawing.Size(13, 13);
            this.link_item_count.TabIndex = 8;
            this.link_item_count.TabStop = true;
            this.link_item_count.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "items in DB";
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.link_item_count);
            this.Controls.Add(this.btn_add_card);
            this.Controls.Add(this.btn_generate_card);
            this.Controls.Add(this.txbx_card_expire_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbx_card_amoun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_card_number);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AddCard";
            this.Text = "Add Card";
            this.Load += new System.EventHandler(this.AddCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_card_number;
        private System.Windows.Forms.TextBox txbx_card_amoun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_card_expire_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_generate_card;
        private System.Windows.Forms.Button btn_add_card;
        private System.Windows.Forms.LinkLabel link_item_count;
        private System.Windows.Forms.Label label4;
    }
}

