using ERP.Mobile.ViewModels;

namespace ERP.Mobile.Views;

public partial class ProductosPage : ContentPage
{
    public ProductosPage(ProductosViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
