using System.Collections.ObjectModel;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using examen2025.ViewModels;
using examen2025.Views;
using FluentAvalonia.UI.Controls;

namespace examen2025.Services;

public partial class NavigationService: ObservableObject
{
    public const string INICIO_VIEW = "inicio";
    
    [ObservableProperty]
    private ContentControl currentView;
    
    public NavigationService()
    {
        NavigateTo(INICIO_VIEW);
    }
    
    public void NavigateTo(string tag)
    {
        if (tag.Equals(INICIO_VIEW))
        {
            HomeView homeView = new HomeView();
            homeView.DataContext = new HomeViewModel(this);
            CurrentView = homeView;
        }
    }
}