// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.VisualStudioExtension.PropertyPages
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    /// <summary>
    /// Property page contents for the Paths property page
    /// </summary>
    /// 
    internal partial class WixPathsPropertyPagePanel : WixPropertyPagePanel
    {
        // =========================================================================================
        // Constructors
        // =========================================================================================

        /// <summary>
        /// Initilizes a new instance of the WixPathsPropertyPagePanel class
        /// </summary>
        /// <param name="parentPropertyPage">The parent property page to which this is bound</param>
        public WixPathsPropertyPagePanel(WixPropertyPage parentPropertyPage)
            : base(parentPropertyPage)
        {
            this.InitializeComponent();

            this.referencePathsFoldersSelector.Tag = WixProjectFileConstants.ReferencePaths;
            this.includePathsFolderSelector.Tag = WixProjectFileConstants.IncludeSearchPaths;
        }
    }
}
