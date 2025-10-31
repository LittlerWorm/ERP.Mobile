using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ERP.Mobile.Services;

namespace ERP.Mobile.ViewModels;

public class ProductosViewModel : INotifyPropertyChanged
{
    private readonly ProductoService _productoService;
    private ObservableCollection<Producto> _productos;
    private bool _isLoading;

    public ProductosViewModel(ProductoService productoService)
    {
        _productoService = productoService;
        _productos = new ObservableCollection<Producto>();
        CargarProductosCommand = new Command(async () => await CargarProductos());
    }

    public ObservableCollection<Producto> Productos
    {
        get => _productos;
        set
        {
            _productos = value;
            OnPropertyChanged();
        }
    }

    public bool IsLoading
    {
        get => _isLoading;
        set
        {
            _isLoading = value;
            OnPropertyChanged();
        }
    }

    public ICommand CargarProductosCommand { get; }

    private async Task CargarProductos()
    {
        IsLoading = true;
        
        try
        {
            var productos = await _productoService.ObtenerProductosAsync();
            Productos.Clear();
            
            foreach (var producto in productos)
            {
                Productos.Add(producto);
            }
        }
        catch (Exception ex)
        {
            // Manejar error - en una app real usarías un servicio de logging
            await Application.Current.MainPage.DisplayAlert("Error", 
                $"Error al cargar productos: {ex.Message}", "OK");
        }
        finally
        {
            IsLoading = false;
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

// Modelo de datos
public class Producto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public decimal Precio { get; set; }
    public int Stock { get; set; }
}
