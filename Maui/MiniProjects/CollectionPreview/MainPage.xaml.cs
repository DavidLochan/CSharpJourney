using System.Collections.ObjectModel;

namespace CollectionPreview;

public partial class MainPage : ContentPage
{
    public ObservableCollection<TodoItem> Tasks { get; set; } = new();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void OnAddTask(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(TaskEntry.Text))
            return;

        Tasks.Add(new TodoItem
        {
            Title = TaskEntry.Text,
            IsDone = false
        });

        TaskEntry.Text = "";
    }
}