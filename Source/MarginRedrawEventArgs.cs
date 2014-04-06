using System;
using System.Collections.Generic;

using Microsoft.TeamFoundation.Diff;

namespace AlekseyNagovitsyn.TfsPendingChangesMargin
{
    /// <summary>
    /// Arguments for event that raised when margin needs to be redrawn.
    /// </summary>
    internal class MarginRedrawEventArgs : EventArgs
    {
        /// <summary>
        /// Differences between the current document and the version in TFS.
        /// </summary>
        private readonly Dictionary<int, DiffChangeType> _diffLines;

        /// <summary>
        /// Gets differences between the current document and the version in TFS.
        /// </summary>
        public Dictionary<int, DiffChangeType> DiffLines
        {
            get { return _diffLines; }
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="MarginRedrawEventArgs"/> class.
        /// </summary>
        /// <param name="diffLines">Differences between the current document and the version in TFS.</param>
        public MarginRedrawEventArgs(Dictionary<int, DiffChangeType> diffLines)
        {
            _diffLines = diffLines;
        }
    }
}