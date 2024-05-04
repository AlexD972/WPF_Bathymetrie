using System.Windows.Controls;
using System.Windows;

namespace WPF_Bathymetrie.Styles
{
	public class NavButton : ListBoxItem
	{
		static NavButton()
		{
			DefaultStyleKeyProperty.OverrideMetadata(typeof(NavButton), new FrameworkPropertyMetadata(typeof(NavButton)));
		}

		public Uri NavLink
		{
			get { return (Uri)GetValue(NavLinkProperty); }
			set { SetValue(NavLinkProperty, value); }
		}

		public string NavText
		{
			get { return (string)GetValue(NavTextProperty); }
			set { SetValue(NavTextProperty, value); }
		}

		public static readonly DependencyProperty NavTextProperty = DependencyProperty.Register("NavText", typeof(string), typeof(NavButton), new PropertyMetadata(null));
		public static readonly DependencyProperty NavLinkProperty = DependencyProperty.Register("NavLink", typeof(Uri), typeof(NavButton), new PropertyMetadata(null));
	}
}
