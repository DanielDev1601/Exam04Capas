using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class formRegionRegistrar : Form
    {
        public formRegionRegistrar()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtRegionName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtRegionName, "Ingrese Nombre Region");
            }
            else
            {
                NRegions negocio = new NRegions();
                formRegions frm = (formRegions)Application.OpenForms["frmRegions"];
                try
                {                    
                    string mensaje = string.Empty;
                    string regionName = txtRegionName.Text.Trim();
                    bool enabled =  true;                   
                    mensaje = negocio.Registrar(regionName, enabled);
                    if (mensaje == "true")
                    {
                        MessageBox.Show("Registro Exitoso");
                        this.txtRegionName.Text = "";
                        this.Hide();
                        frm.Show();
                        frm.listar();                        
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Comunicarse con el Administrador");
                }
                finally
                {
                    negocio = null;
                }
            }
        }

        private void frmRegionRegistrar_Load(object sender, EventArgs e)
        {

        }
    }
}
