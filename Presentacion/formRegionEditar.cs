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

namespace Presentacion
{
    public partial class formRegionEditar : Form
    {
        public formRegionEditar()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (txtRegionNameEdit.Text.Trim() == "")
            {
                errorProvider1.SetError(txtRegionNameEdit, "Ingrese Nombre Region");
            }
            else
            {
                NRegions negocio = new NRegions();
                formRegions frm = (formRegions)Application.OpenForms["frmRegions"];
                try
                {
                    string mensaje = string.Empty;
                    int id = Convert.ToInt32(txtIdEdit.Text);
                    string regionName = txtRegionNameEdit.Text.Trim();
                    bool enabled = true;
                    mensaje = negocio.Editar(id, regionName, enabled);
                    if (mensaje == "true")
                    {
                        MessageBox.Show("Se grabo Correctamente");
                        this.txtRegionNameEdit.Text = "";
                        this.txtIdEdit.Text = "";
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
    }
}
