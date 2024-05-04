using System;
using System.Collections.Generic;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Bathymetrie.Views.Pages
{
    /// <summary>
    /// Logique d'interaction pour View_DataT_Page.xaml
    /// </summary>
    public partial class View_DataT_Page : Page
    {
        public View_DataT_Page()
        {
            InitializeComponent();
        }
		private void Button_Save_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
				dlg.FileName = "export"; // Nom de fichier par défaut
				dlg.DefaultExt = ".csv"; // Extension de fichier par défaut
				dlg.Filter = "CSV documents (.csv)|*.csv"; // Filtre de fichiers pour n'afficher que les fichiers .csv
				Nullable<bool> result = dlg.ShowDialog();
				// Traite le résultat de la boîte de dialogue
				if (result == true)
				{
					// Chemin d'accès au fichier à enregistrer
					string filename = dlg.FileName;

					// Écriture des données dans le fichier
					using (StreamWriter writer = new StreamWriter(filename))
					{
						// Écrire les en-têtes de colonnes
						var headers = dataGrid.Columns.Select(column => column.Header.ToString()).ToArray();
						writer.WriteLine(string.Join(",", headers));

						// Écrire les données de chaque ligne
						foreach (var item in dataGrid.Items)
						{
							var row = dataGrid.ItemContainerGenerator.ContainerFromItem(item) as DataGridRow;
							if (row != null)
							{
								var cells = dataGrid.Columns.Select(column => new DataGridCellInfo(item, column))
															.Select(info => ((TextBlock)info.Column.GetCellContent(info.Item)).Text)
															.ToArray();
								writer.WriteLine(string.Join(",", cells));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur lors de l'enregistrement du fichier, vérifiez vos valeurs. ", "Avertissement : Bathymetrie", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			
		}

		private void DataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
		{
			if (e.EditAction == DataGridEditAction.Commit)
			{
				TextBox textBox = e.EditingElement as TextBox;
				if (textBox != null)
				{
					double result;
					if (string.IsNullOrWhiteSpace(textBox.Text))
					{
						textBox.Text = "0";
					}
					else if (!Double.TryParse(textBox.Text, CultureInfo.InvariantCulture ,out result))
					{
						textBox.Text = "0";
					}
				}
			}
		}



	}
}
