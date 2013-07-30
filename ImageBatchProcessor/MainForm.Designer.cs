namespace ImageBatchProcessor
{
    partial class MainForm
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
            this.txtSelectFolder = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.nudZoom = new System.Windows.Forms.NumericUpDown();
            this.btnToFolder = new System.Windows.Forms.Button();
            this.txtToFolder = new System.Windows.Forms.TextBox();
            this.txtReplaceFrom = new System.Windows.Forms.TextBox();
            this.txtReplaceTo = new System.Windows.Forms.TextBox();
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.SelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ToFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStartProcessing = new System.Windows.Forms.Button();
            this.cbReplace = new System.Windows.Forms.CheckBox();
            this.cbInsertInStart = new System.Windows.Forms.CheckBox();
            this.cbInsertInEnd = new System.Windows.Forms.CheckBox();
            this.cbRemove = new System.Windows.Forms.CheckBox();
            this.txtInsertStart = new System.Windows.Forms.TextBox();
            this.txtInsertEnd = new System.Windows.Forms.TextBox();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSelectFolder
            // 
            this.txtSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSelectFolder.Location = new System.Drawing.Point(117, 24);
            this.txtSelectFolder.Name = "txtSelectFolder";
            this.txtSelectFolder.ReadOnly = true;
            this.txtSelectFolder.Size = new System.Drawing.Size(438, 20);
            this.txtSelectFolder.TabIndex = 0;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFolder.Location = new System.Drawing.Point(561, 22);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(30, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // nudZoom
            // 
            this.nudZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudZoom.Location = new System.Drawing.Point(158, 23);
            this.nudZoom.Name = "nudZoom";
            this.nudZoom.Size = new System.Drawing.Size(141, 20);
            this.nudZoom.TabIndex = 2;
            this.nudZoom.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnToFolder
            // 
            this.btnToFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToFolder.Location = new System.Drawing.Point(561, 48);
            this.btnToFolder.Name = "btnToFolder";
            this.btnToFolder.Size = new System.Drawing.Size(30, 23);
            this.btnToFolder.TabIndex = 4;
            this.btnToFolder.Text = "...";
            this.btnToFolder.UseVisualStyleBackColor = true;
            this.btnToFolder.Click += new System.EventHandler(this.btnToFolder_Click);
            // 
            // txtToFolder
            // 
            this.txtToFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToFolder.Location = new System.Drawing.Point(117, 50);
            this.txtToFolder.Name = "txtToFolder";
            this.txtToFolder.ReadOnly = true;
            this.txtToFolder.Size = new System.Drawing.Size(438, 20);
            this.txtToFolder.TabIndex = 3;
            // 
            // txtReplaceFrom
            // 
            this.txtReplaceFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplaceFrom.Location = new System.Drawing.Point(158, 49);
            this.txtReplaceFrom.Name = "txtReplaceFrom";
            this.txtReplaceFrom.ReadOnly = true;
            this.txtReplaceFrom.Size = new System.Drawing.Size(141, 20);
            this.txtReplaceFrom.TabIndex = 5;
            // 
            // txtReplaceTo
            // 
            this.txtReplaceTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplaceTo.Location = new System.Drawing.Point(158, 75);
            this.txtReplaceTo.Name = "txtReplaceTo";
            this.txtReplaceTo.ReadOnly = true;
            this.txtReplaceTo.Size = new System.Drawing.Size(141, 20);
            this.txtReplaceTo.TabIndex = 6;
            // 
            // lbMessage
            // 
            this.lbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.HorizontalScrollbar = true;
            this.lbMessage.Location = new System.Drawing.Point(12, 309);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.ScrollAlwaysVisible = true;
            this.lbMessage.Size = new System.Drawing.Size(598, 147);
            this.lbMessage.Sorted = true;
            this.lbMessage.TabIndex = 7;
            // 
            // SelectFolder
            // 
            this.SelectFolder.ShowNewFolderButton = false;
            // 
            // btnStartProcessing
            // 
            this.btnStartProcessing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartProcessing.Location = new System.Drawing.Point(507, 462);
            this.btnStartProcessing.Name = "btnStartProcessing";
            this.btnStartProcessing.Size = new System.Drawing.Size(103, 23);
            this.btnStartProcessing.TabIndex = 8;
            this.btnStartProcessing.Text = "Start Processing";
            this.btnStartProcessing.UseVisualStyleBackColor = true;
            this.btnStartProcessing.Click += new System.EventHandler(this.btnStartProcessing_Click);
            // 
            // cbReplace
            // 
            this.cbReplace.AutoSize = true;
            this.cbReplace.Location = new System.Drawing.Point(27, 51);
            this.cbReplace.Name = "cbReplace";
            this.cbReplace.Size = new System.Drawing.Size(66, 17);
            this.cbReplace.TabIndex = 9;
            this.cbReplace.Text = "Replace";
            this.cbReplace.UseVisualStyleBackColor = true;
            this.cbReplace.CheckedChanged += new System.EventHandler(this.cbReplace_CheckedChanged);
            // 
            // cbInsertInStart
            // 
            this.cbInsertInStart.AutoSize = true;
            this.cbInsertInStart.Location = new System.Drawing.Point(27, 103);
            this.cbInsertInStart.Name = "cbInsertInStart";
            this.cbInsertInStart.Size = new System.Drawing.Size(86, 17);
            this.cbInsertInStart.TabIndex = 10;
            this.cbInsertInStart.Text = "Insert in start";
            this.cbInsertInStart.UseVisualStyleBackColor = true;
            this.cbInsertInStart.CheckedChanged += new System.EventHandler(this.cbInsertInStart_CheckedChanged);
            // 
            // cbInsertInEnd
            // 
            this.cbInsertInEnd.AutoSize = true;
            this.cbInsertInEnd.Location = new System.Drawing.Point(27, 129);
            this.cbInsertInEnd.Name = "cbInsertInEnd";
            this.cbInsertInEnd.Size = new System.Drawing.Size(84, 17);
            this.cbInsertInEnd.TabIndex = 11;
            this.cbInsertInEnd.Text = "Insert in end";
            this.cbInsertInEnd.UseVisualStyleBackColor = true;
            this.cbInsertInEnd.CheckedChanged += new System.EventHandler(this.cbInsertInEnd_CheckedChanged);
            // 
            // cbRemove
            // 
            this.cbRemove.AutoSize = true;
            this.cbRemove.Location = new System.Drawing.Point(27, 155);
            this.cbRemove.Name = "cbRemove";
            this.cbRemove.Size = new System.Drawing.Size(66, 17);
            this.cbRemove.TabIndex = 12;
            this.cbRemove.Text = "Remove";
            this.cbRemove.UseVisualStyleBackColor = true;
            this.cbRemove.CheckedChanged += new System.EventHandler(this.cbRemove_CheckedChanged);
            // 
            // txtInsertStart
            // 
            this.txtInsertStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsertStart.Location = new System.Drawing.Point(158, 101);
            this.txtInsertStart.Name = "txtInsertStart";
            this.txtInsertStart.ReadOnly = true;
            this.txtInsertStart.Size = new System.Drawing.Size(141, 20);
            this.txtInsertStart.TabIndex = 13;
            // 
            // txtInsertEnd
            // 
            this.txtInsertEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInsertEnd.Location = new System.Drawing.Point(158, 127);
            this.txtInsertEnd.Name = "txtInsertEnd";
            this.txtInsertEnd.ReadOnly = true;
            this.txtInsertEnd.Size = new System.Drawing.Size(141, 20);
            this.txtInsertEnd.TabIndex = 14;
            // 
            // txtRemove
            // 
            this.txtRemove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRemove.Location = new System.Drawing.Point(158, 153);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.ReadOnly = true;
            this.txtRemove.Size = new System.Drawing.Size(141, 20);
            this.txtRemove.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Original Image Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Save Image Folder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Zoom (%)";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtSelectFolder);
            this.groupBox1.Controls.Add(this.btnSelectFolder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtToFolder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnToFolder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 87);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudZoom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtInsertStart);
            this.groupBox2.Controls.Add(this.cbReplace);
            this.groupBox2.Controls.Add(this.cbInsertInStart);
            this.groupBox2.Controls.Add(this.txtReplaceTo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbInsertInEnd);
            this.groupBox2.Controls.Add(this.txtRemove);
            this.groupBox2.Controls.Add(this.txtReplaceFrom);
            this.groupBox2.Controls.Add(this.txtInsertEnd);
            this.groupBox2.Controls.Add(this.cbRemove);
            this.groupBox2.Location = new System.Drawing.Point(12, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 188);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(305, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(208, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Enter a text want to remove from file name.";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(219, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Enter a text want to insert in end of file name.";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(305, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Enter a text want to insert in start of file name.";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Enter a text want to replace into file name.";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "The text in file name want to be replaced.";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Set the value (%) of zoom from original image to new image.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "From";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStartProcessing);
            this.Controls.Add(this.lbMessage);
            this.MinimumSize = new System.Drawing.Size(582, 536);
            this.Name = "MainForm";
            this.Text = "Image Converter by Wilson Wu";
            ((System.ComponentModel.ISupportInitialize)(this.nudZoom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSelectFolder;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.NumericUpDown nudZoom;
        private System.Windows.Forms.Button btnToFolder;
        private System.Windows.Forms.TextBox txtToFolder;
        private System.Windows.Forms.TextBox txtReplaceFrom;
        private System.Windows.Forms.TextBox txtReplaceTo;
        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.FolderBrowserDialog SelectFolder;
        private System.Windows.Forms.FolderBrowserDialog ToFolder;
        private System.Windows.Forms.Button btnStartProcessing;
        private System.Windows.Forms.CheckBox cbReplace;
        private System.Windows.Forms.CheckBox cbInsertInStart;
        private System.Windows.Forms.CheckBox cbInsertInEnd;
        private System.Windows.Forms.CheckBox cbRemove;
        private System.Windows.Forms.TextBox txtInsertStart;
        private System.Windows.Forms.TextBox txtInsertEnd;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}

