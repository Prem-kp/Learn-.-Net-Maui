using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace StudentManagementApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        // ── Backing fields ──────────────────────────────────────────────
        private string _username;
        private string _password;
        private string _userType = "Admin";
        private string _errorMessage;
        private bool _hasError;

        // ── Properties bound to the UI ──────────────────────────────────
        public string Username
        {
            get => _username;
            set => SetProperty(ref _username, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public string UserType
        {
            get => _userType;
            set => SetProperty(ref _userType, value);
        }

        public string ErrorMessage
        {
            get => _errorMessage;
            set => SetProperty(ref _errorMessage, value);
        }

        public bool HasError
        {
            get => _hasError;
            set => SetProperty(ref _hasError, value);
        }

        public List<string> UserTypes { get; } = new() { "Admin", "Teacher", "Student" };

        // ── Commands ────────────────────────────────────────────────────
        public ICommand LoginCommand { get; }
        public ICommand CloseCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
            CloseCommand = new Command(OnClose);
        }

        private async void OnLogin()
        {
            HasError = false;

            // Simple validation
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                ErrorMessage = "Please enter username and password.";
                HasError = true;
                return;
            }

            // Hardcoded credentials for demo (replace with real auth later)
            if (Username == "18MIS0395" && Password == "1234")
            {
                // Navigate to main tabs page
                await Shell.Current.GoToAsync("//MainTabbedPage");
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
                HasError = true;
            }
        }

        private async void OnClose()
        {
            bool confirm = await Application.Current.MainPage
                .DisplayAlert("Exit", "Do you want to exit the app?", "Yes", "No");
            if (confirm)
                Application.Current.Quit();
        }
    }
}
