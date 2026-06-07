namespace SchoolApp;

[QueryProperty(nameof(Name), "name")]
public partial class StudentDetailPage : ContentPage
{
    private string _name = "";
    public string Name
    {
        get => _name;
        set
        {
            _name = Uri.UnescapeDataString(value ?? "");
            NameLabel.Text = _name;
        }
    }

    public StudentDetailPage()
    {
        InitializeComponent();
    }
}
