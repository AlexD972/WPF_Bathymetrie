using System;
using System.Collections.Generic;
using System.Globalization;
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
    public partial class View_Prevision_Page : Page
    {
        public View_Prevision_Page()
        {
            InitializeComponent();
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
					else if (!Double.TryParse(textBox.Text, CultureInfo.InvariantCulture, out result))
					{
						textBox.Text = "0";
					}
				}
			}
		}
	}
}
