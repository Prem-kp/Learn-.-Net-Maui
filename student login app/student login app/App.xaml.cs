using Microsoft.Extensions.DependencyInjection;
using student_login_app.view;

namespace student_login_app
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new Loginpage());
        }
    }
}