using System;
using PluginInterface;
using System.IO;

namespace Inmediata {
	public class Plugin : IPlugin {
		public Plugin() {

		}

		public static String myName = "Inmediata";
		public static String myDescription = "Muestra los datos provenientes del servidor";
		public static String myAuthor = "Fernando P. Maniglia";
		public static String myVersion = "1.0.0";

		public static String GlobalValue;
		public static MemoryStream ImageStream;


		IPluginHost myHost = null;
		System.Windows.Forms.UserControl myMainInterface = new ctlMain();


		public string Description {
			get { return myDescription; }
		}

		public string Author {
			get { return myAuthor; }
		}

		public IPluginHost Host {
			get { return myHost; }
			set { myHost = value; }
		}

		public string Name {
			get { return myName; }
		}

		public System.Windows.Forms.UserControl MainInterface {
			get { return myMainInterface; }
		}

		public string Version {
			get { return myVersion; }
		}

		public void Initialize() {

		}

		public void Dispose() {

		}

		public MemoryStream Frame {
			set { ImageStream = value; }
		}

		public string Input {
			set { GlobalValue = value; }
		}

		public string Output {
			get { return GlobalValue; }
		}
	}
}
