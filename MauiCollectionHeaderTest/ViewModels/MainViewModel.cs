using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace MauiCollectionHeaderTest.ViewModels;

public class MainViewModel : ObservableObject
{

    private string _headerField1;
    public string HeaderField1
    {
        get => _headerField1;
        set => SetProperty(ref _headerField1, value);
    }


    private bool _isHeader1Visible = true;
    public bool IsHeader1Visible
    {
        get => _isHeader1Visible;
        set => SetProperty(ref _isHeader1Visible, value);
    }



    private string _headerField2;
    public string HeaderField2
    {
        get => _headerField2;
        set => SetProperty(ref _headerField2, value);
    }

    public ObservableCollection<string> CollectionData { get; } = new();


    public MainViewModel()
    {
        for (int i = 1; i < 20; i++)
        {
            CollectionData.Add($"Collection Item {i}");
        }

        HeaderField1 = "Header 1";
        HeaderField2= "Header 2";
    }


    RelayCommand _toggleHeader1VisibilityCommand;
    public RelayCommand ToggleHeader1VisibilityCommand => 
        _toggleHeader1VisibilityCommand ??= new(ToggleHeader1VisibilityHandler);

    private void ToggleHeader1VisibilityHandler()
    {
        IsHeader1Visible = !IsHeader1Visible;
    }


}
