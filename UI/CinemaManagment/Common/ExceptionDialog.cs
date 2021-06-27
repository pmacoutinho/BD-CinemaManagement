using System;
using System.Windows.Forms;

namespace CinemaManagment.Common
{
    public class ExceptionDialog
    {
        public static void ExDialog(Exception exception)
        {
            MessageBox.Show(exception.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine(exception);
        }
    }
}