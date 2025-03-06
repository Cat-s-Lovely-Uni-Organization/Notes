namespace Notes.Views;
using Notes.ViewModels;

public partial class AllNotesPage : ContentPage
{
    public AllNotesPage(NotesViewModel viewModel)
    {
        this.BindingContext = viewModel;
        InitializeComponent();
    }

    private void ContentPage_NavigatedTo(object sender, NavigatedToEventArgs e)
    {
        notesCollection.SelectedItem = null;
    }

}
