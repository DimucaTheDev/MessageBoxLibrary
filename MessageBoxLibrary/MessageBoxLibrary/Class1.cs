using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace MessageBoxLibrary
{
    public class MessageBox
    {
        /// <summary>
        /// "message" = message in a box    
        /// "icon" = icon for box(16=red cross, 32=blue question, 48=yellow warning, 64=blue information)
        /// "subject" = subject in a box.
        /// </summary>
        public static void msgbox(string message = "", int icon = 0, string subject = "")
        {
            try
            {
                File.Create("nothing.vbs").Close();
                File.WriteAllText("nothing.vbs", $"msgbox\"{message}\", {icon} ,\"{subject}\"");
                Process.Start("nothing.vbs");
                Thread.Sleep(100);
                File.Delete("nothidng.vbs");
            }
            catch (Exception)
            {
               
            }
        }
    }
}
