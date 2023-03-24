namespace ColorMaker;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void redSld_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		var red= redSld.Value;
		var green = greensld.Value;
		var blue=bluesld.Value;
	 Color color=Color.FromRgb(red, green, blue);
		SetColor(color);


	}

    private void SetColor(Color color)
    {
		Background = color;
		Hexval.Background= color;
		Resetbtn.Background= color;
		Hexval.Text=color.ToHex();
    }

    private void Resetbtn_Clicked(object sender, EventArgs e)
    {
		 var color2 = Color.FromRgb(255, 255, 255);
		Resetbtn.TextColor = Color.FromRgb(0, 0, 0);

		SetColor(color2);
    }
}

