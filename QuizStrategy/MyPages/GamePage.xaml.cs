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
            await button.ScaleTo(0.95, 100, Easing.SinOut); // ��������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // ������ ���� �� �����
        }
    }

    private async void Button_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // ���������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // ���������� ����
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
            DisplayAlert("������", $"�� ������� ������� ��������: {ex.Message}", "OK");
        }
    }
}