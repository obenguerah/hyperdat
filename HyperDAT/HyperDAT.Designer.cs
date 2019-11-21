namespace HyperDAT
{
    partial class HyperDAT
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HyperDAT));
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogXML = new System.Windows.Forms.OpenFileDialog();
            this.buttonSelectXML = new System.Windows.Forms.Button();
            this.textBoxXMLPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWorkDir = new System.Windows.Forms.TextBox();
            this.buttonSelectWorkingFolder = new System.Windows.Forms.Button();
            this.openFileDialogDAT = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogWorking = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxMatching = new System.Windows.Forms.GroupBox();
            this.buttonBuildMatchFile = new System.Windows.Forms.Button();
            this.buttonLaunchFatmatch = new System.Windows.Forms.Button();
            this.buttonCreateFakeFiles = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCueDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonCueRename = new System.Windows.Forms.RadioButton();
            this.buttonMergeDAT = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameMatchesXml = new System.Windows.Forms.TextBox();
            this.buttonSelectNameMatchesXml = new System.Windows.Forms.Button();
            this.openFileDialogNameMatchesXml = new System.Windows.Forms.OpenFileDialog();
            this.listBoxDATPaths = new System.Windows.Forms.ListBox();
            this.buttonAddDAT = new System.Windows.Forms.Button();
            this.buttonRemoveDAT = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxMediaBackup = new System.Windows.Forms.CheckBox();
            this.checkBoxMoveUnknownMedia = new System.Windows.Forms.CheckBox();
            this.buttonListMediaErrors = new System.Windows.Forms.Button();
            this.buttonRenameMedia = new System.Windows.Forms.Button();
            this.buttonMediaFolder = new System.Windows.Forms.Button();
            this.textBoxMediaFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialogMedia = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBoxMatching.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HyperList XML:";
            // 
            // openFileDialogXML
            // 
            this.openFileDialogXML.DefaultExt = "xml";
            this.openFileDialogXML.Filter = "HyperList XML (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // buttonSelectXML
            // 
            this.buttonSelectXML.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectXML.Location = new System.Drawing.Point(787, 11);
            this.buttonSelectXML.Name = "buttonSelectXML";
            this.buttonSelectXML.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectXML.TabIndex = 1;
            this.buttonSelectXML.Text = "Select";
            this.buttonSelectXML.UseVisualStyleBackColor = true;
            this.buttonSelectXML.Click += new System.EventHandler(this.buttonSelectXML_Click);
            // 
            // textBoxXMLPath
            // 
            this.textBoxXMLPath.AllowDrop = true;
            this.textBoxXMLPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxXMLPath.Location = new System.Drawing.Point(90, 12);
            this.textBoxXMLPath.Name = "textBoxXMLPath";
            this.textBoxXMLPath.Size = new System.Drawing.Size(691, 20);
            this.textBoxXMLPath.TabIndex = 2;
            this.textBoxXMLPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxXMLPath_DragDrop);
            this.textBoxXMLPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxXMLPath_DragEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DAT Files:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Working Folder:";
            // 
            // textBoxWorkDir
            // 
            this.textBoxWorkDir.AcceptsReturn = true;
            this.textBoxWorkDir.AllowDrop = true;
            this.textBoxWorkDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWorkDir.Location = new System.Drawing.Point(90, 163);
            this.textBoxWorkDir.Name = "textBoxWorkDir";
            this.textBoxWorkDir.Size = new System.Drawing.Size(691, 20);
            this.textBoxWorkDir.TabIndex = 6;
            this.textBoxWorkDir.Text = "X:\\Roms\\__HYPERDAT";
            this.textBoxWorkDir.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxWorkDir_DragDrop);
            this.textBoxWorkDir.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxWorkDir_DragEnter);
            // 
            // buttonSelectWorkingFolder
            // 
            this.buttonSelectWorkingFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectWorkingFolder.Location = new System.Drawing.Point(787, 161);
            this.buttonSelectWorkingFolder.Name = "buttonSelectWorkingFolder";
            this.buttonSelectWorkingFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectWorkingFolder.TabIndex = 8;
            this.buttonSelectWorkingFolder.Text = "Select";
            this.buttonSelectWorkingFolder.UseVisualStyleBackColor = true;
            this.buttonSelectWorkingFolder.Click += new System.EventHandler(this.buttonSelectWorkingFolder_Click);
            // 
            // openFileDialogDAT
            // 
            this.openFileDialogDAT.DefaultExt = "dat";
            this.openFileDialogDAT.FileName = "openFileDialog1";
            this.openFileDialogDAT.Filter = "Clrmamepro DAT (*.dat)|*.dat|All files (*.*)|*.*";
            this.openFileDialogDAT.Multiselect = true;
            // 
            // groupBoxMatching
            // 
            this.groupBoxMatching.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMatching.Controls.Add(this.buttonBuildMatchFile);
            this.groupBoxMatching.Controls.Add(this.buttonLaunchFatmatch);
            this.groupBoxMatching.Controls.Add(this.buttonCreateFakeFiles);
            this.groupBoxMatching.Location = new System.Drawing.Point(116, 203);
            this.groupBoxMatching.Name = "groupBoxMatching";
            this.groupBoxMatching.Size = new System.Drawing.Size(623, 91);
            this.groupBoxMatching.TabIndex = 9;
            this.groupBoxMatching.TabStop = false;
            this.groupBoxMatching.Text = "Name matching";
            // 
            // buttonBuildMatchFile
            // 
            this.buttonBuildMatchFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBuildMatchFile.Location = new System.Drawing.Point(425, 23);
            this.buttonBuildMatchFile.Name = "buttonBuildMatchFile";
            this.buttonBuildMatchFile.Size = new System.Drawing.Size(132, 46);
            this.buttonBuildMatchFile.TabIndex = 2;
            this.buttonBuildMatchFile.Text = "Build Match File";
            this.buttonBuildMatchFile.UseVisualStyleBackColor = true;
            this.buttonBuildMatchFile.Click += new System.EventHandler(this.buttonBuildMatchFile_Click);
            // 
            // buttonLaunchFatmatch
            // 
            this.buttonLaunchFatmatch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLaunchFatmatch.Location = new System.Drawing.Point(265, 23);
            this.buttonLaunchFatmatch.Name = "buttonLaunchFatmatch";
            this.buttonLaunchFatmatch.Size = new System.Drawing.Size(132, 46);
            this.buttonLaunchFatmatch.TabIndex = 1;
            this.buttonLaunchFatmatch.Text = "Launch Fatmatch";
            this.buttonLaunchFatmatch.UseVisualStyleBackColor = true;
            this.buttonLaunchFatmatch.Click += new System.EventHandler(this.buttonLaunchFatmatch_Click);
            // 
            // buttonCreateFakeFiles
            // 
            this.buttonCreateFakeFiles.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCreateFakeFiles.Location = new System.Drawing.Point(105, 23);
            this.buttonCreateFakeFiles.Name = "buttonCreateFakeFiles";
            this.buttonCreateFakeFiles.Size = new System.Drawing.Size(132, 46);
            this.buttonCreateFakeFiles.TabIndex = 0;
            this.buttonCreateFakeFiles.Text = "Create Fake Files";
            this.buttonCreateFakeFiles.UseVisualStyleBackColor = true;
            this.buttonCreateFakeFiles.Click += new System.EventHandler(this.buttonCreateFakeFiles_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonCueDelete);
            this.groupBox1.Controls.Add(this.radioButtonCueRename);
            this.groupBox1.Controls.Add(this.buttonMergeDAT);
            this.groupBox1.Location = new System.Drawing.Point(116, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(623, 91);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Merged DAT Generator";
            // 
            // radioButtonCueDelete
            // 
            this.radioButtonCueDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonCueDelete.AutoSize = true;
            this.radioButtonCueDelete.Location = new System.Drawing.Point(105, 47);
            this.radioButtonCueDelete.Name = "radioButtonCueDelete";
            this.radioButtonCueDelete.Size = new System.Drawing.Size(200, 17);
            this.radioButtonCueDelete.TabIndex = 16;
            this.radioButtonCueDelete.Text = "Remove .cue (one track / no names)";
            this.radioButtonCueDelete.UseVisualStyleBackColor = true;
            // 
            // radioButtonCueRename
            // 
            this.radioButtonCueRename.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonCueRename.AutoSize = true;
            this.radioButtonCueRename.Checked = true;
            this.radioButtonCueRename.Location = new System.Drawing.Point(105, 29);
            this.radioButtonCueRename.Name = "radioButtonCueRename";
            this.radioButtonCueRename.Size = new System.Drawing.Size(221, 17);
            this.radioButtonCueRename.TabIndex = 15;
            this.radioButtonCueRename.TabStop = true;
            this.radioButtonCueRename.Text = "Only rename .cue (multi track with names)";
            this.radioButtonCueRename.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.radioButtonCueRename.UseVisualStyleBackColor = true;
            // 
            // buttonMergeDAT
            // 
            this.buttonMergeDAT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonMergeDAT.Location = new System.Drawing.Point(425, 29);
            this.buttonMergeDAT.Name = "buttonMergeDAT";
            this.buttonMergeDAT.Size = new System.Drawing.Size(132, 46);
            this.buttonMergeDAT.TabIndex = 14;
            this.buttonMergeDAT.Text = "Build merged DAT";
            this.buttonMergeDAT.UseVisualStyleBackColor = true;
            this.buttonMergeDAT.Click += new System.EventHandler(this.buttonMergeDAT_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Matches XML:";
            // 
            // textBoxNameMatchesXml
            // 
            this.textBoxNameMatchesXml.AllowDrop = true;
            this.textBoxNameMatchesXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNameMatchesXml.Location = new System.Drawing.Point(90, 320);
            this.textBoxNameMatchesXml.Name = "textBoxNameMatchesXml";
            this.textBoxNameMatchesXml.Size = new System.Drawing.Size(691, 20);
            this.textBoxNameMatchesXml.TabIndex = 12;
            this.textBoxNameMatchesXml.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxNameMatchesXml_DragDrop);
            this.textBoxNameMatchesXml.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxNameMatchesXml_DragEnter);
            // 
            // buttonSelectNameMatchesXml
            // 
            this.buttonSelectNameMatchesXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectNameMatchesXml.Location = new System.Drawing.Point(787, 319);
            this.buttonSelectNameMatchesXml.Name = "buttonSelectNameMatchesXml";
            this.buttonSelectNameMatchesXml.Size = new System.Drawing.Size(75, 23);
            this.buttonSelectNameMatchesXml.TabIndex = 13;
            this.buttonSelectNameMatchesXml.Text = "Select";
            this.buttonSelectNameMatchesXml.UseVisualStyleBackColor = true;
            this.buttonSelectNameMatchesXml.Click += new System.EventHandler(this.buttonSelectNameMatchesXml_Click);
            // 
            // openFileDialogNameMatchesXml
            // 
            this.openFileDialogNameMatchesXml.DefaultExt = "xml";
            this.openFileDialogNameMatchesXml.Filter = "Name matches XML (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // listBoxDATPaths
            // 
            this.listBoxDATPaths.AllowDrop = true;
            this.listBoxDATPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxDATPaths.FormattingEnabled = true;
            this.listBoxDATPaths.Location = new System.Drawing.Point(90, 42);
            this.listBoxDATPaths.Name = "listBoxDATPaths";
            this.listBoxDATPaths.Size = new System.Drawing.Size(691, 82);
            this.listBoxDATPaths.TabIndex = 14;
            this.listBoxDATPaths.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBoxDATPaths_DragDrop);
            this.listBoxDATPaths.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxDATPaths_DragEnter);
            // 
            // buttonAddDAT
            // 
            this.buttonAddDAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddDAT.Location = new System.Drawing.Point(787, 40);
            this.buttonAddDAT.Name = "buttonAddDAT";
            this.buttonAddDAT.Size = new System.Drawing.Size(75, 23);
            this.buttonAddDAT.TabIndex = 7;
            this.buttonAddDAT.Text = "Add";
            this.buttonAddDAT.UseVisualStyleBackColor = true;
            this.buttonAddDAT.Click += new System.EventHandler(this.buttonAddDAT_Click);
            // 
            // buttonRemoveDAT
            // 
            this.buttonRemoveDAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveDAT.Location = new System.Drawing.Point(787, 66);
            this.buttonRemoveDAT.Name = "buttonRemoveDAT";
            this.buttonRemoveDAT.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveDAT.TabIndex = 15;
            this.buttonRemoveDAT.Text = "Remove";
            this.buttonRemoveDAT.UseVisualStyleBackColor = true;
            this.buttonRemoveDAT.Click += new System.EventHandler(this.buttonRemoveDAT_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.checkBoxMediaBackup);
            this.groupBox2.Controls.Add(this.checkBoxMoveUnknownMedia);
            this.groupBox2.Controls.Add(this.buttonListMediaErrors);
            this.groupBox2.Controls.Add(this.buttonRenameMedia);
            this.groupBox2.Location = new System.Drawing.Point(116, 514);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 91);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Media management";
            // 
            // checkBoxMediaBackup
            // 
            this.checkBoxMediaBackup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxMediaBackup.AutoSize = true;
            this.checkBoxMediaBackup.Location = new System.Drawing.Point(243, 35);
            this.checkBoxMediaBackup.Name = "checkBoxMediaBackup";
            this.checkBoxMediaBackup.Size = new System.Drawing.Size(63, 17);
            this.checkBoxMediaBackup.TabIndex = 3;
            this.checkBoxMediaBackup.Text = "Backup";
            this.checkBoxMediaBackup.UseVisualStyleBackColor = true;
            // 
            // checkBoxMoveUnknownMedia
            // 
            this.checkBoxMoveUnknownMedia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBoxMoveUnknownMedia.AutoSize = true;
            this.checkBoxMoveUnknownMedia.Checked = true;
            this.checkBoxMoveUnknownMedia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMoveUnknownMedia.Location = new System.Drawing.Point(495, 35);
            this.checkBoxMoveUnknownMedia.Name = "checkBoxMoveUnknownMedia";
            this.checkBoxMoveUnknownMedia.Size = new System.Drawing.Size(105, 17);
            this.checkBoxMoveUnknownMedia.TabIndex = 2;
            this.checkBoxMoveUnknownMedia.Text = "Move unknowns";
            this.checkBoxMoveUnknownMedia.UseVisualStyleBackColor = true;
            // 
            // buttonListMediaErrors
            // 
            this.buttonListMediaErrors.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonListMediaErrors.Location = new System.Drawing.Point(335, 19);
            this.buttonListMediaErrors.Name = "buttonListMediaErrors";
            this.buttonListMediaErrors.Size = new System.Drawing.Size(132, 46);
            this.buttonListMediaErrors.TabIndex = 1;
            this.buttonListMediaErrors.Text = "List missings and unknowns";
            this.buttonListMediaErrors.UseVisualStyleBackColor = true;
            this.buttonListMediaErrors.Click += new System.EventHandler(this.buttonListMediaErrors_Click);
            // 
            // buttonRenameMedia
            // 
            this.buttonRenameMedia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRenameMedia.Location = new System.Drawing.Point(105, 19);
            this.buttonRenameMedia.Name = "buttonRenameMedia";
            this.buttonRenameMedia.Size = new System.Drawing.Size(132, 46);
            this.buttonRenameMedia.TabIndex = 0;
            this.buttonRenameMedia.Text = "Rename medias";
            this.buttonRenameMedia.UseVisualStyleBackColor = true;
            this.buttonRenameMedia.Click += new System.EventHandler(this.buttonRenameMedia_Click);
            // 
            // buttonMediaFolder
            // 
            this.buttonMediaFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMediaFolder.Location = new System.Drawing.Point(787, 473);
            this.buttonMediaFolder.Name = "buttonMediaFolder";
            this.buttonMediaFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonMediaFolder.TabIndex = 19;
            this.buttonMediaFolder.Text = "Select";
            this.buttonMediaFolder.UseVisualStyleBackColor = true;
            this.buttonMediaFolder.Click += new System.EventHandler(this.buttonMediaFolder_Click);
            // 
            // textBoxMediaFolder
            // 
            this.textBoxMediaFolder.AllowDrop = true;
            this.textBoxMediaFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMediaFolder.Location = new System.Drawing.Point(90, 474);
            this.textBoxMediaFolder.Name = "textBoxMediaFolder";
            this.textBoxMediaFolder.Size = new System.Drawing.Size(691, 20);
            this.textBoxMediaFolder.TabIndex = 18;
            this.textBoxMediaFolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxMediaFolder_DragDrop);
            this.textBoxMediaFolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxMediaFolder_DragEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 477);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Media folder:";
            // 
            // HyperDAT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 612);
            this.Controls.Add(this.buttonMediaFolder);
            this.Controls.Add(this.textBoxMediaFolder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonRemoveDAT);
            this.Controls.Add(this.listBoxDATPaths);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSelectNameMatchesXml);
            this.Controls.Add(this.groupBoxMatching);
            this.Controls.Add(this.textBoxNameMatchesXml);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSelectWorkingFolder);
            this.Controls.Add(this.buttonAddDAT);
            this.Controls.Add(this.textBoxWorkDir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxXMLPath);
            this.Controls.Add(this.buttonSelectXML);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1500, 650);
            this.MinimumSize = new System.Drawing.Size(900, 650);
            this.Name = "HyperDAT";
            this.Text = "HyperDAT";
            this.groupBoxMatching.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialogXML;
        private System.Windows.Forms.Button buttonSelectXML;
        private System.Windows.Forms.TextBox textBoxXMLPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWorkDir;
        private System.Windows.Forms.Button buttonSelectWorkingFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialogDAT;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogWorking;
        private System.Windows.Forms.GroupBox groupBoxMatching;
        private System.Windows.Forms.Button buttonCreateFakeFiles;
        private System.Windows.Forms.Button buttonLaunchFatmatch;
        private System.Windows.Forms.Button buttonBuildMatchFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSelectNameMatchesXml;
        private System.Windows.Forms.TextBox textBoxNameMatchesXml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonMergeDAT;
        private System.Windows.Forms.OpenFileDialog openFileDialogNameMatchesXml;
        private System.Windows.Forms.ListBox listBoxDATPaths;
        private System.Windows.Forms.Button buttonAddDAT;
        private System.Windows.Forms.Button buttonRemoveDAT;
        private System.Windows.Forms.RadioButton radioButtonCueDelete;
        private System.Windows.Forms.RadioButton radioButtonCueRename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonListMediaErrors;
        private System.Windows.Forms.Button buttonRenameMedia;
        private System.Windows.Forms.Button buttonMediaFolder;
        private System.Windows.Forms.TextBox textBoxMediaFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxMoveUnknownMedia;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMedia;
        private System.Windows.Forms.CheckBox checkBoxMediaBackup;
    }
}

