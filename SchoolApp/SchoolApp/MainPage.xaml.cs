using SchoolApp.ViewModels;

namespace SchoolApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new Person();
    }

    // L14: навигация на страницу студентов
    private async void OnStudentsClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(StudentsPage));
    }

    // L16 бонус: делаем имя заглавными буквами
    private void OnShoutClicked(object sender, EventArgs e)
    {
        if (BindingContext is Person p)
            p.Name = p.Name.ToUpper();
    }
}
