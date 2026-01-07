using System.Collections.ObjectModel;

namespace CollectionPreview;

public partial class MainPage : ContentPage
{
    public ObservableCollection<string> Tasks { get; set; } = new();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    void OnAddTask(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(TaskEntry.Text))
        {
            Tasks.Add(TaskEntry.Text);
            TaskEntry.Text = string.Empty;
        }
    }
}