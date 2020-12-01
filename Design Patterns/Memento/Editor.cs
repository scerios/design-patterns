using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Memento
{
    public class Editor
    {
        public string Content { get; set; }

        /// <summary>
        /// Stores the current content as a state.
        /// </summary>
        /// <returns>The content as a state.</returns>
        public EditorState CreateState()
        {
            return new EditorState(Content);
        }

        /// <summary>
        /// Restores the current state to the selected one.
        /// </summary>
        /// <param name="state">The wished state which should be restored to.</param>
        public void Restore(EditorState state)
        {
            Content = state.Content;
        }
    }
}
