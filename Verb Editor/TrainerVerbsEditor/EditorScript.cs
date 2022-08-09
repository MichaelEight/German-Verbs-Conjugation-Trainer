using System;
using System.Windows.Forms;

namespace GERMAN_Word_Editor
{
    static class EditorScript
    {
        /// <summary>
        /// Main entry point for application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new editorMainWindow());
        }
    }
}
