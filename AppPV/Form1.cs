using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AppPV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {



                int id_cliente = Convert.ToInt32(idtxtbox.Text);
                Conexion.Conectar();
                string actualizar = "UPDATE Clientes SET Nombre=@Nombre,ApellidoPaterno=@ApellidoPaterno,ApellidoMaterno=@ApellidoMaterno,Domicilio=@Domicilio,FechaNacimiento=@FechaNacimiento,Telefono=@Telefono where id_Cliente=@id_Cliente";
                SqlCommand cm2 = new SqlCommand(actualizar, Conexion.Conectar());
                cm2.Parameters.AddWithValue("@id_Cliente", id_cliente);
                cm2.Parameters.AddWithValue("@Nombre", Nombretxtbox.Text);
                cm2.Parameters.AddWithValue("@ApellidoPaterno", Apellidotxtbox.Text);
                cm2.Parameters.AddWithValue("@ApellidoMaterno", Maternotxtbox.Text);
                cm2.Parameters.AddWithValue("@Domicilio", Domiciliotxtbox.Text);
                cm2.Parameters.AddWithValue("@FechaNacimiento", Fechanactxtbox.Text);
                cm2.Parameters.AddWithValue("@Telefono", Teltxtbox.Text);


                cm2.ExecuteNonQuery();

                MessageBox.Show("Los datos fueron actualizados");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Algun dato fue invalido o nulo favor de revisar o quizas"+ex.Message);
            }
            



                
            }
       

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Antes de borrar necesitas especificar el id del cliente");
            Conexion.Conectar();
            string borrardatos = "DELETE FROM Clientes where id_cliente=@id_Cliente";
            SqlCommand cm3 = new SqlCommand(borrardatos, Conexion.Conectar());
            cm3.Parameters.AddWithValue("@id_Cliente",idtxtbox.Text);

            if (idtxtbox.Text == "")
            {
                MessageBox.Show("Deben especificar un id para borrar");
            }

            else
            {





                cm3.ExecuteNonQuery();
                MessageBox.Show("Los datos fueron borrados");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)  
        {
        

            try
            {
                int id_cliente = Convert.ToInt32(idtxtbox.Text);
                Conexion.Conectar();
                string insertar = "INSERT INTO Clientes (id_Cliente,Nombre,ApellidoPaterno,ApellidoMaterno,Domicilio,FechaNacimiento,Telefono)" + "VALUES(@id_Cliente,@Nombre,@ApellidoPaterno,@ApellidoMaterno,@Domicilio,@FechaNacimiento,@Telefono)";
                SqlCommand cmd1 = new SqlCommand(insertar, Conexion.Conectar());
                cmd1.Parameters.AddWithValue("@id_Cliente", id_cliente);
                cmd1.Parameters.AddWithValue("@Nombre", Nombretxtbox.Text);
                cmd1.Parameters.AddWithValue("@ApellidoPaterno", Apellidotxtbox.Text);
                cmd1.Parameters.AddWithValue("@ApellidoMaterno", Maternotxtbox.Text);
                cmd1.Parameters.AddWithValue("@Domicilio", Domiciliotxtbox.Text);
                cmd1.Parameters.AddWithValue("@FechaNacimiento", Fechanactxtbox.Text);
                cmd1.Parameters.AddWithValue("@Telefono", Teltxtbox.Text);



                cmd1.ExecuteNonQuery();


                MessageBox.Show("Los datos fueron agregados");
            }

            catch(Exception ex)
            {
                MessageBox.Show("Algun dato es invalido o esta vacio por favor de revisar"+ex.Message);
                
            }


           



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conectar();
            MessageBox.Show("Conexion exitosa");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
        }

        private void idtxtbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
