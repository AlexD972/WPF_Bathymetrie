using System.Globalization;
using System.Windows.Controls;


namespace WPF_Bathymetrie.Views.Pages
{
	/// <summary>
	/// Logique d'interaction pour View_Data0_Page.xaml
	/// </summary>
	public partial class View_Data0_Page : Page
	{
		public View_Data0_Page()
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
