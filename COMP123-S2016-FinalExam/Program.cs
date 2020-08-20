using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    public static class Program
    {
        public static Character character;
        public static GenerateNameForm generateNameForm;
        public static SplashForm splashForm;
        public static AbilityGeneratorForm abilityGeneratorForm;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            generateNameForm = new GenerateNameForm();
            splashForm = new SplashForm();
            character = new Character();
            abilityGeneratorForm = new AbilityGeneratorForm();

            Application.Run(splashForm);
        }
    }
}
