#if IOS
using UIKit;
#endif

namespace IosScrollviewMauiTestApp;

public partial class MainPage : ContentPage
{
		int count = 0;

		public MainPage()
		{
				InitializeComponent();
		}

		void Switch_Toggled(System.Object sender, Microsoft.Maui.Controls.ToggledEventArgs e)
		{
				SetFormVisibility(e.Value);
		}

		private void SetFormVisibility(bool isVisible)
		{
#if IOS
				Entry9.IsVisible= isVisible;
				Entry10.IsVisible= isVisible;
				Entry11.IsVisible= isVisible;
				Entry12.IsVisible= isVisible;
				Entry13.IsVisible= isVisible;
				Entry14.IsVisible= isVisible;
				Entry15.IsVisible= isVisible;
				Entry16.IsVisible= isVisible;
#endif
		}
}


