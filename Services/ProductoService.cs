using ERP.Mobile.ViewModels;

namespace ERP.Mobile.Services;

public class ProductoService
{
    private readonly List<Producto> _productos;

    public ProductoService()
    {
        // Datos de ejemplo - en una app real esto vendría de una API
        _productos = new List<Producto>
        {
            new Producto { Id = 1, Nombre = "Laptop Dell XPS", Descripcion = "Laptop profesional de alto rendimiento", Precio = 1299.99m, Stock = 15 },
            new Producto { Id = 2, Nombre = "iPhone 15 Pro", Descripcion = "Smartphone última generación", Precio = 999.99m, Stock = 8 },
            new Producto { Id = 3, Nombre = "Monitor Samsung 27\"", Descripcion = "Monitor 4K para oficina", Precio = 349.99m, Stock = 22 },
            new Producto { Id = 4, Nombre = "Teclado Mecánico", Descripcion = "Teclado gaming RGB", Precio = 89.99m, Stock = 35 },
            new Producto { Id = 5, Nombre = "Mouse Inalámbrico", Descripcion = "Mouse ergonómico Bluetooth", Precio = 45.99m, Stock = 50 }
        };
    }

    public async Task<IEnumerable<Producto>> ObtenerProductosAsync()
    {
        // Simular delay de red
        await Task.Delay(1000);
        
        return _productos.ToList();
    }

    public async Task<Producto> ObtenerProductoPorIdAsync(int id)
    {
        await Task.Delay(500);
        return _productos.FirstOrDefault(p => p.Id == id);
    }

    public async Task<bool> CrearProductoAsync(Producto producto)
    {
        await Task.Delay(500);
        
        producto.Id = _productos.Max(p => p.Id) + 1;
        _productos.Add(producto);
        
        return true;
    }

    public async Task<bool> ActualizarProductoAsync(Producto producto)
    {
        await Task.Delay(500);
        
        var productoExistente = _productos.FirstOrDefault(p => p.Id == producto.Id);
        if (productoExistente != null)
        {
            productoExistente.Nombre = producto.Nombre;
            productoExistente.Descripcion = producto.Descripcion;
            productoExistente.Precio = producto.Precio;
            productoExistente.Stock = producto.Stock;
            return true;
        }
        
        return false;
    }

    public async Task<bool> EliminarProductoAsync(int id)
    {
        await Task.Delay(500);
        
        var producto = _productos.FirstOrDefault(p => p.Id == id);
        if (producto != null)
        {
            _productos.Remove(producto);
            return true;
        }
        
        return false;
    }
}
