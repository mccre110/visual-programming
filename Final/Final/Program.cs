using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Final
{

    static class Program
    {
        public static SplashForm splashForm;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //show splash
            Thread splashThread = new Thread(new ThreadStart(
            delegate
            {
                splashForm = new SplashForm();
                Application.Run(splashForm);
            }
            ));

            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            //run form - time taking operation
            RadForm1 mainForm = new RadForm1();
            mainForm.Load += new EventHandler(mainForm_Load);
            Application.Run(mainForm);
        }
        static void mainForm_Load(object sender, EventArgs e)
        {
            //close splash
            if (splashForm == null)
            {
                return;
            }

            splashForm.Invoke(new Action(splashForm.Close));
            splashForm.Dispose();
            splashForm = null;
        }
    }
}