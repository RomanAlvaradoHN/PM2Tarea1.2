using PM2Tarea1._2.Models;
using PM2Tarea1._2.Views;


namespace PM2Tarea1._2 {

    public partial class MainPage : ContentPage {


        public MainPage() {
            InitializeComponent();
        }


        private async void OnBtnEnviarDatosClicked(object sender, EventArgs e) {
            Empleado empleado = new Empleado(
                txtNombres.Text,
                txtApellidos.Text,
                dateFechaNac.Date,
                txtCorreo.Text
            );

            if (!empleado.GetDatosInvalidos().Any()) {
                await Navigation.PushAsync(new PageResults(empleado));
                LimpiarCampos();

            } else {
                string msj = string.Join("\n", empleado.GetDatosInvalidos());
                await DisplayAlert("Datos Invalidos:", msj, "acepar");
            }
        }



        private void LimpiarCampos() {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            dateFechaNac.Date = DateTime.Now;
            txtCorreo.Text = string.Empty;
        }



    }
}