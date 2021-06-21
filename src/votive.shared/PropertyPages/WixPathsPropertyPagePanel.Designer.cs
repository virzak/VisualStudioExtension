// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.VisualStudioExtension.PropertyPages
{
    using WixToolset.VisualStudioExtension.Controls;

    partial class WixPathsPropertyPagePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WixPathsPropertyPagePanel));
            this.referencePathsFoldersSelector = new FoldersSelector();
            this.referencePathsGroupBox = new WixGroupBox();
            this.includePathsGroupBox = new WixGroupBox();
            this.includePathsFolderSelector = new FoldersSelector();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.referencePathsGroupBox.SuspendLayout();
            this.includePathsGroupBox.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // referencePathsFoldersSelector
            // 
            resources.ApplyResources(this.referencePathsFoldersSelector, "referencePathsFoldersSelector");
            this.referencePathsFoldersSelector.Name = "referencePathsFoldersSelector";
            // 
            // referencePathsGroupBox
            // 
            resources.ApplyResources(this.referencePathsGroupBox, "referencePathsGroupBox");
            this.referencePathsGroupBox.Controls.Add(this.referencePathsFoldersSelector);
            this.referencePathsGroupBox.Name = "referencePathsGroupBox";
            // 
            // includePathsGroupBox
            // 
            resources.ApplyResources(this.includePathsGroupBox, "includePathsGroupBox");
            this.includePathsGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.includePathsGroupBox.Controls.Add(this.includePathsFolderSelector);
            this.includePathsGroupBox.Name = "includePathsGroupBox";
            // todo: this.includePathsGroupBox.Resize += new System.EventHandler(this.IncludePathsGroupBox_Resize);
            // 
            // includePathsFolderSelector
            // 
            resources.ApplyResources(this.includePathsFolderSelector, "includePathsFolderSelector");
            this.includePathsFolderSelector.BackColor = System.Drawing.SystemColors.Control;
            this.includePathsFolderSelector.Name = "includePathsFolderSelector";
            // 
            // mainTableLayoutPanel
            // 
            resources.ApplyResources(this.mainTableLayoutPanel, "mainTableLayoutPanel");
            this.mainTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainTableLayoutPanel.Controls.Add(this.includePathsGroupBox, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.referencePathsGroupBox, 0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            // 
            // WixPathsPropertyPagePanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.mainTableLayoutPanel);
            this.MinimumSize = new System.Drawing.Size(344, 447);
            this.Name = "WixPathsPropertyPagePanel";
            // todo: this.Resize += new System.EventHandler(this.WixPathsPropertyPagePanel_Resize);
            this.referencePathsGroupBox.ResumeLayout(false);
            this.includePathsGroupBox.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FoldersSelector referencePathsFoldersSelector;
        private WixGroupBox referencePathsGroupBox;
        private WixGroupBox includePathsGroupBox;
        private FoldersSelector includePathsFolderSelector;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
    }
}
