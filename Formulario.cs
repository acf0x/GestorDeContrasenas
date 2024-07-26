using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;

namespace GestorDeContraseñas
{
    public partial class Formulario : Form
    {
        private static readonly Random random = new Random();
        private const string filePath = "contraseñas.txt";

        public Formulario()
        {
            InitializeComponent();
            trackBar1.Maximum = 24;
            numericUpDown1.Maximum = 24;
            trackBar1.Minimum = 1;
            numericUpDown1.Minimum = 1;
            numericUpDown1.Value = 12; // Valor por defecto
            CargarContraseñas();
        }

        private void GenerarContraseña()
        {
            int length = (int)numericUpDown1.Value;
            string minusculas = "abcdefghijklmnopqrstuvwxyz";
            string mayusculas = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "0123456789";
            string simbolos = "!@#$%&.";
            string chars = "";
            if (checkBoxMinusculas.Checked) chars += minusculas;
            if (checkBoxMayusculas.Checked) chars += mayusculas;
            if (checkBoxNumeros.Checked) chars += numeros;
            if (checkBoxSimbolos.Checked) chars += simbolos;

            // Validar que se haya seleccionado al menos una categoría de caracteres
            if (string.IsNullOrEmpty(chars))
            {
                MessageBox.Show("Debe seleccionar al menos una categoría de caracteres para generar una contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContraseña.Text = string.Empty;
                return;
            }

            // Validar que la longitud de la contraseña sea suficiente
            int categoriasSeleccionadas = (checkBoxMinusculas.Checked ? 1 : 0) +
                                          (checkBoxMayusculas.Checked ? 1 : 0) +
                                          (checkBoxNumeros.Checked ? 1 : 0) +
                                          (checkBoxSimbolos.Checked ? 1 : 0);

            if (length < categoriasSeleccionadas)
            {
                MessageBox.Show("La longitud de la contraseña debe ser mayor o igual al número de categorías de caracteres seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxContraseña.Text = string.Empty;
                return;
            }

            List<char> contraseña = new List<char>();

            // Añadir al menos un carácter de cada categoría seleccionada
            if (checkBoxMinusculas.Checked) contraseña.Add(minusculas[random.Next(minusculas.Length)]);
            if (checkBoxMayusculas.Checked) contraseña.Add(mayusculas[random.Next(mayusculas.Length)]);
            if (checkBoxNumeros.Checked) contraseña.Add(numeros[random.Next(numeros.Length)]);
            if (checkBoxSimbolos.Checked) contraseña.Add(simbolos[random.Next(simbolos.Length)]);

            // Rellenar con caracteres aleatorios de todas las categorías
            int minPorCategoria = length / categoriasSeleccionadas;

            foreach (var categoria in new[]
            {
                (checkBoxMinusculas.Checked, minusculas),
                (checkBoxMayusculas.Checked, mayusculas),
                (checkBoxNumeros.Checked, numeros),
                (checkBoxSimbolos.Checked, simbolos)
            })
            {
                if (categoria.Item1)
                {
                    for (int i = 0; i < minPorCategoria; i++)
                    {
                        contraseña.Add(categoria.Item2[random.Next(categoria.Item2.Length)]);
                    }
                }
            }

            // Mezclar orden de caracteres
            contraseña = contraseña.OrderBy(c => random.Next()).ToList();
            textBoxContraseña.Text = new string(contraseña.ToArray());
        }

        private void buttonGenerar_Click(object sender, EventArgs e)
        {
            GenerarContraseña();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = (int)numericUpDown1.Value;
        }

        private void buttonCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxContraseña.Text);
            MessageBox.Show("Contraseña copiada al portapapeles.");
        }

        private void buttonAnadir_Click(object sender, EventArgs e)
        {
            string contraseña = textBoxContraseña.Text;
            string tag = Prompt.ShowDialog("Ingrese un tag para la contraseña:", "Añadir Tag");

            dataGridView1.Rows.Add("******", tag);
            GuardarContraseña(contraseña, tag);
        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == "******")
                {
                    row.Cells[0].Value = ObtenerContraseña(row.Index); // Método que obtiene la contraseña real
                }
                else if (row.Cells[0].Value != null)
                {
                    row.Cells[0].Value = "******";
                }
            }
        }

        private string ObtenerContraseña(int rowIndex)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                if (rowIndex >= 0 && rowIndex < lines.Length)
                {
                    string[] parts = lines[rowIndex].Split(new[] { "||" }, StringSplitOptions.None);
                    return Desencriptar(parts[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener la contraseña: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return string.Empty;
        }

        private void GuardarContraseña(string contraseña, string tag)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(Encriptar(contraseña) + "||" + tag);
            }
        }

        private void CargarContraseñas()
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(new[] { "||" }, StringSplitOptions.None);
                    dataGridView1.Rows.Add("******", parts[1]);
                }
            }
        }

        private string Encriptar(string plainText)
        {
            byte[] data = Encoding.Unicode.GetBytes(plainText);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes("claveDeEncriptacion", new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = pdb.GetBytes(32);
                aes.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                        cs.Close();
                    }
                    plainText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return plainText;
        }

        private string Desencriptar(string cipherText)
        {
            cipherText = cipherText.Replace(" ", "+");
            byte[] data = Convert.FromBase64String(cipherText);
            using (Aes aes = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes("claveDeEncriptacion", new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                aes.Key = pdb.GetBytes(32);
                aes.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(data, 0, data.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }
            return cipherText;
        }

    }
}
