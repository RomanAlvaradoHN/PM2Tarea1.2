using PM2Tarea1._2.Models;

namespace PM2Tarea1._2.Views;

public partial class PageResults : ContentPage {

    public PageResults() {
        InitializeComponent();
    }

    public PageResults(Empleado empleado) {
        InitializeComponent();
        BindingContext = empleado;
    }
}
