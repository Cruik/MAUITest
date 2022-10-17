using Accounting.ViewModels;

namespace Accounting.Views;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage(MainPageViewModel viewModel)
    {
        BindingContext = viewModel;
        InitializeComponent();
    }

}