namespace UE4DiffAssistTool
{
    partial class DiffAssist
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
            this.txtEditorPath = new System.Windows.Forms.TextBox();
            this.lblEditorPath = new System.Windows.Forms.Label();
            this.lblOldFile = new System.Windows.Forms.Label();
            this.lblNewFile = new System.Windows.Forms.Label();
            this.txtOldFile = new System.Windows.Forms.TextBox();
            this.txtNewFile = new System.Windows.Forms.TextBox();
            this.btnDiff = new System.Windows.Forms.Button();
            this.btnShowDiff = new System.Windows.Forms.Button();
            this.txtDiffCommand = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtProjectFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEditorPath
            // 
            this.txtEditorPath.AllowDrop = true;
            this.txtEditorPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEditorPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UE4DiffAssistTool.Properties.Settings.Default, "UE4EditorPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtEditorPath.Location = new System.Drawing.Point(147, 50);
            this.txtEditorPath.Name = "txtEditorPath";
            this.txtEditorPath.Size = new System.Drawing.Size(413, 20);
            this.txtEditorPath.TabIndex = 0;
            this.txtEditorPath.Text = global::UE4DiffAssistTool.Properties.Settings.Default.UE4EditorPath;
            this.txtEditorPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtEditorPath_DragDrop);
            this.txtEditorPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile_DragEnter);
            // 
            // lblEditorPath
            // 
            this.lblEditorPath.AutoSize = true;
            this.lblEditorPath.Location = new System.Drawing.Point(12, 53);
            this.lblEditorPath.Name = "lblEditorPath";
            this.lblEditorPath.Size = new System.Drawing.Size(129, 13);
            this.lblEditorPath.TabIndex = 1;
            this.lblEditorPath.Text = "Unreal Engine Editor Path";
            // 
            // lblOldFile
            // 
            this.lblOldFile.AutoSize = true;
            this.lblOldFile.Location = new System.Drawing.Point(12, 118);
            this.lblOldFile.Name = "lblOldFile";
            this.lblOldFile.Size = new System.Drawing.Size(42, 13);
            this.lblOldFile.TabIndex = 2;
            this.lblOldFile.Text = "Old File";
            // 
            // lblNewFile
            // 
            this.lblNewFile.AutoSize = true;
            this.lblNewFile.Location = new System.Drawing.Point(12, 144);
            this.lblNewFile.Name = "lblNewFile";
            this.lblNewFile.Size = new System.Drawing.Size(48, 13);
            this.lblNewFile.TabIndex = 3;
            this.lblNewFile.Text = "New File";
            // 
            // txtOldFile
            // 
            this.txtOldFile.AllowDrop = true;
            this.txtOldFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOldFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UE4DiffAssistTool.Properties.Settings.Default, "LastOldFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtOldFile.Location = new System.Drawing.Point(74, 115);
            this.txtOldFile.Name = "txtOldFile";
            this.txtOldFile.Size = new System.Drawing.Size(486, 20);
            this.txtOldFile.TabIndex = 5;
            this.txtOldFile.Text = global::UE4DiffAssistTool.Properties.Settings.Default.LastOldFile;
            this.txtOldFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_DragDrop);
            this.txtOldFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile_DragEnter);
            // 
            // txtNewFile
            // 
            this.txtNewFile.AllowDrop = true;
            this.txtNewFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UE4DiffAssistTool.Properties.Settings.Default, "LastNewFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtNewFile.Location = new System.Drawing.Point(74, 141);
            this.txtNewFile.Name = "txtNewFile";
            this.txtNewFile.Size = new System.Drawing.Size(486, 20);
            this.txtNewFile.TabIndex = 6;
            this.txtNewFile.Text = global::UE4DiffAssistTool.Properties.Settings.Default.LastNewFile;
            this.txtNewFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_DragDrop);
            this.txtNewFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile_DragEnter);
            // 
            // btnDiff
            // 
            this.btnDiff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiff.Location = new System.Drawing.Point(485, 167);
            this.btnDiff.Name = "btnDiff";
            this.btnDiff.Size = new System.Drawing.Size(75, 23);
            this.btnDiff.TabIndex = 7;
            this.btnDiff.Text = "Diff Files";
            this.btnDiff.UseVisualStyleBackColor = true;
            this.btnDiff.Click += new System.EventHandler(this.btnDiff_Click);
            // 
            // btnShowDiff
            // 
            this.btnShowDiff.Location = new System.Drawing.Point(12, 167);
            this.btnShowDiff.Name = "btnShowDiff";
            this.btnShowDiff.Size = new System.Drawing.Size(150, 23);
            this.btnShowDiff.TabIndex = 9;
            this.btnShowDiff.Text = "Show Diff Command";
            this.btnShowDiff.UseVisualStyleBackColor = true;
            this.btnShowDiff.Click += new System.EventHandler(this.btnShowDiff_Click);
            // 
            // txtDiffCommand
            // 
            this.txtDiffCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiffCommand.Location = new System.Drawing.Point(12, 196);
            this.txtDiffCommand.MaxLength = 65535;
            this.txtDiffCommand.Multiline = true;
            this.txtDiffCommand.Name = "txtDiffCommand";
            this.txtDiffCommand.ReadOnly = true;
            this.txtDiffCommand.Size = new System.Drawing.Size(548, 150);
            this.txtDiffCommand.TabIndex = 10;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(12, 18);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(431, 13);
            this.lblInstructions.TabIndex = 11;
            this.lblInstructions.Text = "Instructions: Drag and Drop files to the boxes below. Click on Diff Files button " +
    "when ready.";
            // 
            // txtProjectFile
            // 
            this.txtProjectFile.AllowDrop = true;
            this.txtProjectFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProjectFile.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UE4DiffAssistTool.Properties.Settings.Default, "ProjectFile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.txtProjectFile.Location = new System.Drawing.Point(74, 89);
            this.txtProjectFile.Name = "txtProjectFile";
            this.txtProjectFile.Size = new System.Drawing.Size(486, 20);
            this.txtProjectFile.TabIndex = 13;
            this.txtProjectFile.Text = global::UE4DiffAssistTool.Properties.Settings.Default.ProjectFile;
            this.txtProjectFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.File_DragDrop);
            this.txtProjectFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtFile_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Project File";
            // 
            // DiffAssist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 358);
            this.Controls.Add(this.txtProjectFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtDiffCommand);
            this.Controls.Add(this.btnShowDiff);
            this.Controls.Add(this.btnDiff);
            this.Controls.Add(this.txtNewFile);
            this.Controls.Add(this.txtOldFile);
            this.Controls.Add(this.lblNewFile);
            this.Controls.Add(this.lblOldFile);
            this.Controls.Add(this.lblEditorPath);
            this.Controls.Add(this.txtEditorPath);
            this.MinimumSize = new System.Drawing.Size(470, 250);
            this.Name = "DiffAssist";
            this.Text = "Unreal Engine 4 Diff Assist Tool";
            this.Load += new System.EventHandler(this.DiffAssist_Load);
            this.ResizeEnd += new System.EventHandler(this.DiffAssist_ResizeEnd);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditorPath;
        private System.Windows.Forms.Label lblEditorPath;
        private System.Windows.Forms.Label lblOldFile;
        private System.Windows.Forms.Label lblNewFile;
        private System.Windows.Forms.TextBox txtOldFile;
        private System.Windows.Forms.TextBox txtNewFile;
        private System.Windows.Forms.Button btnDiff;
        private System.Windows.Forms.Button btnShowDiff;
        private System.Windows.Forms.TextBox txtDiffCommand;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtProjectFile;
        private System.Windows.Forms.Label label1;
    }
}

