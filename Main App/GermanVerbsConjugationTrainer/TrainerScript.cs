﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GERMAN_Trainer
{
    static class TrainerScript
    {
        /// <summary>
        /// Main entry point for application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new trainerLoginWindow()); // Disabled login
            Application.Run(new MainWindow());
        }
    }
}
