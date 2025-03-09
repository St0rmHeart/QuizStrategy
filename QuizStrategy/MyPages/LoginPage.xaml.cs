namespace QuizStrategy;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void RegisterButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Заменяем MainPage на RegisterPage
            Application.Current.MainPage = new RegisterPage();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка", $"Не удалось открыть страницу: {ex.Message}", "OK");
        }
    }

    private async void RegisterButton_Pressed(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(0.95, 100, Easing.SinOut); // Уменьшаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // Меняем цвет на серый
        }
    }

    private async void RegisterButton_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // Возвращаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // Возвращаем цвет
        }
    }

    private async void LoginButton_Pressed(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(0.95, 100, Easing.SinOut); // Уменьшаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // Меняем цвет на серый
        }
    }

    private async void LoginButton_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // Возвращаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // Возвращаем цвет
        }
    }
}