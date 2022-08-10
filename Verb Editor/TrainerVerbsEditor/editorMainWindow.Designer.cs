namespace GERMAN_Word_Editor
{
    partial class editorMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editorMainWindow));
            this.verbListBox = new System.Windows.Forms.ListBox();
            this.mainVerbBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.verbBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.verbBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.verbBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.verbBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.verbBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.verbBox4 = new System.Windows.Forms.TextBox();
            this.editCheck = new System.Windows.Forms.CheckBox();
            this.addNewCheck = new System.Windows.Forms.CheckBox();
            this.delButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.border1 = new System.Windows.Forms.Label();
            this.border2 = new System.Windows.Forms.Label();
            this.border3 = new System.Windows.Forms.Label();
            this.border4 = new System.Windows.Forms.Label();
            this.border5 = new System.Windows.Forms.Label();
            this.border6 = new System.Windows.Forms.Label();
            this.border0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // verbListBox
            // 
            this.verbListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.verbListBox.FormattingEnabled = true;
            this.verbListBox.ItemHeight = 58;
            this.verbListBox.Location = new System.Drawing.Point(18, 18);
            this.verbListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verbListBox.Name = "verbListBox";
            this.verbListBox.Size = new System.Drawing.Size(1195, 410);
            this.verbListBox.TabIndex = 0;
            this.verbListBox.SelectedIndexChanged += new System.EventHandler(this.verbListBox_SelectedIndexChanged);
            // 
            // mainVerbBox
            // 
            this.mainVerbBox.Enabled = false;
            this.mainVerbBox.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.mainVerbBox.Location = new System.Drawing.Point(608, 435);
            this.mainVerbBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainVerbBox.Name = "mainVerbBox";
            this.mainVerbBox.Size = new System.Drawing.Size(372, 64);
            this.mainVerbBox.TabIndex = 1;
            this.mainVerbBox.Text = "EMPTY";
            this.mainVerbBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainVerbBox.TextChanged += new System.EventHandler(this.mainVerbBox_TextChanged);
            this.mainVerbBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mainVerbBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(348, 437);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = "Base form";
            // 
            // verbBox1
            // 
            this.verbBox1.Enabled = false;
            this.verbBox1.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.verbBox1.Location = new System.Drawing.Point(46, 600);
            this.verbBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verbBox1.Name = "verbBox1";
            this.verbBox1.Size = new System.Drawing.Size(372, 64);
            this.verbBox1.TabIndex = 3;
            this.verbBox1.Text = "EMPTY";
            this.verbBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verbBox1.TextChanged += new System.EventHandler(this.verbBox1_TextChanged);
            this.verbBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verbBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(183, 535);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ich";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(566, 535);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 58);
            this.label3.TabIndex = 6;
            this.label3.Text = "Du";
            // 
            // verbBox2
            // 
            this.verbBox2.Enabled = false;
            this.verbBox2.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.verbBox2.Location = new System.Drawing.Point(429, 600);
            this.verbBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verbBox2.Name = "verbBox2";
            this.verbBox2.Size = new System.Drawing.Size(372, 64);
            this.verbBox2.TabIndex = 5;
            this.verbBox2.Text = "EMPTY";
            this.verbBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verbBox2.TextChanged += new System.EventHandler(this.verbBox2_TextChanged);
            this.verbBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verbBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(897, 535);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 58);
            this.label4.TabIndex = 8;
            this.label4.Text = "Er sie es";
            // 
            // verbBox3
            // 
            this.verbBox3.Enabled = false;
            this.verbBox3.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.verbBox3.Location = new System.Drawing.Point(812, 600);
            this.verbBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verbBox3.Name = "verbBox3";
            this.verbBox3.Size = new System.Drawing.Size(372, 64);
            this.verbBox3.TabIndex = 7;
            this.verbBox3.Text = "EMPTY";
            this.verbBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verbBox3.TextChanged += new System.EventHandler(this.verbBox3_TextChanged);
            this.verbBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verbBox3_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(920, 712);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 58);
            this.label5.TabIndex = 14;
            this.label5.Text = "sie Sie";
            // 
            // verbBox6
            // 
            this.verbBox6.Enabled = false;
            this.verbBox6.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.verbBox6.Location = new System.Drawing.Point(812, 777);
            this.verbBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verbBox6.Name = "verbBox6";
            this.verbBox6.Size = new System.Drawing.Size(372, 64);
            this.verbBox6.TabIndex = 13;
            this.verbBox6.Text = "EMPTY";
            this.verbBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verbBox6.TextChanged += new System.EventHandler(this.verbBox6_TextChanged);
            this.verbBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verbBox6_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(566, 712);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 58);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ihr";
            // 
            // verbBox5
            // 
            this.verbBox5.Enabled = false;
            this.verbBox5.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.verbBox5.Location = new System.Drawing.Point(429, 777);
            this.verbBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verbBox5.Name = "verbBox5";
            this.verbBox5.Size = new System.Drawing.Size(372, 64);
            this.verbBox5.TabIndex = 11;
            this.verbBox5.Text = "EMPTY";
            this.verbBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verbBox5.TextChanged += new System.EventHandler(this.verbBox5_TextChanged);
            this.verbBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verbBox5_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(183, 712);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 58);
            this.label7.TabIndex = 10;
            this.label7.Text = "Wir";
            // 
            // verbBox4
            // 
            this.verbBox4.Enabled = false;
            this.verbBox4.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.verbBox4.Location = new System.Drawing.Point(46, 777);
            this.verbBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verbBox4.Name = "verbBox4";
            this.verbBox4.Size = new System.Drawing.Size(372, 64);
            this.verbBox4.TabIndex = 9;
            this.verbBox4.Text = "EMPTY";
            this.verbBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.verbBox4.TextChanged += new System.EventHandler(this.verbBox4_TextChanged);
            this.verbBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verbBox4_KeyPress);
            // 
            // editCheck
            // 
            this.editCheck.AutoSize = true;
            this.editCheck.Enabled = false;
            this.editCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editCheck.Location = new System.Drawing.Point(76, 891);
            this.editCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editCheck.Name = "editCheck";
            this.editCheck.Size = new System.Drawing.Size(337, 62);
            this.editCheck.TabIndex = 15;
            this.editCheck.Text = "Edit selected";
            this.editCheck.UseVisualStyleBackColor = true;
            this.editCheck.Click += new System.EventHandler(this.editCheck_Click);
            // 
            // addNewCheck
            // 
            this.addNewCheck.AutoSize = true;
            this.addNewCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addNewCheck.Location = new System.Drawing.Point(608, 891);
            this.addNewCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addNewCheck.Name = "addNewCheck";
            this.addNewCheck.Size = new System.Drawing.Size(356, 62);
            this.addNewCheck.TabIndex = 16;
            this.addNewCheck.Text = "Add new verb";
            this.addNewCheck.UseVisualStyleBackColor = true;
            this.addNewCheck.Click += new System.EventHandler(this.addNewCheck_Click);
            // 
            // delButton
            // 
            this.delButton.Enabled = false;
            this.delButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.delButton.Location = new System.Drawing.Point(54, 1049);
            this.delButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(442, 98);
            this.delButton.TabIndex = 17;
            this.delButton.Text = "Delete selected";
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(657, 1049);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(442, 98);
            this.addButton.TabIndex = 18;
            this.addButton.Text = "Add / Modify";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // border1
            // 
            this.border1.BackColor = System.Drawing.Color.Transparent;
            this.border1.Cursor = System.Windows.Forms.Cursors.Default;
            this.border1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.border1.Location = new System.Drawing.Point(30, 586);
            this.border1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.border1.Name = "border1";
            this.border1.Size = new System.Drawing.Size(390, 98);
            this.border1.TabIndex = 20;
            // 
            // border2
            // 
            this.border2.BackColor = System.Drawing.Color.Transparent;
            this.border2.Cursor = System.Windows.Forms.Cursors.Default;
            this.border2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.border2.Location = new System.Drawing.Point(418, 586);
            this.border2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.border2.Name = "border2";
            this.border2.Size = new System.Drawing.Size(390, 98);
            this.border2.TabIndex = 21;
            // 
            // border3
            // 
            this.border3.BackColor = System.Drawing.Color.Transparent;
            this.border3.Cursor = System.Windows.Forms.Cursors.Default;
            this.border3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.border3.Location = new System.Drawing.Point(812, 586);
            this.border3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.border3.Name = "border3";
            this.border3.Size = new System.Drawing.Size(390, 98);
            this.border3.TabIndex = 22;
            // 
            // border4
            // 
            this.border4.BackColor = System.Drawing.Color.Transparent;
            this.border4.Cursor = System.Windows.Forms.Cursors.Default;
            this.border4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.border4.Location = new System.Drawing.Point(40, 763);
            this.border4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.border4.Name = "border4";
            this.border4.Size = new System.Drawing.Size(392, 97);
            this.border4.TabIndex = 23;
            // 
            // border5
            // 
            this.border5.BackColor = System.Drawing.Color.Transparent;
            this.border5.Cursor = System.Windows.Forms.Cursors.Default;
            this.border5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.border5.Location = new System.Drawing.Point(418, 763);
            this.border5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.border5.Name = "border5";
            this.border5.Size = new System.Drawing.Size(392, 97);
            this.border5.TabIndex = 24;
            // 
            // border6
            // 
            this.border6.BackColor = System.Drawing.Color.Transparent;
            this.border6.Cursor = System.Windows.Forms.Cursors.Default;
            this.border6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.border6.Location = new System.Drawing.Point(801, 763);
            this.border6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.border6.Name = "border6";
            this.border6.Size = new System.Drawing.Size(392, 97);
            this.border6.TabIndex = 25;
            // 
            // border0
            // 
            this.border0.BackColor = System.Drawing.Color.Transparent;
            this.border0.Cursor = System.Windows.Forms.Cursors.Default;
            this.border0.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.border0.Location = new System.Drawing.Point(597, 420);
            this.border0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.border0.Name = "border0";
            this.border0.Size = new System.Drawing.Size(390, 98);
            this.border0.TabIndex = 26;
            // 
            // editorMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1228, 1225);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.addNewCheck);
            this.Controls.Add(this.editCheck);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.verbBox6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.verbBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.verbBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.verbBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.verbBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verbBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainVerbBox);
            this.Controls.Add(this.verbListBox);
            this.Controls.Add(this.border1);
            this.Controls.Add(this.border2);
            this.Controls.Add(this.border3);
            this.Controls.Add(this.border4);
            this.Controls.Add(this.border5);
            this.Controls.Add(this.border6);
            this.Controls.Add(this.border0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editorMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Database Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox verbListBox;
        private System.Windows.Forms.TextBox mainVerbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox verbBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox verbBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox verbBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox verbBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox verbBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox verbBox4;
        private System.Windows.Forms.CheckBox editCheck;
        private System.Windows.Forms.CheckBox addNewCheck;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label border1;
        private System.Windows.Forms.Label border2;
        private System.Windows.Forms.Label border3;
        private System.Windows.Forms.Label border4;
        private System.Windows.Forms.Label border5;
        private System.Windows.Forms.Label border6;
        private System.Windows.Forms.Label border0;
    }
}