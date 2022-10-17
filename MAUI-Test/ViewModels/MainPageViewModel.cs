using System.Windows.Input;

namespace Accounting.ViewModels;

public class MainPageViewModel : ExtendedBindableObject
{
    private string _message { get; set; }

    public string Message
    {
        get => _message;
        set
        {
            _message = value;
            RaisePropertyChanged(() => Message);
        }
    }
    
    private int count = 0;
    
    public MainPageViewModel()
    {
        Message = "Test";
        _showResultCommand = new Command(OnShowResultTap);
    }

    private void OnShowResultTap()
    {
        count++;
        var text = "";
        if (count == 1)
            Message = $"Clicked {count} time";
        else
            Message = $"Clicked {count} times";
        var orientation = new DeviceOrientationService();

        var test = orientation.GetOrientation();
    }

    readonly ICommand _showResultCommand;
    public ICommand ShowResultCommand => _showResultCommand;
}