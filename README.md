# ERP.Mobile

Aplicación móvil ERP desarrollada con .NET MAUI para la gestión empresarial.

## Características

- 📱 Multiplataforma (iOS, Android, Windows, macOS)
- 🏗️ Arquitectura MVVM
- 🔄 Gestión de productos
- 🎨 Interfaz moderna y responsive

## Estructura del Proyecto

```
ERP.Mobile/
├── AppShell.xaml              # Shell principal de navegación
├── AppShell.xaml.cs
├── MainPage.xaml              # Página principal
├── MainPage.xaml.cs
├── Views/                     # Vistas de la aplicación
│   ├── ProductosPage.xaml     # Página de gestión de productos
│   └── ProductosPage.xaml.cs
├── ViewModels/                # ViewModels (MVVM)
│   └── ProductosViewModel.cs  # ViewModel para productos
└── Services/                  # Servicios de datos
    └── ProductoService.cs     # Servicio de productos
```

## Tecnologías

- .NET MAUI
- C#
- XAML
- Patrón MVVM

## Instalación

1. Clona el repositorio
2. Abre el proyecto en Visual Studio 2022 o Visual Studio Code
3. Restaura los paquetes NuGet
4. Ejecuta la aplicación

## Contribución

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## Licencia

Este proyecto está bajo la Licencia MIT - ver el archivo [LICENSE](LICENSE) para más detalles.
