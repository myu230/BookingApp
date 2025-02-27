﻿using BookingLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application. 
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize database connector
            BookingLibrary.GlobalConfig.InitializeConnections(DatabaseType.Sql);

            Application.Run(new ApptViewingForm());
           // Application.Run(new ApptBookingForm());
        }
    }
}
