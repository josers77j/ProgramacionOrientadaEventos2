using EjercicioTienditaForms.Forms;
using ItemsLibrary;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioTienditaForms.Forms
{
    public partial class MainForm : Form
    {
        //El evento load no me aparecio, por mas que busque, por lo que decidi cargar los datos en el constructor directamente
        private List<Verduras> listaDeVerduras = new List<Verduras>();
        private List<Ventas> listadeVentas  = new List<Ventas>();
        public MainForm()
        {
            InitializeComponent();

            // Verduras precargadas    
            listaDeVerduras.Add(new Verduras { Nombre = "Zanahoria", Precio = 1.5M });
            listaDeVerduras.Add(new Verduras { Nombre = "Tomate", Precio = 2.0M });
            listaDeVerduras.Add(new Verduras { Nombre = "Lechuga", Precio = 1.0M });

            // Ventas precargadas
            listadeVentas.Add(new Ventas { cliente = "Valeria", cantidad = 3, total = 9, verdura = "Zanahoria" });

            VerdurasListBox.Items.AddRange(listaDeVerduras.ToArray());
            VerdurasComboBox.Items.AddRange(listaDeVerduras.ToArray());
            VentasListBox.Items.AddRange(listadeVentas.ToArray());

            // Llama a los métodos de actualización de los ListBox de ventas
            ActualizarClientesFrecuentes();
            ActualizarVerdurasMasVendidas();
        }



        #region Eventos

        private void GuardarVerduraButton_Click(object sender, EventArgs e)
        {
            if (verificarEntradas())
            {
                Verduras nuevaVerdura = new Verduras
                {
                    Nombre = NombreVerduraTextBox.Text,
                    Precio = decimal.Parse(PrecioVerduraTextBox.Text)
                };

                listaDeVerduras.Add(nuevaVerdura);  // Agrega a la lista
                VerdurasListBox.Items.Add(nuevaVerdura);
                VerdurasComboBox.Items.Add(nuevaVerdura);

                NombreVerduraTextBox.Clear();
                PrecioVerduraTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Error al guardar datos: \nLos campos deben estar llenos y correspondientes a un nombre u precio en formato numerico");
            }
        }
        private void EliminarVerduraButton_Click(object sender, EventArgs e)
        {
            if (VerdurasListBox.SelectedItem is Verduras verduraSeleccionada)
            {
                listaDeVerduras.Remove(verduraSeleccionada);  
                VerdurasListBox.Items.Remove(verduraSeleccionada);
                VerdurasComboBox.Items.Remove(verduraSeleccionada);
            }
        }

        private Verduras VerduraSeleccionada
        {
            get { return VerdurasListBox.SelectedItem as Verduras; }
            set { VerdurasListBox.Items[VerdurasListBox.SelectedIndex] = value; }
        }

        private void ActualizarVerduraButton_Click(object sender, EventArgs e)
        {
            if (VerduraSeleccionada != null)
            {
                if (verificarEntradas())
                {
                    VerduraSeleccionada.Nombre = NombreVerduraTextBox.Text;
                    VerduraSeleccionada.Precio = decimal.Parse(PrecioVerduraTextBox.Text);

                    int index = listaDeVerduras.IndexOf(VerduraSeleccionada);
                    VerdurasListBox.Items[index] = VerduraSeleccionada;
                    VerdurasComboBox.Items[index] = VerduraSeleccionada;

                    NombreVerduraTextBox.Clear();
                    PrecioVerduraTextBox.Clear();
                }
                else
                {
                    MessageBox.Show("Error al actualizar parametros: \n Debe insertar un nombre y un precio numerico");
                }
            }
        }

        private void VerdurasListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VerdurasListBox.SelectedItem is Verduras verduraSeleccionada)
            {
                NombreVerduraTextBox.Text = verduraSeleccionada.Nombre;
                PrecioVerduraTextBox.Text = verduraSeleccionada.Precio.ToString();
            }
            else
            {
                NombreVerduraTextBox.Clear();
                PrecioVerduraTextBox.Clear();
            }
        }

        private void ProcesarVentaButton_Click(object sender, EventArgs e)
        {
            if (VerdurasComboBox.SelectedItem is Verduras verduraSeleccionada &&
                !string.IsNullOrEmpty(ClienteTextBox.Text) &&
                int.TryParse(CantidadTextBox.Text, out int cantidadVenta))
            {
                Ventas nuevaVenta = new Ventas
                {
                    cliente = ClienteTextBox.Text,
                    cantidad = cantidadVenta,
                    total = verduraSeleccionada.Precio * cantidadVenta,
                    verdura = verduraSeleccionada.Nombre
                };

                listadeVentas.Add(nuevaVenta);
                VentasListBox.Items.Add(nuevaVenta);

                var ventasConMayorCantidad = listadeVentas.OrderByDescending(v => v.cantidad).Take(3).ToList();

                ActualizarClientesFrecuentes();
                ActualizarVerdurasMasVendidas();


                ClienteTextBox.Clear();
                CantidadTextBox.Clear();
                VerdurasComboBox.SelectedItem.Equals("");
            }
            else
            {
                MessageBox.Show("Error al procesar la venta: \nDebe seleccionar una verdura, especificar la cantidad e ingresar un nombre de un cliente.");
            }
        }
        #endregion


        #region Metodos 

        private bool verificarEntradas()
        {
            if (!string.IsNullOrEmpty(NombreVerduraTextBox.Text) &&
                !string.IsNullOrEmpty(PrecioVerduraTextBox.Text) &&
                float.TryParse(PrecioVerduraTextBox.Text, out float precioVerdura))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ActualizarClientesFrecuentes()
        {
            var clientesTotales = listadeVentas
                .GroupBy(venta => venta.cliente)
                .Select(grupo => new
                {
                    Cliente = grupo.Key,
                    Total = grupo.Sum(venta => venta.total)
                })
                .OrderByDescending(item => item.Total)
                .ToList();

            ClientesFrecuentesListBox.Items.Clear();
            foreach (var cliente in clientesTotales)
            {
                ClientesFrecuentesListBox.Items.Add($"{cliente.Cliente} - Total: ${cliente.Total}");
            }
        }

        private void ActualizarVerdurasMasVendidas()
        {
            var verdurasTotales = listadeVentas
                .GroupBy(venta => venta.verdura)
                .Select(grupo => new
                {
                    Verdura = grupo.Key,
                    Cantidad = grupo.Sum(venta => venta.cantidad)
                })
                .OrderByDescending(item => item.Cantidad)
                .ToList();

            VerdurasmasVendidasListBox.Items.Clear();
            foreach (var verdura in verdurasTotales)
            {
                VerdurasmasVendidasListBox.Items.Add($"{verdura.Verdura} - Cantidad vendida: {verdura.Cantidad}");
            }
        }

        #endregion

     




    }
}
