namespace SchoolApp;

public partial class StudentsPage : ContentPage
{
    
    private readonly string[] _students =
    {
        "Aziza Yerbolatkyzy",
        "Bekzat Sarsenov",
        "Dana Iskakova",
        "Erlan Nurpeisov",
        "Madina Akhmetova"
    };

    public StudentsPage()
    {
        InitializeComponent();
        StudentsList.ItemsSource = _students;
    }

    private async void OnStudentSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not string name) return;

        await Shell.Current.GoToAsync(
            $"{nameof(StudentDetailPage)}?name={Uri.EscapeDataString(name)}");

        StudentsList.SelectedItem = null;
    }
}
