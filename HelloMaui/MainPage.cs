using CommunityToolkit.Maui.Markup;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;


namespace HelloMaui;

public class MainPage : BaseContentPage
{
	public MainPage()
	{
		const int imageWidthRequest = 500;
		const int imageheightRequest = 250;
		const int labelheightRequest = 90;
		BackgroundColor = Colors.DarkViolet;

		Content = new ScrollView()
		{
			Orientation = ScrollOrientation.Vertical,
			Content = new Grid()
			{
				RowDefinitions = Rows.Define
					(
						(Row.Image, Star),
						(Row.Label, 100),
						(Row.Entry, 40),
						(Row.LargeTextEntry, 500)
					),
				ColumnDefinitions = Columns.Define
					(
						(Column.Entry1, Star),
						(Column.Entry2, Star),
						(Column.Entry3, Star)
					),
				BackgroundColor = Colors.LightSteelBlue,

				Children =
				{

					new Image()
						.Size(imageWidthRequest, imageheightRequest)
						.Aspect(Aspect.AspectFit)
						.Source("dotnet_bot.png")
						.Row(Row.Image)
						.ColumnSpan(All<Column>()),

					new Label()
						.Text("Hello Maui", Colors.Black)
						.BackgroundColor(Colors.Green)
						.Height(labelheightRequest)
						.Center()
						.TextCenter()
						.Paddings(5, 10, 15, 30)
						.Margins(30, 15, 10 , 5)
						.Row(Row.Label)
						.ColumnSpan(All<Column>()),


					new Entry()
					.Placeholder("First Entry", Colors.DarkGray)
					.TextColor(Colors.Black)
					.Row(Row.Entry)
					.Margin(5)
					.Column(Column.Entry1),

					new Entry()
					.Placeholder("Second Entry", Colors.DarkGray)
					.TextColor(Colors.Black)
					.Row(Row.Entry)
					.Margin(5)

					.Column(Column.Entry2),

					new Entry()
					.Placeholder("Third Entry", Colors.DarkGray)
					.TextColor(Colors.Black)
					.Row(Row.Entry)
					.Margin(5)

					.Column(Column.Entry3),

					new Label { LineBreakMode = LineBreakMode.WordWrap}
					.Text("LARGE TEXT")
					.FontSize(100)
					.TextCenter()
					.Row(Row.LargeTextEntry)
					.ColumnSpan(All<Column>())
				}
			}.Top().CenterHorizontal().Paddings(12).Margins(0, 6, 0, 0)
		};
	}

	enum Row
	{
		Image,
		Label,
		Entry,
		LargeTextEntry
	}

	enum Column
	{
		Entry1,
		Entry2,
		Entry3
	}
}