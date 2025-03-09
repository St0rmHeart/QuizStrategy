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
            // �������� MainPage �� RegisterPage
            Application.Current.MainPage = new RegisterPage();
        }
        catch (Exception ex)
        {
            DisplayAlert("������", $"�� ������� ������� ��������: {ex.Message}", "OK");
        }
    }

    private async void RegisterButton_Pressed(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(0.95, 100, Easing.SinOut); // ��������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // ������ ���� �� �����
        }
    }

    private async void RegisterButton_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // ���������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // ���������� ����
        }
    }

    private async void LoginButton_Pressed(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(0.95, 100, Easing.SinOut); // ��������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // ������ ���� �� �����
        }
    }

    private async void LoginButton_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // ���������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // ���������� ����
        }
    }
}