﻿#region BSD License
/*
 * 
 * Original BSD 3-Clause License (https://github.com/ComponentFactory/Krypton/blob/master/LICENSE)
 *  © Component Factory Pty Ltd, 2006 - 2016, (Version 4.5.0.0) All rights reserved.
 * 
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2023. All rights reserved. 
 *  
 */
#endregion

namespace Krypton.Toolkit
{
    internal static class DebugTools
    {
        #region Implementation
        internal static void NotImplemented(string methodSignature, string className, int lineNumber = 0)
        {
            KryptonCommand linkCommand = new KryptonCommand();

            linkCommand.Execute += (sender, args) => { Process.Start(@"https://github.com/Krypton-Suite/Standard-Toolkit/issues/new/choose"); };

            if (lineNumber > 0)
            {
                KryptonMessageBox.Show($"If you are seeing this message, please submit a new bug report here.\n\nAdditional details:-\nMethod Signature: {methodSignature}\nClass Name: {className}\nLine Number: {lineNumber}",
                    "Not Implemented", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error, contentAreaType: MessageBoxContentAreaType.LinkLabel, actionButtonCommand: linkCommand, contentLinkArea: new LinkArea(64, 67));
            }
            else
            {
                KryptonMessageBox.Show($"If you are seeing this message, please submit a new bug report here.\n\nAdditional details:-\nMethod Signature: {methodSignature}\nClass Name: {className}",
                    "Not Implemented", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }
        #endregion
    }
}