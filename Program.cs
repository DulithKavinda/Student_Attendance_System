﻿using Student_Attendace_System.Dashbord;
using Student_Attendace_System.Login_form;
using Student_Attendace_System.PopUpForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Attendace_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);   
            Application.Run(new Dashbord_window());
        }
    }
}
