using System;
using System.Drawing;
using System.Windows.Forms;

namespace Horus
{
    static class Program 
    {
        public static Int32 MaxStreams = 4;
        public static String LogInToken = "";
        public static String Server = "https://server1.proyectohorus.com.ar"; //"server1.proyectohorus.com.ar";
        public static String User = "";
        public static String Password = "";
        public static Boolean IsHide = false;
        public static Boolean NeedChange = false;
        public static Boolean MiniVisor_visible = false;
        public static Image[] PreviewMatrix = new Image[MaxStreams];
        public static Boolean[] Slots = new Boolean[MaxStreams];

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Landing());
        }
    }
}
