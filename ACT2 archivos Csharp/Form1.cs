using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT2_archivos_Csharp
{
    public partial class Form1 : Form
    {
        private const string SequentialFilePath = "sequential_file.txt";
        private const string IndexedFilePath = "indexed_file.txt";
        private const string DirectAccessFilePath = "direct_access_file.dat";
        private TextBox txtKey;
        private TextBox txtValue;
        

        public Form1()
        {
            InitializeComponent();
            txtKey = new TextBox();
            txtKey.Location = new Point(10, 10);
            this.Controls.Add(txtKey);

            txtValue = new TextBox();
            txtValue.Location = new Point(10, 40);
            this.Controls.Add(txtValue);

       

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSequential_Click(object sender, EventArgs e)
        {
            // Operaciones para archivos secuenciales
            try
            {
                // Escritura en el archivo
                WriteSequentialFile();
                MessageBox.Show("Datos escritos correctamente en el archivo secuencial.");

                // Lectura del archivo
                ReadSequentialFile();
                MessageBox.Show("Datos leídos correctamente del archivo secuencial.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en operaciones de archivo secuencial: {ex.Message}");
            }
        }

        private void btnIndexed_Click(object sender, EventArgs e)
        {// Operaciones para archivos secuenciales indexados
            try
            {
                // Escritura en el archivo
                int key = int.Parse(txtKey.Text);
                string value = txtValue.Text;

                WriteIndexedFile(key, value);
                MessageBox.Show("Datos escritos correctamente en el archivo indexado.");

                // Lectura del archivo
                ReadIndexedFile();
                MessageBox.Show("Datos leídos correctamente del archivo indexado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en operaciones de archivo indexado: {ex.Message}");
            }
        }

        private void btnDirectAccess_Click(object sender, EventArgs e)
        {
            // Operaciones para archivos de acceso directo
            try
            {
                // Escritura en el archivo
                WriteDirectAccessFile();
                MessageBox.Show("Datos escritos correctamente en el archivo de acceso directo.");

                // Lectura del archivo
                ReadDirectAccessFile();
                MessageBox.Show("Datos leídos correctamente del archivo de acceso directo.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en operaciones de archivo de acceso directo: {ex.Message}");
            }
        }

        private void WriteSequentialFile()
        {
            using (StreamWriter writer = new StreamWriter(SequentialFilePath, true))  // Modo de escritura: true para añadir al final
            {
                writer.WriteLine("3,New,Record");  // Agrega nuevas líneas según sea necesario
            }
        }

        private void ReadSequentialFile()
        {
            textBoxOutput.Text = "";  // Limpia el contenido anterior en el cuadro de texto

            using (StreamReader reader = new StreamReader(SequentialFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Agrega cada línea al cuadro de texto
                    textBoxOutput.AppendText(line + Environment.NewLine);
                }
            }
        }
        // Métodos para archivos secuenciales indexados
        private void WriteIndexedFile(int key, string value)
        {
            using (StreamWriter writer = new StreamWriter(IndexedFilePath, true))
            {
                writer.WriteLine($"{key},{value}");
            }
        }

        private void ReadIndexedFile()
        {
            textBoxOutput.Text = "";  // Limpia el contenido anterior en el cuadro de texto

            Dictionary<int, string> indexedData = new Dictionary<int, string>();

            using (StreamReader reader = new StreamReader(IndexedFilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2 && int.TryParse(parts[0], out int key))
                    {
                        indexedData[key] = parts[1];
                    }
                }
            }

            // Ordena el diccionario por clave antes de mostrarlo
            var sortedData = indexedData.OrderBy(pair => pair.Key);

            // Agrega cada entrada ordenada del diccionario al cuadro de texto
            foreach (var entry in sortedData)
            {
                textBoxOutput.AppendText($"{entry.Key}: {entry.Value}" + Environment.NewLine);
            }
        }




        private void WriteDirectAccessFile()
        {
            DirectAccessRecord[] records = new DirectAccessRecord[]
            {
        new DirectAccessRecord { Id = 1, FirstName = "John", LastName = "Doe" },
        new DirectAccessRecord { Id = 2, FirstName = "Jane", LastName = "Smith" },
        new DirectAccessRecord { Id = 3, FirstName = "New", LastName = "Record" }  // Agrega nuevos registros según sea necesario
            };

            using (BinaryWriter writer = new BinaryWriter(File.Open(DirectAccessFilePath, FileMode.Append)))  // Cambia FileMode.Create a FileMode.Append
            {
                foreach (var record in records)
                {
                    byte[] recordBytes = StructureToByteArray(record);
                    writer.Write(recordBytes);
                }
            }
        }

        private void ReadDirectAccessFile()
        {
            textBoxOutput.Text = "";  // Limpia el contenido anterior en el cuadro de texto

            List<DirectAccessRecord> records = new List<DirectAccessRecord>();

            using (BinaryReader reader = new BinaryReader(File.Open(DirectAccessFilePath, FileMode.Open)))
            {
                while (reader.BaseStream.Position < reader.BaseStream.Length)
                {
                    byte[] recordBytes = reader.ReadBytes(Marshal.SizeOf(typeof(DirectAccessRecord)));
                    DirectAccessRecord record = ByteArrayToStructure<DirectAccessRecord>(recordBytes);
                    records.Add(record);
                }
            }

            // Agrega cada registro al cuadro de texto
            foreach (var record in records)
            {
                textBoxOutput.AppendText($"{record.Id}: {record.FirstName} {record.LastName}" + Environment.NewLine);
            }
        }

        // Métodos auxiliares y estructuras (mantén estos métodos en tu código)
        private static byte[] StructureToByteArray<T>(T structure) where T : struct
        {
            int size = Marshal.SizeOf(structure);
            byte[] array = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);

            try
            {
                Marshal.StructureToPtr(structure, ptr, false);
                Marshal.Copy(ptr, array, 0, size);
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return array;
        }

        private static T ByteArrayToStructure<T>(byte[] array) where T : struct
        {
            T structure;
            int size = Marshal.SizeOf(typeof(T));

            IntPtr ptr = Marshal.AllocHGlobal(size);
            try
            {
                Marshal.Copy(array, 0, ptr, size);
                structure = (T)Marshal.PtrToStructure(ptr, typeof(T));
            }
            finally
            {
                Marshal.FreeHGlobal(ptr);
            }

            return structure;
        }

        // Estructura para archivos de acceso directo
        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        struct DirectAccessRecord
        {
            public int Id;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string FirstName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
            public string LastName;
        }
        private void btnWrite_Click(object sender, EventArgs e)
        {
            // Operación para archivos secuenciales indexados (escritura)
            try
            {
                int key = int.Parse(txtKey.Text);
                string value = txtValue.Text;

                WriteIndexedFile(key, value);
                MessageBox.Show("Datos escritos correctamente en el archivo indexado.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al escribir datos en el archivo indexado: {ex.Message}");
            }
        }
    }
}
