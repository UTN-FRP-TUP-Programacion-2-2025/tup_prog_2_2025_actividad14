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

            string destino = cbDestino.SelectedItem as string;
            string tipo = cbTransporte.SelectedItem as string;

            string cuit = tbCuit.Text;
            string nombre = tbNombre.Text;
            string telefono = tbTelefono.Text;
            string tarjeta = tbTarjeta.Text;

            miEmpresa.CrearTicket(cuit, nombre, telefono, tarjeta, destino, tipo);
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
        }
    }
}
