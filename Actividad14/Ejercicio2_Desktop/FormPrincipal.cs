using Ejercicio1_Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio2_Desktop;

public partial class FormPrincipal : Form
{
    Sistema miEmpresa = new Sistema();

    public FormPrincipal()
    {
        InitializeComponent();
    }

    private void btnGenerar_Click(object sender, EventArgs e)
    {
        try
        {

            string destino = cbDestinos.SelectedItem as string;
            string tipo = cbTransporte.SelectedItem as string;

            string cuit = tbCuit.Text;
            string nombre = tbNombre.Text;
            string telefono = tbTelefono.Text;
            string tarjeta = tbTarjeta.Text;

            Ticket ticket=miEmpresa.CrearTicket(cuit, nombre, telefono, tarjeta, destino, tipo);

            //mostrar tickets
            if (ticket != null)
            {
                FormVer fVer = new FormVer();
                fVer.listBox1.Items.Add(ticket.ToString());
                fVer.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se pudo generar el ticket", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void bntResumen_Click(object sender, EventArgs e)
    {
        FormVer fVer = new FormVer();
        fVer.listBox1.Items.AddRange(miEmpresa.VerTickets());
        fVer.ShowDialog();
    }

    private void FormPrincipal_Load(object sender, EventArgs e)
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream("sistema.dat", FileMode.Open, FileAccess.Read);

            //solo en netcore
#pragma warning disable SYSLIB0011

            BinaryFormatter bf = new BinaryFormatter();

            miEmpresa = bf.Deserialize(fs) as Sistema;

            //solo en netcore
#pragma warning restore SYSLIB0011
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (fs != null) fs.Close();
        }

        //

        if (miEmpresa != null)
        {
            cbDestinos.Items.AddRange(miEmpresa.VerDestinos());
        }
    }

    private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
    {
        FileStream fs = null;
        try
        {
            fs = new FileStream("sistema.dat", FileMode.OpenOrCreate, FileAccess.Write);
#pragma warning disable SYSLIB0011
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, miEmpresa);
#pragma warning restore SYSLIB0011
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            if (fs != null) fs.Close();
        }

        //
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnEjemplo_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            string path = openFileDialog1.FileName;

            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                miEmpresa.ImportarTransporte(fs);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (fs != null) fs.Close(); ;
            }

            cbDestinos.Items.Clear();
            cbDestinos.Items.AddRange(miEmpresa.VerDestinos());
        }
    }

    private void cbTransporte_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbDestinos.SelectedIndex != -1 && cbTransporte.SelectedIndex != -1)
        {
            string destino = cbDestinos.SelectedItem as string;
            string tipo= cbTransporte.SelectedItem as string;

            Transporte t=miEmpresa.ResuelveTransporte(destino, tipo);
            if (t != null)
            {
                tbPrecio.Text = t.CalcularPrecioFinal().ToString("0.00");
            }
            else
            { 
                MessageBox.Show("No hay transporte disponible para ese destino y tipo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
