namespace QuizStrategy;

public partial class MenuPage : ContentPage
{
	public MenuPage()
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







    private void ToRatingGameButton_Clicked(object sender, EventArgs e)
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
    private void ToCustomGameButton_Clicked(object sender, EventArgs e)
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
    private void ToStatButton_Clicked(object sender, EventArgs e)
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
    private void ToSettingsButton_Clicked(object sender, EventArgs e)
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

}