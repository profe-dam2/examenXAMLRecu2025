using Avalonia.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using examen2025.Services;

namespace examen2025.ViewModels;

public partial class HomeViewModel:ViewModelBase
{
    [ObservableProperty] private AvaloniaList<string> tiposIncidencias = new() { "BÁSICA","NORMAL","IMPORTANTE" };
    
    public HomeViewModel()
    {
        
    }
    //para la vista HighView
    //xmlns:p1="clr-namespace:Material.Styles.Assists;assembly=Material.Styles"
    /*
     *<TextBox UseFloatingWatermark="True"
                         Classes="outline"
                         Theme="{StaticResource OutlineTextBox}"
                         p1:TextFieldAssist.Label="Ejemplo" />
     * 
     */
}