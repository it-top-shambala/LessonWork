using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LessonWork.AvaloniaApp.Windows;

using Avalonia.Interactivity;

public partial class Login : Window
{
    public Login()
    {
        InitializeComponent();
    }

    private void ButtonLogin(object? sender, RoutedEventArgs e)
    {
        var mainWindow = new MainWindow();
        mainWindow.Show();
        this.Close();
    }
}

