﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    static class Program
    {
//        public static BindingList<Produkt> Produkte = new BindingList<Produkt>();
//        public static BindingList<Category> Kategorien = new BindingList<Category>();

        public static IDatenverwaltung Daten = new Datenbank();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        
        }
    }
}
