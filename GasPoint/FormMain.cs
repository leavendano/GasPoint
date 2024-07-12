using GasPoint.Core.Interfaces;

namespace GasPoint
{
    public partial class FormMain : Form
    {
        private readonly IEnablerService _enablerService;
        public FormMain(IEnablerService service)
        {
            InitializeComponent();
            _enablerService = service;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtTelefono.Mask = "0000000000";
            txtTelefono.Focus();
        }

        private void cbxPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex + 1;
            if (selectedIndex > 0)
            {
                var respuesta = _enablerService.GetLastDeliveryByHostID(selectedIndex);
                txtFecha.Text = respuesta.Completed_TS.ToString();
                txtProducto.Text = respuesta.GradeName;
                txtImporte.Text = respuesta.Delivery_Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtTelefono.Text = "";
            txtTelefono.Focus();
            cbxPosicion.SelectedIndex = -1;
        }
    }
}
