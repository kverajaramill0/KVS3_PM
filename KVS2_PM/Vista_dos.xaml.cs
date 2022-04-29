using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KVS2_PM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Vista_dos : ContentPage
    {
        public Vista_dos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                double datoUno = Convert.ToDouble(txtDatoUno.Text);
                double datoDos = Convert.ToDouble(txtDatoDos.Text);
                double suma = datoUno + datoDos;
                   txtResultado.Text=suma.ToString();
            }
            catch (Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Cerrar");
                throw;
            }
        }
    }
}