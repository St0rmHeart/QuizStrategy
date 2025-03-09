namespace QuizStrategy;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
	}

    private async void Button_Pressed(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(0.95, 100, Easing.SinOut); // Уменьшаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // Меняем цвет на серый
        }
    }

    private async void Button_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // Возвращаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // Возвращаем цвет
        }
    }
    private void ToMenuButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            Application.Current.MainPage = new MenuPage();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка", $"Не удалось открыть страницу: {ex.Message}", "OK");
        }
    }
}