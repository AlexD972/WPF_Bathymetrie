using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WPF_Bathymetrie.Styles;

namespace WPF_Bathymetrie.Views.Windows
{
	/// <summary>
	/// Logique d'interaction pour View_MainWindow.xaml
	/// </summary>
	public partial class View_MainWindow : Window
	{
		public View_MainWindow()
		{
			InitializeComponent();
			Accueil.IsSelected = true;
		}
		protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
		{
			MessageBoxResult result = MessageBox.Show(
				"Voulez-vous vraiment quitter ?", "Avertissement : FLOPHIB",
				MessageBoxButton.OKCancel);
			if (result == MessageBoxResult.Cancel)
			{
				e.Cancel = true;
			}
			else
			{
				Environment.Exit(0); //pour quitter proprement et ne pas garder le processus en arrière plan
			}
			base.OnClosing(e);
		}
		private void Button_Capture_Click(object sender, RoutedEventArgs e)
		{
			Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
			dlg.FileName = "Capture_";
			dlg.DefaultExt = ".jpg";
			dlg.Filter = "Fichier JPEG (.jpg)|*.jpg";


			var screenshot = new RenderTargetBitmap((int)SystemParameters.VirtualScreenWidth, (int)SystemParameters.VirtualScreenHeight, 96, 96, PixelFormats.Pbgra32);
			var bounds = new Size(SystemParameters.VirtualScreenWidth, SystemParameters.VirtualScreenHeight);
			var dv = new DrawingVisual();

			Nullable<bool> result = dlg.ShowDialog();

			if (result == true)
			{
				string filename = dlg.FileName;

				using (var dc = dv.RenderOpen())
				{
					dc.DrawRectangle(new VisualBrush(this), null, new Rect(new Point(), bounds));
				}
				screenshot.Render(dv);

				var encoder = new BmpBitmapEncoder();
				encoder.Frames.Add(BitmapFrame.Create(screenshot));

				using (var stream = new FileStream(filename, FileMode.Create))
				{
					encoder.Save(stream);
				}
			}
		}
		private void SideMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (SideMenu.SelectedItem is NavButton selectedButton)
			{
				navFrame.Navigate(selectedButton.NavLink);
			}
		}
		private void SideMenu_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Back)
			{
				e.Handled = true;
			}
		}
	}
}
