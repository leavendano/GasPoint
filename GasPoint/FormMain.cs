using GasPoint.Core.Cliente;
using GasPoint.Core.Interfaces;
using GasPoint.Core.Transaccion;

namespace GasPoint
{
    public partial class FormMain : Form
    {
        private readonly IEnablerService _enablerService;
        private readonly ICloudService _cloudService;
        public FormMain(IEnablerService service, ICloudService cloudService)
        {
            InitializeComponent();
            _enablerService = service;
            _cloudService = cloudService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTelefono.Mask = "(000) 000-0000";
            txtTelefono.Focus();
        }

        private void cbxPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex + 1;
            if (selectedIndex > 0)
            {
                var respuesta = _enablerService.GetLastDeliveryByHostID(selectedIndex);
                txtHoseID.Text = respuesta.Delivery_ID.ToString();
                txtFecha.Text = respuesta.Completed_TS.ToString();
                txtProducto.Text = respuesta.GradeName;
                txtImporte.Text = respuesta.Delivery_Value.ToString();
            }
            else
            {
                txtFecha.Text = "";
                txtProducto.Text = "";
                txtImporte.Text = "";
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(txtHoseID.Text != "")
            {
                var fecha = DateTime.Parse(txtFecha.Text);
                var task = _cloudService.CreateTransaccionAsync<TransaccionDTO>("", "https://localhost:7003/Transacciones", new TransaccionDTO
                {
                    HoseDeliveryId = int.Parse(txtHoseID.Text),
                    ClienteId = int.Parse(txtIdCliente.Text),
                    EstacionId = 1,
                    Fecha = fecha.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"),
                    Importe = decimal.Parse(txtImporte.Text)
                });

                var response = await task;
                if (response.Success)
                {
                    MessageBox.Show("La transaccion se guardo con exito!");
                }
                else
                {
                    MessageBox.Show("Hubo un error al guadar los datos:" + response.Error);
                }
            }

            txtNombre.Text = "";
            txtIdCliente.Text = "";
            txtPuntos.Text = "";
            txtHoseID.Text = "";
            txtTelefono.Text = "";
            txtTelefono.Focus();
            cbxPosicion.SelectedIndex = -1;
        }

        private async void txtTelefono_LeaveAsync(object sender, EventArgs e)
        {
            var task = _cloudService.GetClientByTelephoneAsync<ClienteResponseDTO>("", "https://localhost:7003/Clientes", txtTelefono.Text);
            var response = await task;

            if (response != null && response.Success)
            {
                var cliente = response.Data.First();
                txtIdCliente.Text = cliente.id.ToString();
                txtNombre.Text = cliente.nombre;
                txtPuntos.Text = cliente.saldoPuntos.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró un cliente con ese teléfono");
            }



        }
    }
}
