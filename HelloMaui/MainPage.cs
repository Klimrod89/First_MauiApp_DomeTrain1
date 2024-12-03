using CommunityToolkit.Maui.Markup;

namespace HelloMaui;

public class MainPage : BaseContentPage
{
	public MainPage()
	{
		BackgroundColor = Colors.DarkViolet;
		Content = new VerticalStackLayout
		{
			Spacing = 12,
			BackgroundColor = Colors.LightSteelBlue,
			Children = 
			{
				new Image()
					.Size(500, 250)
					.Aspect(Aspect.AspectFit)
					.Source("./Resources/AppIcon/appicon.svg"),
				
				new Label()
					.Text("Hello Maui", Colors.Black)
					.Center()
					.TextCenter(),

				new Entry()
					.Placeholder("Notes", Colors.DarkGrey)
					.TextColor(Colors.Black)
			}
		};

		
	}
}