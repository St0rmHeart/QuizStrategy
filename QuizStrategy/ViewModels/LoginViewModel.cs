using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using QuizStrategy.Repositories;
using System.Threading.Tasks;

namespace QuizStrategy.ViewModels;

public partial class LoginViewModel : ObservableObject
{
    private readonly FakeUserRepository _repository;

    [ObservableProperty]
    private string _login;

    [ObservableProperty]
    private string _password;

    [ObservableProperty]
    private string _errorMessage;

    [ObservableProperty]
    private bool _isLoading;

    public LoginViewModel()
    {
        _repository = new FakeUserRepository();
    }

    [RelayCommand]
    private async Task LoginAsync()
    {
        if (string.IsNullOrEmpty(Login) || string.IsNullOrEmpty(Password))
        {
            ErrorMessage = "Введите логин и пароль";
            await Application.Current.MainPage.DisplayAlert("Ошибка", ErrorMessage, "OK");
            return;
        }

        IsLoading = true;
        ErrorMessage = string.Empty;

        try
        {
            bool isAuthenticated = await _repository.AuthenticateUserAsync(Login, Password);
            if (isAuthenticated)
            {
                Application.Current.MainPage = new MenuPage(); // Замена PushAsync
            }
            else
            {
                ErrorMessage = "Неверный логин или пароль. Попробуйте \"test\" и \"12345\"";
                await Application.Current.MainPage.DisplayAlert("Ошибка", ErrorMessage, "OK");
            }
        }
        catch (Exception ex)
        {
            ErrorMessage = $"Ошибка: {ex.Message}";
            await Application.Current.MainPage.DisplayAlert("Ошибка", ErrorMessage, "OK");
        }
        finally
        {
            IsLoading = false;
        }
    }

    [RelayCommand]
    private async Task GoToRegisterAsync()
    {
        Application.Current.MainPage = new RegisterPage(); // Замена PushAsync
    }
}