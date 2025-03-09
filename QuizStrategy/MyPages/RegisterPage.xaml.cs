namespace QuizStrategy;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private void ToLoginButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            // Заменяем MainPage на RegisterPage
            Application.Current.MainPage = new LoginPage();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка", $"Не удалось открыть страницу: {ex.Message}", "OK");
        }
    }

    private void ToMenuButton_Clicked(object sender, EventArgs e)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception ex)
        {
            DisplayAlert("Ошибка", $"Не удалось открыть страницу: {ex.Message}", "OK");
        }
    }















    private async void ToLoginButton_Pressed(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(0.95, 100, Easing.SinOut); // Уменьшаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // Меняем цвет на серый
        }
    }

    private async void ToLoginButton_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // Возвращаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // Возвращаем цвет
        }
    }

    private async void ToMenuButton_Pressed(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(0.95, 100, Easing.SinOut); // Уменьшаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // Меняем цвет на серый
        }
    }

    private async void ToMenuButton_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // Возвращаем масштаб за 100 мс
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // Возвращаем цвет
        }
    }
}