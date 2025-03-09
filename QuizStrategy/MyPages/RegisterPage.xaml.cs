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
            // �������� MainPage �� RegisterPage
            Application.Current.MainPage = new LoginPage();
        }
        catch (Exception ex)
        {
            DisplayAlert("������", $"�� ������� ������� ��������: {ex.Message}", "OK");
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
            DisplayAlert("������", $"�� ������� ������� ��������: {ex.Message}", "OK");
        }
    }















    private async void ToLoginButton_Pressed(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(0.95, 100, Easing.SinOut); // ��������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // ������ ���� �� �����
        }
    }

    private async void ToLoginButton_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // ���������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // ���������� ����
        }
    }

    private async void ToMenuButton_Pressed(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(0.95, 100, Easing.SinOut); // ��������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#E0E0E0"); // ������ ���� �� �����
        }
    }

    private async void ToMenuButton_Released(object sender, EventArgs e)
    {
        var button = sender as Button;
        if (button != null)
        {
            await button.ScaleTo(1, 100, Easing.SinIn); // ���������� ������� �� 100 ��
            button.BackgroundColor = Color.FromArgb("#FFFFFF"); // ���������� ����
        }
    }
}