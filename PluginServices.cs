using System;
using System.IO;
using System.Reflection;
using PluginInterface;

namespace Horus {
	public class PluginServices : IPluginHost {
		public PluginServices() {

		}

		private AvailablePlugins colAvailablePlugins = new AvailablePlugins();

		public AvailablePlugins AvailablePlugins {
			get { return colAvailablePlugins; }
			set { colAvailablePlugins = value; }
		}

		public void FindPlugins() {
			FindPlugins(AppDomain.CurrentDomain.BaseDirectory);
		}

		public void FindPlugins(string Path) {
			if (!Directory.Exists(Path)) {
				Directory.CreateDirectory(Path);
			}

			colAvailablePlugins.Clear();

			foreach (string fileOn in Directory.GetFiles(Path)) {
				FileInfo file = new FileInfo(fileOn);

				if (file.Extension.Equals(".dll")) {
					this.AddPlugin(fileOn);
				}
			}
		}

		public void ClosePlugins() {
			foreach (AvailablePlugin pluginOn in colAvailablePlugins) {
				pluginOn.Instance.Dispose();

				pluginOn.Instance = null;
			}

			colAvailablePlugins.Clear();
		}

		private void AddPlugin(string FileName) {
			Assembly pluginAssembly = Assembly.LoadFrom(FileName);

			foreach (Type pluginType in pluginAssembly.GetTypes()) {
				if (pluginType.IsPublic) {
					if (!pluginType.IsAbstract) {
						Type typeInterface = pluginType.GetInterface("PluginInterface.IPlugin", true);

						if (typeInterface != null) {
							AvailablePlugin newPlugin = new AvailablePlugin();

							newPlugin.AssemblyPath = FileName;
							newPlugin.Instance = (IPlugin)Activator.CreateInstance(pluginAssembly.GetType(pluginType.ToString()));
							newPlugin.Instance.Host = this;
							newPlugin.Instance.Initialize();

							this.colAvailablePlugins.Add(newPlugin);

							newPlugin = null;
						}

						typeInterface = null;
					}
				}
			}

			pluginAssembly = null;
		}

		public void Feedback(string Feedback, IPlugin Plugin) {

			System.Windows.Forms.Form newForm = null;
			frmFeedback newFeedbackForm = new frmFeedback();

			newFeedbackForm.PluginAuthor = "By: " + Plugin.Author;
			newFeedbackForm.PluginDesc = Plugin.Description;
			newFeedbackForm.PluginName = Plugin.Name;
			newFeedbackForm.PluginVersion = Plugin.Version;
			newFeedbackForm.Feedback = Feedback;

			newForm = newFeedbackForm;
			newForm.ShowDialog();

			newFeedbackForm = null;
			newForm = null;

		}
	}

	public class AvailablePlugins : System.Collections.CollectionBase {
		public void Add(AvailablePlugin pluginToAdd) {
			this.List.Add(pluginToAdd);
		}

		public void Remove(AvailablePlugin pluginToRemove) {
			this.List.Remove(pluginToRemove);
		}

		public AvailablePlugin Find(string pluginNameOrPath) {
			AvailablePlugin toReturn = null;

			foreach (AvailablePlugin pluginOn in this.List) {
				if ((pluginOn.Instance.Name.Equals(pluginNameOrPath)) || pluginOn.AssemblyPath.Equals(pluginNameOrPath)) {
					toReturn = pluginOn;
					break;
				}
			}
			return toReturn;
		}
	}

	public class AvailablePlugin {
		private IPlugin myInstance = null;
		private string myAssemblyPath = "";

		public IPlugin Instance {
			get { return myInstance; }
			set { myInstance = value; }
		}
		public string AssemblyPath {
			get { return myAssemblyPath; }
			set { myAssemblyPath = value; }
		}
	}
}

