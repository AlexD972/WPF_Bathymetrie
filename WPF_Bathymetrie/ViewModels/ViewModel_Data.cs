using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows;
using WPF_Bathymetrie.Command;
using WPF_Bathymetrie.Models;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace WPF_Bathymetrie.ViewModels
{
	public class ViewModel_Data : ViewModel_Base
	{
		public ObservableCollection<Model_Data> Collection_DataGrid_T { get; set; }
		public ObservableCollection<Model_Data> Collection_DataGrid_0 { get; set; }
		public ObservableCollection<Model_Data> Collection_DataGrid_P { get; set; }
		#region ObservableCollection ConsigneMaree0
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_G { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_1 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_2 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_3 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_4 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_5 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_6 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_7 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_8 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_9 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMaree0_10 { get; set; }
		#endregion

		#region ObservableCollection ConsigneMareeP
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_G { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_1 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_2 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_3 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_4 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_5 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_6 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_7 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_8 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_9 { get; set; }
		public ObservableCollection<Model_ConsigneMaree> ConsigneMareeP_10 { get; set; }
		#endregion


		#region Partie Graphique & Profil SerieCollection et Formatter
		public Func<double, string> Formatter { get; set; }
		public Func<double, string> Formatter3 { get; set; }
		public SeriesCollection SeriesCollection { get; set; }
		#endregion

		#region Partie Profil Engins SerieCollection2 et Formatter
		public Func<double, string> Formatter2 { get; set; }
		public SeriesCollection SeriesCollection2 { get; set; }
		#endregion

		public string[] Labels { get; set; }

		public Model_SharedData SharedData0 { get; set; }
		public Model_SharedData SharedDataP { get; set; }

		public ICommand ButtonImport { get; set; }
		public ICommand Button_SaisirMaree0 { get; set; }
		public ICommand Button_SaisirMareeP { get; set; }

		#region ICommand ButtonJalon Profil
		public ICommand ButtonJalon1 { get; set; }
		public ICommand ButtonJalon2 { get; set; }
		public ICommand ButtonJalon3 { get; set; }
		public ICommand ButtonJalon4 { get; set; }
		public ICommand ButtonJalon5 { get; set; }
		public ICommand ButtonJalon6 { get; set; }
		public ICommand ButtonJalon7 { get; set; }
		public ICommand ButtonJalon8 { get; set; }
		public ICommand ButtonJalon9 { get; set; }
		public ICommand ButtonJalon10 { get; set; }
		#endregion

		#region ICommand ButtonSegment Profil Engin
		public ICommand ButtonS1 { get; set; }
		public ICommand ButtonS2 { get; set; }
		public ICommand ButtonS3 { get; set; }
		public ICommand ButtonS4 { get; set; }
		#endregion

		public ChartValues<HeatPoint> HeatValues { get; set; }
		public string[] Distances { get; set; }
		public string[] Distances2 { get; set; }
		public string[] Jalon { get; set; }
		public List<double> jalonData;

		public ViewModel_Data()
		{
			jalonData = null;

			Collection_DataGrid_T = new ObservableCollection<Model_Data>();
			Collection_DataGrid_0 = new ObservableCollection<Model_Data>();
			Collection_DataGrid_P = new ObservableCollection<Model_Data>();
			SharedData0 = new Model_SharedData();
			SharedDataP = new Model_SharedData();

			#region Déclaration ConsigneMaree0
			ConsigneMaree0_G = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_1 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_2 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_3 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_4 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_5 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_6 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_7 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_8 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_9 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMaree0_10 = new ObservableCollection<Model_ConsigneMaree>();
			#endregion

			#region Déclaration ConsigneMareeP
			ConsigneMareeP_G = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_1 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_2 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_3 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_4 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_5 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_6 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_7 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_8 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_9 = new ObservableCollection<Model_ConsigneMaree>();
			ConsigneMareeP_10 = new ObservableCollection<Model_ConsigneMaree>();
			#endregion

			#region RelayCommand Profil ButtonJalon 
			ButtonJalon1 = new RelayCommand(o => Button_Jalon1_Click("Button_Jalon1"));
			ButtonJalon2 = new RelayCommand(o => Button_Jalon2_Click("Button_Jalon2"));
			ButtonJalon3 = new RelayCommand(o => Button_Jalon3_Click("Button_Jalon3"));
			ButtonJalon4 = new RelayCommand(o => Button_Jalon4_Click("Button_Jalon4"));
			ButtonJalon5 = new RelayCommand(o => Button_Jalon5_Click("Button_Jalon5"));
			ButtonJalon6 = new RelayCommand(o => Button_Jalon6_Click("Button_Jalon6"));
			ButtonJalon7 = new RelayCommand(o => Button_Jalon7_Click("Button_Jalon7"));
			ButtonJalon8 = new RelayCommand(o => Button_Jalon8_Click("Button_Jalon8"));
			ButtonJalon9 = new RelayCommand(o => Button_Jalon9_Click("Button_Jalon9"));
			ButtonJalon10 = new RelayCommand(o => Button_Jalon10_Click("Button_Jalon10"));
			#endregion

			#region RelayCommand Profil Engin ButtonSegment 
			ButtonS1 = new RelayCommand(o => Button_S1_Click("Button_S1"));
			ButtonS2 = new RelayCommand(o => Button_S2_Click("Button_S2"));
			ButtonS3 = new RelayCommand(o => Button_S3_Click("Button_S3"));
			ButtonS4 = new RelayCommand(o => Button_S4_Click("Button_S4"));
			#endregion

			ButtonImport = new RelayCommand(o => Button_Import_Click("Button_Import"));
			Button_SaisirMaree0 = new RelayCommand(o => Button_SaisirMaree0_Click("Button_SaisirMaree0"));
			Button_SaisirMareeP = new RelayCommand(o => Button_SaisirMareeP_Click("Button_SaisirMareeP"));

			#region Initialisation ConsigneMaree0
			ConsigneMaree0_G.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_1.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_2.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_3.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_4.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_5.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_6.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_7.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_8.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_9.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMaree0_10.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			#endregion
			#region Initialisation ConsigneMareeP
			ConsigneMareeP_G.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_1.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_2.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_3.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_4.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_5.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_6.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_7.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_8.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_9.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			ConsigneMareeP_10.Add(new Model_ConsigneMaree { Propriete1 = 0 });
			#endregion

			for (int i = 0; i < 21; i++)
			{
				#region Initialisation des Données du Relevé à l'instant T
				Collection_DataGrid_T.Add(new Model_Data
				{

					Propriete0 = 10 * i,
					Propriete1 = 0,
					Propriete2 = 0,
					Propriete3 = 0,
					Propriete4 = 0,
					Propriete5 = 0,
					Propriete6 = 0,
					Propriete7 = 0,
					Propriete8 = 0,
					Propriete9 = 0,
					Propriete10 = 0,

				});
				#endregion
				#region Initialisation des Données du Relevé au 0 des cartes
				Collection_DataGrid_0.Add(new Model_Data
				{

					Propriete0 = 10 * i,
					Propriete1 = 0,
					Propriete2 = 0,
					Propriete3 = 0,
					Propriete4 = 0,
					Propriete5 = 0,
					Propriete6 = 0,
					Propriete7 = 0,
					Propriete8 = 0,
					Propriete9 = 0,
					Propriete10 = 0,

				});
				#endregion
				#region Initialisation des Données du Relevé des prévisions
				Collection_DataGrid_P.Add(new Model_Data
				{

					Propriete0 = 10 * i,
					Propriete1 = 0,
					Propriete2 = 0,
					Propriete3 = 0,
					Propriete4 = 0,
					Propriete5 = 0,
					Propriete6 = 0,
					Propriete7 = 0,
					Propriete8 = 0,
					Propriete9 = 0,
					Propriete10 = 0,

				});
				#endregion
			}
			#region Graphique de la page Profil
			SeriesCollection = new SeriesCollection
			{
				new LineSeries
				{
					Title = "Mer",
					Values = new ChartValues<double>(Collection_DataGrid_0.Select(item => 0.0)),
					Stroke = new SolidColorBrush(Color.FromRgb(81, 159, 232)),
					Fill = new SolidColorBrush(Color.FromRgb(81, 159, 232)),
					PointGeometry = null
				},
				new LineSeries
				{
					Title = "Jalon",
					Values = new ChartValues<double>(Collection_DataGrid_0.Select(item => 0.0)),
					Stroke = new SolidColorBrush(Color.FromRgb(122, 37, 16)),
					Fill = new SolidColorBrush(Color.FromRgb(122, 37, 16)),
				},
				new LineSeries
				{
					Title = "-1.2m",
					Values = new ChartValues<double>(Collection_DataGrid_0.Select(item => -1.2)),
					Stroke = new SolidColorBrush(Color.FromRgb(255, 0, 0)),
					Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0)),
					PointForeground = new SolidColorBrush(Color.FromRgb(255, 0, 0)),
					StrokeDashArray = new DoubleCollection(new double[] { 2 }),
					PointGeometry = null,
					PointGeometrySize = 0

				},
				new LineSeries
				{
					Title = "-1.6m",
					Values = new ChartValues<double>(Collection_DataGrid_0.Select(item => -1.6)),
					Stroke = new SolidColorBrush(Color.FromRgb(255, 0, 0)),
					Fill = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0)),
					PointForeground = new SolidColorBrush(Color.FromRgb(255, 0, 0)),
					StrokeDashArray = new DoubleCollection(new double[] { 2 }),
					PointGeometry = null,
					PointGeometrySize = 0
				}
			};
			#endregion

			Labels = Collection_DataGrid_0.Select(item => item.Propriete0.ToString()).ToArray();
			Formatter = value => value.ToString("F1", CultureInfo.InvariantCulture);
			Formatter3 = value => (value * 10).ToString("F0", CultureInfo.InvariantCulture);
		}

		private void Reinitialisation_des_Donnees_du_Releve_T()
		{
			Collection_DataGrid_T.Clear();
			for (int i = 0; i < 21; i++)
			{
				Collection_DataGrid_T.Add(new Model_Data
				{

					Propriete0 = 10 * i,
					Propriete1 = 0,
					Propriete2 = 0,
					Propriete3 = 0,
					Propriete4 = 0,
					Propriete5 = 0,
					Propriete6 = 0,
					Propriete7 = 0,
					Propriete8 = 0,
					Propriete9 = 0,
					Propriete10 = 0,

				});
			}
		}

		private void Button_Import_Click(object sender)
		{
			Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
			dlg.FileName = "Document";
			dlg.DefaultExt = ".csv";
			dlg.Filter = "CSV documents (.csv)|*.csv";

			Nullable<bool> result = dlg.ShowDialog();
			if (result == true)
			{
				// Chemin d'accès au fichier à importer
				string filename = dlg.FileName;
				try
				{
					// Lecture des données depuis le fichier
					using (StreamReader reader = new StreamReader(filename))
					{
						Collection_DataGrid_T.Clear();
						reader.ReadLine(); // Lire et ignorer la première ligne
						string line;
						int rowCount = 0;
						while ((line = reader.ReadLine()) != null)
						{
							rowCount++;
							var columns = line.Split(',').Select(column => column.Trim('\"')).ToArray();

							var member = new Model_Data
							{
								Propriete0 = double.Parse(columns[0], CultureInfo.InvariantCulture),
								Propriete1 = double.Parse(columns[1], CultureInfo.InvariantCulture),
								Propriete2 = double.Parse(columns[2], CultureInfo.InvariantCulture),
								Propriete3 = double.Parse(columns[3], CultureInfo.InvariantCulture),
								Propriete4 = double.Parse(columns[4], CultureInfo.InvariantCulture),
								Propriete5 = double.Parse(columns[5], CultureInfo.InvariantCulture),
								Propriete6 = double.Parse(columns[6], CultureInfo.InvariantCulture),
								Propriete7 = double.Parse(columns[7], CultureInfo.InvariantCulture),
								Propriete8 = double.Parse(columns[8], CultureInfo.InvariantCulture),
								Propriete9 = double.Parse(columns[9], CultureInfo.InvariantCulture),
								Propriete10 = double.Parse(columns[10], CultureInfo.InvariantCulture)
							};

							Collection_DataGrid_T.Add(member);
						}
						if (rowCount != 21)
						{
							MessageBox.Show("Erreur : Le fichier CSV n'est pas au bon format de données.", "Avertissement : FLOPHIB", MessageBoxButton.OK, MessageBoxImage.Error);
							Reinitialisation_des_Donnees_du_Releve_T();
						}
					}

				}
				catch (IOException)
				{
					MessageBox.Show("Le fichier est déjà ouvert. Veuillez le fermer et réessayer.", "Avertissement : FLOPHIB", MessageBoxButton.OK, MessageBoxImage.Error);
				}
				catch (Exception)
				{
					MessageBox.Show("Une erreur s'est produite lors de la lecture du fichier CSV. Veuillez vérifier que les données sont correctes.", "Avertissement : FLOPHIB", MessageBoxButton.OK, MessageBoxImage.Error);
					Reinitialisation_des_Donnees_du_Releve_T();
				}
			}
		}

		public void Button_SaisirMaree0_Click(object sender)
		{
			double mareeG, maree1, maree2, maree3, maree4, maree5, maree6, maree7, maree8, maree9, maree10;
			#region ConsigneMaree
			var consigneG = ConsigneMaree0_G.FirstOrDefault();
			var consigne1 = ConsigneMaree0_1.FirstOrDefault();
			var consigne2 = ConsigneMaree0_2.FirstOrDefault();
			var consigne3 = ConsigneMaree0_3.FirstOrDefault();
			var consigne4 = ConsigneMaree0_4.FirstOrDefault();
			var consigne5 = ConsigneMaree0_5.FirstOrDefault();
			var consigne6 = ConsigneMaree0_6.FirstOrDefault();
			var consigne7 = ConsigneMaree0_7.FirstOrDefault();
			var consigne8 = ConsigneMaree0_8.FirstOrDefault();
			var consigne9 = ConsigneMaree0_9.FirstOrDefault();
			var consigne10 = ConsigneMaree0_10.FirstOrDefault();
			#endregion
			#region ValeursMaree
			mareeG = consigneG.Propriete1;
			maree1 = consigne1.Propriete1;
			maree2 = consigne2.Propriete1;
			maree3 = consigne3.Propriete1;
			maree4 = consigne4.Propriete1;
			maree5 = consigne5.Propriete1;
			maree6 = consigne6.Propriete1;
			maree7 = consigne7.Propriete1;
			maree8 = consigne8.Propriete1;
			maree9 = consigne9.Propriete1;
			maree10 = consigne10.Propriete1;

			#endregion
			Collection_DataGrid_0.Clear();
			SharedData0.Jalon0 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete0).ToList();
			SharedData0.Jalon1 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete1).ToList();
			SharedData0.Jalon2 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete2).ToList();
			SharedData0.Jalon3 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete3).ToList();
			SharedData0.Jalon4 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete4).ToList();
			SharedData0.Jalon5 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete5).ToList();
			SharedData0.Jalon6 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete6).ToList();
			SharedData0.Jalon7 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete7).ToList();
			SharedData0.Jalon8 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete8).ToList();
			SharedData0.Jalon9 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete9).ToList();
			SharedData0.Jalon10 = Collection_DataGrid_T.Take(21).Select(item => item.Propriete10).ToList();

			for (int i = 0; i < SharedData0.Jalon1.Count; i++)
			{
				SharedData0.Jalon1[i] = Math.Round(SharedData0.Jalon1[i] + mareeG + maree1, 2);
				SharedData0.Jalon2[i] = Math.Round(SharedData0.Jalon2[i] + mareeG + maree2, 2);
				SharedData0.Jalon3[i] = Math.Round(SharedData0.Jalon3[i] + mareeG + maree3, 2);
				SharedData0.Jalon4[i] = Math.Round(SharedData0.Jalon4[i] + mareeG + maree4, 2);
				SharedData0.Jalon5[i] = Math.Round(SharedData0.Jalon5[i] + mareeG + maree5, 2);
				SharedData0.Jalon6[i] = Math.Round(SharedData0.Jalon6[i] + mareeG + maree6, 2);
				SharedData0.Jalon7[i] = Math.Round(SharedData0.Jalon7[i] + mareeG + maree7, 2);
				SharedData0.Jalon8[i] = Math.Round(SharedData0.Jalon8[i] + mareeG + maree8, 2);
				SharedData0.Jalon9[i] = Math.Round(SharedData0.Jalon9[i] + mareeG + maree9, 2);
				SharedData0.Jalon10[i] = Math.Round(SharedData0.Jalon10[i] + mareeG + maree10, 2);
			}

			for (int i = 0; i < 21; i++)
			{
				Collection_DataGrid_0.Add(new Model_Data
				{
					#region Propriete
					Propriete0 = 10 * i,
					Propriete1 = SharedData0.Jalon1[i],
					Propriete2 = SharedData0.Jalon2[i],
					Propriete3 = SharedData0.Jalon3[i],
					Propriete4 = SharedData0.Jalon4[i],
					Propriete5 = SharedData0.Jalon5[i],
					Propriete6 = SharedData0.Jalon6[i],
					Propriete7 = SharedData0.Jalon7[i],
					Propriete8 = SharedData0.Jalon8[i],
					Propriete9 = SharedData0.Jalon9[i],
					Propriete10 = SharedData0.Jalon10[i],
					#endregion
				});
			}
			HeatValues = new ChartValues<HeatPoint>
				{
					new HeatPoint(0, 0, SharedData0.Jalon1[0]),
					new HeatPoint(0, 1, SharedData0.Jalon1[1]),
					new HeatPoint(0, 2, SharedData0.Jalon1[2]),
					new HeatPoint(0, 3, SharedData0.Jalon1[3]),
					new HeatPoint(0, 4, SharedData0.Jalon1[4]),
					new HeatPoint(0, 5, SharedData0.Jalon1[5]),
					new HeatPoint(0, 6, SharedData0.Jalon1[6]),
					new HeatPoint(0, 7, SharedData0.Jalon1[7]),
					new HeatPoint(0, 8, SharedData0.Jalon1[8]),
					new HeatPoint(0, 9, SharedData0.Jalon1[9]),
					new HeatPoint(0, 10, SharedData0.Jalon1[10]),
					new HeatPoint(0, 11, SharedData0.Jalon1[11]),
					new HeatPoint(0, 12, SharedData0.Jalon1[12]),
					new HeatPoint(0, 13, SharedData0.Jalon1[13]),
					new HeatPoint(0, 14, SharedData0.Jalon1[14]),
					new HeatPoint(0, 15, SharedData0.Jalon1[15]),
					new HeatPoint(0, 16, SharedData0.Jalon1[16]),
					new HeatPoint(0, 17, SharedData0.Jalon1[17]),
					new HeatPoint(0, 18, SharedData0.Jalon1[18]),
					new HeatPoint(0, 19, SharedData0.Jalon1[19]),
					new HeatPoint(0, 20, SharedData0.Jalon1[20]),

					new HeatPoint(1, 0, SharedData0.Jalon2[0]),
					new HeatPoint(1, 1, SharedData0.Jalon2[1]),
					new HeatPoint(1, 2, SharedData0.Jalon2[2]),
					new HeatPoint(1, 3, SharedData0.Jalon2[3]),
					new HeatPoint(1, 4, SharedData0.Jalon2[4]),
					new HeatPoint(1, 5, SharedData0.Jalon2[5]),
					new HeatPoint(1, 6, SharedData0.Jalon2[6]),
					new HeatPoint(1, 7, SharedData0.Jalon2[7]),
					new HeatPoint(1, 8, SharedData0.Jalon2[8]),
					new HeatPoint(1, 9, SharedData0.Jalon2[9]),
					new HeatPoint(1, 10, SharedData0.Jalon2[10]),
					new HeatPoint(1, 11, SharedData0.Jalon2[11]),
					new HeatPoint(1, 12, SharedData0.Jalon2[12]),
					new HeatPoint(1, 13, SharedData0.Jalon2[13]),
					new HeatPoint(1, 14, SharedData0.Jalon2[14]),
					new HeatPoint(1, 15, SharedData0.Jalon2[15]),
					new HeatPoint(1, 16, SharedData0.Jalon2[16]),
					new HeatPoint(1, 17, SharedData0.Jalon2[17]),
					new HeatPoint(1, 18, SharedData0.Jalon2[18]),
					new HeatPoint(1, 19, SharedData0.Jalon2[19]),
					new HeatPoint(1, 20, SharedData0.Jalon2[20]),

					new HeatPoint(2, 0, SharedData0.Jalon3[0]),
					new HeatPoint(2, 1, SharedData0.Jalon3[1]),
					new HeatPoint(2, 2, SharedData0.Jalon3[2]),
					new HeatPoint(2, 3, SharedData0.Jalon3[3]),
					new HeatPoint(2, 4, SharedData0.Jalon3[4]),
					new HeatPoint(2, 5, SharedData0.Jalon3[5]),
					new HeatPoint(2, 6, SharedData0.Jalon3[6]),
					new HeatPoint(2, 7, SharedData0.Jalon3[7]),
					new HeatPoint(2, 8, SharedData0.Jalon3[8]),
					new HeatPoint(2, 9, SharedData0.Jalon3[9]),
					new HeatPoint(2, 10, SharedData0.Jalon3[10]),
					new HeatPoint(2, 11, SharedData0.Jalon3[11]),
					new HeatPoint(2, 12, SharedData0.Jalon3[12]),
					new HeatPoint(2, 13, SharedData0.Jalon3[13]),
					new HeatPoint(2, 14, SharedData0.Jalon3[14]),
					new HeatPoint(2, 15, SharedData0.Jalon3[15]),
					new HeatPoint(2, 16, SharedData0.Jalon3[16]),
					new HeatPoint(2, 17, SharedData0.Jalon3[17]),
					new HeatPoint(2, 18, SharedData0.Jalon3[18]),
					new HeatPoint(2, 19, SharedData0.Jalon3[19]),
					new HeatPoint(2, 20, SharedData0.Jalon3[20]),

					new HeatPoint(3, 0, SharedData0.Jalon4[0]),
					new HeatPoint(3, 1, SharedData0.Jalon4[1]),
					new HeatPoint(3, 2, SharedData0.Jalon4[2]),
					new HeatPoint(3, 3, SharedData0.Jalon4[3]),
					new HeatPoint(3, 4, SharedData0.Jalon4[4]),
					new HeatPoint(3, 5, SharedData0.Jalon4[5]),
					new HeatPoint(3, 6, SharedData0.Jalon4[6]),
					new HeatPoint(3, 7, SharedData0.Jalon4[7]),
					new HeatPoint(3, 8, SharedData0.Jalon4[8]),
					new HeatPoint(3, 9, SharedData0.Jalon4[9]),
					new HeatPoint(3, 10, SharedData0.Jalon4[10]),
					new HeatPoint(3, 11, SharedData0.Jalon4[11]),
					new HeatPoint(3, 12, SharedData0.Jalon4[12]),
					new HeatPoint(3, 13, SharedData0.Jalon4[13]),
					new HeatPoint(3, 14, SharedData0.Jalon4[14]),
					new HeatPoint(3, 15, SharedData0.Jalon4[15]),
					new HeatPoint(3, 16, SharedData0.Jalon4[16]),
					new HeatPoint(3, 17, SharedData0.Jalon4[17]),
					new HeatPoint(3, 18, SharedData0.Jalon4[18]),
					new HeatPoint(3, 19, SharedData0.Jalon4[19]),
					new HeatPoint(3, 20, SharedData0.Jalon4[20]),

					new HeatPoint(4, 0, SharedData0.Jalon5[0]),
					new HeatPoint(4, 1, SharedData0.Jalon5[1]),
					new HeatPoint(4, 2, SharedData0.Jalon5[2]),
					new HeatPoint(4, 3, SharedData0.Jalon5[3]),
					new HeatPoint(4, 4, SharedData0.Jalon5[4]),
					new HeatPoint(4, 5, SharedData0.Jalon5[5]),
					new HeatPoint(4, 6, SharedData0.Jalon5[6]),
					new HeatPoint(4, 7, SharedData0.Jalon5[7]),
					new HeatPoint(4, 8, SharedData0.Jalon5[8]),
					new HeatPoint(4, 9, SharedData0.Jalon5[9]),
					new HeatPoint(4, 10, SharedData0.Jalon5[10]),
					new HeatPoint(4, 11, SharedData0.Jalon5[11]),
					new HeatPoint(4, 12, SharedData0.Jalon5[12]),
					new HeatPoint(4, 13, SharedData0.Jalon5[13]),
					new HeatPoint(4, 14, SharedData0.Jalon5[14]),
					new HeatPoint(4, 15, SharedData0.Jalon5[15]),
					new HeatPoint(4, 16, SharedData0.Jalon5[16]),
					new HeatPoint(4, 17, SharedData0.Jalon5[17]),
					new HeatPoint(4, 18, SharedData0.Jalon5[18]),
					new HeatPoint(4, 19, SharedData0.Jalon5[19]),
					new HeatPoint(4, 20, SharedData0.Jalon5[20]),

					new HeatPoint(5, 0, SharedData0.Jalon6[0]),
					new HeatPoint(5, 1, SharedData0.Jalon6[1]),
					new HeatPoint(5, 2, SharedData0.Jalon6[2]),
					new HeatPoint(5, 3, SharedData0.Jalon6[3]),
					new HeatPoint(5, 4, SharedData0.Jalon6[4]),
					new HeatPoint(5, 5, SharedData0.Jalon6[5]),
					new HeatPoint(5, 6, SharedData0.Jalon6[6]),
					new HeatPoint(5, 7, SharedData0.Jalon6[7]),
					new HeatPoint(5, 8, SharedData0.Jalon6[8]),
					new HeatPoint(5, 9, SharedData0.Jalon6[9]),
					new HeatPoint(5, 10, SharedData0.Jalon6[10]),
					new HeatPoint(5, 11, SharedData0.Jalon6[11]),
					new HeatPoint(5, 12, SharedData0.Jalon6[12]),
					new HeatPoint(5, 13, SharedData0.Jalon6[13]),
					new HeatPoint(5, 14, SharedData0.Jalon6[14]),
					new HeatPoint(5, 15, SharedData0.Jalon6[15]),
					new HeatPoint(5, 16, SharedData0.Jalon6[16]),
					new HeatPoint(5, 17, SharedData0.Jalon6[17]),
					new HeatPoint(5, 18, SharedData0.Jalon6[18]),
					new HeatPoint(5, 19, SharedData0.Jalon6[19]),
					new HeatPoint(5, 20, SharedData0.Jalon6[20]),

					new HeatPoint(6, 0, SharedData0.Jalon7[0]),
					new HeatPoint(6, 1, SharedData0.Jalon7[1]),
					new HeatPoint(6, 2, SharedData0.Jalon7[2]),
					new HeatPoint(6, 3, SharedData0.Jalon7[3]),
					new HeatPoint(6, 4, SharedData0.Jalon7[4]),
					new HeatPoint(6, 5, SharedData0.Jalon7[5]),
					new HeatPoint(6, 6, SharedData0.Jalon7[6]),
					new HeatPoint(6, 7, SharedData0.Jalon7[7]),
					new HeatPoint(6, 8, SharedData0.Jalon7[8]),
					new HeatPoint(6, 9, SharedData0.Jalon7[9]),
					new HeatPoint(6, 10, SharedData0.Jalon7[10]),
					new HeatPoint(6, 11, SharedData0.Jalon7[11]),
					new HeatPoint(6, 12, SharedData0.Jalon7[12]),
					new HeatPoint(6, 13, SharedData0.Jalon7[13]),
					new HeatPoint(6, 14, SharedData0.Jalon7[14]),
					new HeatPoint(6, 15, SharedData0.Jalon7[15]),
					new HeatPoint(6, 16, SharedData0.Jalon7[16]),
					new HeatPoint(6, 17, SharedData0.Jalon7[17]),
					new HeatPoint(6, 18, SharedData0.Jalon7[18]),
					new HeatPoint(6, 19, SharedData0.Jalon7[19]),
					new HeatPoint(6, 20, SharedData0.Jalon7[20]),

					new HeatPoint(7, 0, SharedData0.Jalon8[0]),
					new HeatPoint(7, 1, SharedData0.Jalon8[1]),
					new HeatPoint(7, 2, SharedData0.Jalon8[2]),
					new HeatPoint(7, 3, SharedData0.Jalon8[3]),
					new HeatPoint(7, 4, SharedData0.Jalon8[4]),
					new HeatPoint(7, 5, SharedData0.Jalon8[5]),
					new HeatPoint(7, 6, SharedData0.Jalon8[6]),
					new HeatPoint(7, 7, SharedData0.Jalon8[7]),
					new HeatPoint(7, 8, SharedData0.Jalon8[8]),
					new HeatPoint(7, 9, SharedData0.Jalon8[9]),
					new HeatPoint(7, 10, SharedData0.Jalon8[10]),
					new HeatPoint(7, 11, SharedData0.Jalon8[11]),
					new HeatPoint(7, 12, SharedData0.Jalon8[12]),
					new HeatPoint(7, 13, SharedData0.Jalon8[13]),
					new HeatPoint(7, 14, SharedData0.Jalon8[14]),
					new HeatPoint(7, 15, SharedData0.Jalon8[15]),
					new HeatPoint(7, 16, SharedData0.Jalon8[16]),
					new HeatPoint(7, 17, SharedData0.Jalon8[17]),
					new HeatPoint(7, 18, SharedData0.Jalon8[18]),
					new HeatPoint(7, 19, SharedData0.Jalon8[19]),
					new HeatPoint(7, 20, SharedData0.Jalon8[20]),

					new HeatPoint(8, 0, SharedData0.Jalon9[0]),
					new HeatPoint(8, 1, SharedData0.Jalon9[1]),
					new HeatPoint(8, 2, SharedData0.Jalon9[2]),
					new HeatPoint(8, 3, SharedData0.Jalon9[3]),
					new HeatPoint(8, 4, SharedData0.Jalon9[4]),
					new HeatPoint(8, 5, SharedData0.Jalon9[5]),
					new HeatPoint(8, 6, SharedData0.Jalon9[6]),
					new HeatPoint(8, 7, SharedData0.Jalon9[7]),
					new HeatPoint(8, 8, SharedData0.Jalon9[8]),
					new HeatPoint(8, 9, SharedData0.Jalon9[9]),
					new HeatPoint(8, 10, SharedData0.Jalon9[10]),
					new HeatPoint(8, 11, SharedData0.Jalon9[11]),
					new HeatPoint(8, 12, SharedData0.Jalon9[12]),
					new HeatPoint(8, 13, SharedData0.Jalon9[13]),
					new HeatPoint(8, 14, SharedData0.Jalon9[14]),
					new HeatPoint(8, 15, SharedData0.Jalon9[15]),
					new HeatPoint(8, 16, SharedData0.Jalon9[16]),
					new HeatPoint(8, 17, SharedData0.Jalon9[17]),
					new HeatPoint(8, 18, SharedData0.Jalon9[18]),
					new HeatPoint(8, 19, SharedData0.Jalon9[19]),
					new HeatPoint(8, 20, SharedData0.Jalon9[20]),

					new HeatPoint(9, 0, SharedData0.Jalon10[0]),
					new HeatPoint(9, 1, SharedData0.Jalon10[1]),
					new HeatPoint(9, 2, SharedData0.Jalon10[2]),
					new HeatPoint(9, 3, SharedData0.Jalon10[3]),
					new HeatPoint(9, 4, SharedData0.Jalon10[4]),
					new HeatPoint(9, 5, SharedData0.Jalon10[5]),
					new HeatPoint(9, 6, SharedData0.Jalon10[6]),
					new HeatPoint(9, 7, SharedData0.Jalon10[7]),
					new HeatPoint(9, 8, SharedData0.Jalon10[8]),
					new HeatPoint(9, 9, SharedData0.Jalon10[9]),
					new HeatPoint(9, 10, SharedData0.Jalon10[10]),
					new HeatPoint(9, 11, SharedData0.Jalon10[11]),
					new HeatPoint(9, 12, SharedData0.Jalon10[12]),
					new HeatPoint(9, 13, SharedData0.Jalon10[13]),
					new HeatPoint(9, 14, SharedData0.Jalon10[14]),
					new HeatPoint(9, 15, SharedData0.Jalon10[15]),
					new HeatPoint(9, 16, SharedData0.Jalon10[16]),
					new HeatPoint(9, 17, SharedData0.Jalon10[17]),
					new HeatPoint(9, 18, SharedData0.Jalon10[18]),
					new HeatPoint(9, 19, SharedData0.Jalon10[19]),
					new HeatPoint(9, 20, SharedData0.Jalon10[20]),
				};
			Distances = new[]
			{
					"0",
					"10",
					"20",
					"30",
					"40",
					"50",
					"60",
					"70",
					"80",
					"90",
					"100",
					"110",
					"120",
					"130",
					"140",
					"150",
					"160",
					"170",
					"180",
					"190",
					"200"
				};
			Jalon = new[]
			{
					"Jalon 1",
					"Jalon 2",
					"Jalon 3",
					"Jalon 4",
					"Jalon 5",
					"Jalon 6",
					"Jalon 7",
					"Jalon 8",
					"Jalon 9",
					"Jalon 10"
				};

		}

		public void Button_SaisirMareeP_Click(object sender)
		{
			double mareeG, maree1, maree2, maree3, maree4, maree5, maree6, maree7, maree8, maree9, maree10;
			#region ConsigneMaree
			var consigneG = ConsigneMareeP_G.FirstOrDefault();
			var consigne1 = ConsigneMareeP_1.FirstOrDefault();
			var consigne2 = ConsigneMareeP_2.FirstOrDefault();
			var consigne3 = ConsigneMareeP_3.FirstOrDefault();
			var consigne4 = ConsigneMareeP_4.FirstOrDefault();
			var consigne5 = ConsigneMareeP_5.FirstOrDefault();
			var consigne6 = ConsigneMareeP_6.FirstOrDefault();
			var consigne7 = ConsigneMareeP_7.FirstOrDefault();
			var consigne8 = ConsigneMareeP_8.FirstOrDefault();
			var consigne9 = ConsigneMareeP_9.FirstOrDefault();
			var consigne10 = ConsigneMareeP_10.FirstOrDefault();
			#endregion
			#region ValeursMaree
			mareeG = consigneG.Propriete1;
			maree1 = consigne1.Propriete1;
			maree2 = consigne2.Propriete1;
			maree3 = consigne3.Propriete1;
			maree4 = consigne4.Propriete1;
			maree5 = consigne5.Propriete1;
			maree6 = consigne6.Propriete1;
			maree7 = consigne7.Propriete1;
			maree8 = consigne8.Propriete1;
			maree9 = consigne9.Propriete1;
			maree10 = consigne10.Propriete1;

			#endregion
			Collection_DataGrid_P.Clear();
			SharedDataP.Jalon0 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete0).ToList();
			SharedDataP.Jalon1 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete1).ToList();
			SharedDataP.Jalon2 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete2).ToList();
			SharedDataP.Jalon3 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete3).ToList();
			SharedDataP.Jalon4 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete4).ToList();
			SharedDataP.Jalon5 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete5).ToList();
			SharedDataP.Jalon6 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete6).ToList();
			SharedDataP.Jalon7 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete7).ToList();
			SharedDataP.Jalon8 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete8).ToList();
			SharedDataP.Jalon9 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete9).ToList();
			SharedDataP.Jalon10 = Collection_DataGrid_0.Take(21).Select(item => item.Propriete10).ToList();

			for (int i = 0; i < SharedDataP.Jalon1.Count; i++)
			{
				SharedDataP.Jalon1[i] = Math.Round(SharedDataP.Jalon1[i] + mareeG + maree1, 2);
				SharedDataP.Jalon2[i] = Math.Round(SharedDataP.Jalon2[i] + mareeG + maree2, 2);
				SharedDataP.Jalon3[i] = Math.Round(SharedDataP.Jalon3[i] + mareeG + maree3, 2);
				SharedDataP.Jalon4[i] = Math.Round(SharedDataP.Jalon4[i] + mareeG + maree4, 2);
				SharedDataP.Jalon5[i] = Math.Round(SharedDataP.Jalon5[i] + mareeG + maree5, 2);
				SharedDataP.Jalon6[i] = Math.Round(SharedDataP.Jalon6[i] + mareeG + maree6, 2);
				SharedDataP.Jalon7[i] = Math.Round(SharedDataP.Jalon7[i] + mareeG + maree7, 2);
				SharedDataP.Jalon8[i] = Math.Round(SharedDataP.Jalon8[i] + mareeG + maree8, 2);
				SharedDataP.Jalon9[i] = Math.Round(SharedDataP.Jalon9[i] + mareeG + maree9, 2);
				SharedDataP.Jalon10[i] = Math.Round(SharedDataP.Jalon10[i] + mareeG + maree10, 2);
			}

			for (int i = 0; i < 21; i++)
			{
				Collection_DataGrid_P.Add(new Model_Data
				{
					#region Propriete
					Propriete0 = 10 * i,
					Propriete1 = SharedDataP.Jalon1[i],
					Propriete2 = SharedDataP.Jalon2[i],
					Propriete3 = SharedDataP.Jalon3[i],
					Propriete4 = SharedDataP.Jalon4[i],
					Propriete5 = SharedDataP.Jalon5[i],
					Propriete6 = SharedDataP.Jalon6[i],
					Propriete7 = SharedDataP.Jalon7[i],
					Propriete8 = SharedDataP.Jalon8[i],
					Propriete9 = SharedDataP.Jalon9[i],
					Propriete10 = SharedDataP.Jalon10[i],
					#endregion
				});
			}
		}

		#region Gestion des clics des boutons de la page Profil
		public void Button_Jalon1_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete1).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_Jalon2_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete2).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_Jalon3_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete3).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_Jalon4_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete4).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_Jalon5_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete5).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_Jalon6_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete6).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_Jalon7_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete7).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_Jalon8_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete8).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_Jalon9_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete9).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_Jalon10_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete10).ToList();
			Button_Jalon(jalonData);
		}



		#endregion
		#region Gestion des boutons de la page Profil des Engins
		//Utiliser cette ligne pour les valeurs
		//jalonData = Collection_DataGrid_0.Skip(14).Take(6).Select(item => item.Propriete1).ToList();
		public void Button_S1_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete1).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_S2_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete1).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_S3_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete1).ToList();
			Button_Jalon(jalonData);
		}
		public void Button_S4_Click(object sender)
		{
			jalonData = Collection_DataGrid_0.Take(21).Select(item => item.Propriete1).ToList();
			Button_Jalon(jalonData);
		}
		#endregion

		public void Button_Jalon(List<double> jalonData)
		{
			SeriesCollection[1].Values = new ChartValues<double>(jalonData);
			Labels = Collection_DataGrid_0.Take(21).Select(item => item.Propriete0.ToString()).ToArray();
			OnPropertyChanged(nameof(SeriesCollection));
			OnPropertyChanged(nameof(Labels));
		}
	}
}
