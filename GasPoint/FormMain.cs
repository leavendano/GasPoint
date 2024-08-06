using GasPoint.Core.Cliente;
using GasPoint.Core.HoseDelivery;
using GasPoint.Core.Interfaces;
using GasPoint.Core.Recompensa;
using GasPoint.Core.Transaccion;
using Microsoft.Reporting.WinForms;

namespace GasPoint
{
    public partial class FormMain : Form
    {
        private readonly IEnablerService _enablerService;
        private readonly ICloudService _cloudService;
        private int GradeId;
        private HoseDeliveryResponseDTO respuesta;
        public FormMain(IEnablerService service, ICloudService cloudService)
        {
            InitializeComponent();
            _enablerService = service;
            _cloudService = cloudService;
            GradeId = 0;
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
                respuesta = _enablerService.GetLastDeliveryByHostID(selectedIndex);
                txtHoseID.Text = respuesta.Delivery_ID.ToString();
                txtFecha.Text = respuesta.Completed_TS.ToString();
                txtProducto.Text = respuesta.GradeName;
                txtImporte.Text = respuesta.Delivery_Value.ToString();
                txtVolumen.Text = respuesta.Delivery_Volume.ToString();
                GradeId = respuesta.Grade_ID;
            }
            else
            {
                txtFecha.Text = "";
                txtProducto.Text = "";
                txtImporte.Text = "";
                GradeId = 0;
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtHoseID.Text != "")
                {
                    var fecha = DateTime.Parse(txtFecha.Text);
                    var task = _cloudService.CreateTransaccionAsync<TransaccionResponseDTO>("", "https://localhost:7003/Api/Transacciones", new TransaccionDTO
                    {
                        HoseDeliveryId = int.Parse(txtHoseID.Text),
                        ClienteId = int.Parse(txtIdCliente.Text),
                        EstacionId = 1,
                        Posicion = cbxPosicion.SelectedIndex + 1,
                        Fecha = fecha.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ"),
                        Importe = decimal.Parse(txtImporte.Text),
                        Volumen = decimal.Parse(txtVolumen.Text),
                        ProductoId = GradeId
                    });

                    var response = await task;
                    if (response.Success)
                    {
                        var responseData = response.Data.FirstOrDefault();
                        DialogResult dialogResult = MessageBox.Show("La transaccion se guardo con exito! Puntos Obtenidos=" 
                            + responseData.Puntos.ToString() + ". Deseas imprimir el ticket?","Respuesta", MessageBoxButtons.YesNo);
                        respuesta.Puntos = responseData.Puntos;
                        // report.ReportPath = Application.StartupPath
                        if(dialogResult == DialogResult.Yes)
                        {
                            TextReader fs = System.IO.File.OpenText(Application.StartupPath + "\\Reports\\Ticket.rdlc");
                            var reportViewer = new Visor();
                            var report = reportViewer.GetReport();
                            report.LoadReportDefinition(fs);
                            report.DataSources.Add(new ReportDataSource("HoseDelivery", new List<HoseDeliveryResponseDTO>()
                            {
                                respuesta
                            }));
                            var resultRecompensas = await _cloudService.GetAllRecompensasAsync<RecompensaDTO>("", "https://localhost:7003/Api/Recompensas");
                            if(resultRecompensas.Success)
                            {
                                report.DataSources.Add(new ReportDataSource("Recompensas", resultRecompensas.Data));
                            }
                            report.SetParameters(new ReportParameter("NombreCliente", txtNombre.Text));
                            reportViewer.RefreshReport();
                            reportViewer.Show();
                            
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al guadar los datos:" + response.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:" + ex.Message);
            }

            txtNombre.Text = "";
            txtIdCliente.Text = "";
            txtPuntos.Text = "";
            txtHoseID.Text = "";
            txtTelefono.Text = "";
            txtVolumen.Text = "";
            GradeId = 0;
            txtTelefono.Focus();
            cbxPosicion.SelectedIndex = -1;
        }

        private async void txtTelefono_LeaveAsync(object sender, EventArgs e)
        {
            var task = _cloudService.GetClientByTelephoneAsync<ClienteResponseDTO>("", "https://localhost:7003/Api/Clientes", txtTelefono.Text);
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

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }
    }
}
