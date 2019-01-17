namespace AddressBook
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxPeople = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBoxInformation = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removePeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClose = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnRemove = new AddressBook.CircularButton();
            this.btnAddContact = new AddressBook.CircularButton();
            this.btnSaveChanges = new AddressBook.CircularButton();
            this.PersonPic = new AddressBook.CircularPictureBox();
            this.groupBoxPeople.SuspendLayout();
            this.groupBoxInformation.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PersonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPeople
            // 
            this.groupBoxPeople.Controls.Add(this.listView1);
            this.groupBoxPeople.ForeColor = System.Drawing.Color.Green;
            this.groupBoxPeople.Location = new System.Drawing.Point(14, 25);
            this.groupBoxPeople.Name = "groupBoxPeople";
            this.groupBoxPeople.Size = new System.Drawing.Size(208, 392);
            this.groupBoxPeople.TabIndex = 0;
            this.groupBoxPeople.TabStop = false;
            this.groupBoxPeople.Text = "People";
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(3, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(202, 371);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxInformation
            // 
            this.groupBoxInformation.Controls.Add(this.btnRemove);
            this.groupBoxInformation.Controls.Add(this.btnAddContact);
            this.groupBoxInformation.Controls.Add(this.btnSaveChanges);
            this.groupBoxInformation.Controls.Add(this.dateTimePicker1);
            this.groupBoxInformation.Controls.Add(this.textBox5);
            this.groupBoxInformation.Controls.Add(this.textBox4);
            this.groupBoxInformation.Controls.Add(this.label6);
            this.groupBoxInformation.Controls.Add(this.label5);
            this.groupBoxInformation.Controls.Add(this.label4);
            this.groupBoxInformation.Controls.Add(this.textBox2);
            this.groupBoxInformation.Controls.Add(this.textBox3);
            this.groupBoxInformation.Controls.Add(this.label2);
            this.groupBoxInformation.Controls.Add(this.label3);
            this.groupBoxInformation.Controls.Add(this.textBox1);
            this.groupBoxInformation.Controls.Add(this.label1);
            this.groupBoxInformation.Controls.Add(this.PersonPic);
            this.groupBoxInformation.ForeColor = System.Drawing.Color.Green;
            this.groupBoxInformation.Location = new System.Drawing.Point(243, 25);
            this.groupBoxInformation.Name = "groupBoxInformation";
            this.groupBoxInformation.Size = new System.Drawing.Size(604, 389);
            this.groupBoxInformation.TabIndex = 1;
            this.groupBoxInformation.TabStop = false;
            this.groupBoxInformation.Text = "Information";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(233, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(26, 204);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(572, 77);
            this.textBox5.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(233, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(365, 22);
            this.textBox4.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Chartreuse;
            this.label6.Location = new System.Drawing.Point(23, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 14);
            this.label6.TabIndex = 1;
            this.label6.Text = "Additional Notes :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Chartreuse;
            this.label5.Location = new System.Drawing.Point(146, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 14);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date Of Birth :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(183, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Street :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(233, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(365, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(233, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(365, 22);
            this.textBox3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(179, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(179, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "E-mail :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(181, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removePeopleToolStripMenuItem,
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 48);
            // 
            // removePeopleToolStripMenuItem
            // 
            this.removePeopleToolStripMenuItem.Name = "removePeopleToolStripMenuItem";
            this.removePeopleToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.removePeopleToolStripMenuItem.Text = "Remove People";
            this.removePeopleToolStripMenuItem.Click += new System.EventHandler(this.removePeopleToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.ForeColor = System.Drawing.Color.Red;
            this.lblClose.Location = new System.Drawing.Point(828, 5);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(19, 17);
            this.lblClose.TabIndex = 2;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Impact", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(808, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "AddressBook";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDown);
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnRemove.Location = new System.Drawing.Point(391, 318);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 29);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnAddContact.Location = new System.Drawing.Point(285, 318);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(100, 29);
            this.btnAddContact.TabIndex = 4;
            this.btnAddContact.Text = "Add Contact";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.ForeColor = System.Drawing.Color.OrangeRed;
            this.btnSaveChanges.Location = new System.Drawing.Point(179, 318);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(100, 29);
            this.btnSaveChanges.TabIndex = 4;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // PersonPic
            // 
            this.PersonPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PersonPic.BackgroundImage")));
            this.PersonPic.Image = ((System.Drawing.Image)(resources.GetObject("PersonPic.Image")));
            this.PersonPic.Location = new System.Drawing.Point(26, 36);
            this.PersonPic.Name = "PersonPic";
            this.PersonPic.Size = new System.Drawing.Size(125, 125);
            this.PersonPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PersonPic.TabIndex = 0;
            this.PersonPic.TabStop = false;
            this.PersonPic.Click += new System.EventHandler(this.PersonPic_Click);
            this.PersonPic.DragDrop += new System.Windows.Forms.DragEventHandler(this.PersonPic_DragDrop);
            this.PersonPic.DragEnter += new System.Windows.Forms.DragEventHandler(this.PersonPic_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(857, 427);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.groupBoxInformation);
            this.Controls.Add(this.groupBoxPeople);
            this.Font = new System.Drawing.Font("Helvetica", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Address Book";
            this.groupBoxPeople.ResumeLayout(false);
            this.groupBoxInformation.ResumeLayout(false);
            this.groupBoxInformation.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PersonPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPeople;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBoxInformation;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private CircularPictureBox PersonPic;
        private CircularButton btnRemove;
        private CircularButton btnAddContact;
        private CircularButton btnSaveChanges;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removePeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

