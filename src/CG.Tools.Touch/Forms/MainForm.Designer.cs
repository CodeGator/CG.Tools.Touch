namespace CG.Tools.Touch.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItemAbout = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            labelFilePath = new Label();
            buttonFileBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            groupBox2 = new GroupBox();
            dateTimePickerCreateTime = new DateTimePicker();
            label3 = new Label();
            dateTimePickerCreateDate = new DateTimePicker();
            dateTimePickerLastWriteTime = new DateTimePicker();
            label1 = new Label();
            dateTimePickerLastWriteDate = new DateTimePicker();
            labelFileDrop = new Label();
            buttonSave = new Button();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(517, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemAbout
            // 
            toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            toolStripMenuItemAbout.Size = new Size(64, 20);
            toolStripMenuItemAbout.Text = "&About ...";
            toolStripMenuItemAbout.Click += toolStripMenuItemAbout_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelFilePath);
            groupBox1.Controls.Add(buttonFileBrowse);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(489, 65);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "File";
            // 
            // labelFilePath
            // 
            labelFilePath.AutoEllipsis = true;
            labelFilePath.Location = new Point(55, 27);
            labelFilePath.Name = "labelFilePath";
            labelFilePath.Size = new Size(413, 23);
            labelFilePath.TabIndex = 1;
            labelFilePath.Text = "No file selected";
            labelFilePath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonFileBrowse
            // 
            buttonFileBrowse.Location = new Point(6, 23);
            buttonFileBrowse.Name = "buttonFileBrowse";
            buttonFileBrowse.Size = new Size(43, 23);
            buttonFileBrowse.TabIndex = 0;
            buttonFileBrowse.Text = "...";
            buttonFileBrowse.UseVisualStyleBackColor = true;
            buttonFileBrowse.Click += buttonFileBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dateTimePickerCreateTime);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(dateTimePickerCreateDate);
            groupBox2.Controls.Add(dateTimePickerLastWriteTime);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(dateTimePickerLastWriteDate);
            groupBox2.Location = new Point(12, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(489, 91);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Properties";
            // 
            // dateTimePickerCreateTime
            // 
            dateTimePickerCreateTime.Enabled = false;
            dateTimePickerCreateTime.Format = DateTimePickerFormat.Time;
            dateTimePickerCreateTime.Location = new Point(362, 51);
            dateTimePickerCreateTime.Name = "dateTimePickerCreateTime";
            dateTimePickerCreateTime.ShowUpDown = true;
            dateTimePickerCreateTime.Size = new Size(113, 23);
            dateTimePickerCreateTime.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 55);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 6;
            label3.Text = "Create Date/Time";
            // 
            // dateTimePickerCreateDate
            // 
            dateTimePickerCreateDate.CustomFormat = "";
            dateTimePickerCreateDate.Enabled = false;
            dateTimePickerCreateDate.Location = new Point(144, 51);
            dateTimePickerCreateDate.Name = "dateTimePickerCreateDate";
            dateTimePickerCreateDate.Size = new Size(200, 23);
            dateTimePickerCreateDate.TabIndex = 7;
            // 
            // dateTimePickerLastWriteTime
            // 
            dateTimePickerLastWriteTime.Enabled = false;
            dateTimePickerLastWriteTime.Format = DateTimePickerFormat.Time;
            dateTimePickerLastWriteTime.Location = new Point(362, 22);
            dateTimePickerLastWriteTime.Name = "dateTimePickerLastWriteTime";
            dateTimePickerLastWriteTime.ShowUpDown = true;
            dateTimePickerLastWriteTime.Size = new Size(113, 23);
            dateTimePickerLastWriteTime.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 0;
            label1.Text = "Last Write Date/Time";
            // 
            // dateTimePickerLastWriteDate
            // 
            dateTimePickerLastWriteDate.CustomFormat = "";
            dateTimePickerLastWriteDate.Enabled = false;
            dateTimePickerLastWriteDate.Location = new Point(144, 22);
            dateTimePickerLastWriteDate.Name = "dateTimePickerLastWriteDate";
            dateTimePickerLastWriteDate.Size = new Size(200, 23);
            dateTimePickerLastWriteDate.TabIndex = 1;
            // 
            // labelFileDrop
            // 
            labelFileDrop.BackColor = SystemColors.Info;
            labelFileDrop.BorderStyle = BorderStyle.FixedSingle;
            labelFileDrop.Dock = DockStyle.Top;
            labelFileDrop.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFileDrop.ForeColor = SystemColors.InfoText;
            labelFileDrop.Location = new Point(0, 24);
            labelFileDrop.Name = "labelFileDrop";
            labelFileDrop.Padding = new Padding(1);
            labelFileDrop.Size = new Size(517, 46);
            labelFileDrop.TabIndex = 0;
            labelFileDrop.Text = "Browse or drop a file then modify the properties, as needed";
            labelFileDrop.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(18, 241);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(472, 54);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save Changes";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 304);
            Controls.Add(buttonSave);
            Controls.Add(labelFileDrop);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Touch Utility";
            DragDrop += MainForm_DragDrop;
            DragEnter += MainForm_DragEnter;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemAbout;
        private GroupBox groupBox1;
        private Label labelFilePath;
        private Button buttonFileBrowse;
        private OpenFileDialog openFileDialog1;
        private GroupBox groupBox2;
        private Label label1;
        private DateTimePicker dateTimePickerLastWriteDate;
        private DateTimePicker dateTimePickerLastWriteTime;
        private Label labelFileDrop;
        private Button buttonSave;
        private DateTimePicker dateTimePickerCreateTime;
        private Label label3;
        private DateTimePicker dateTimePickerCreateDate;
    }
}
