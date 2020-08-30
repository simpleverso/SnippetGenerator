using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace codesnippet_generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = txt_ID.Text.Split(',');
            var tooltip = Txt_descripcion.Text.Split(',');
            var valdefecto = Txt_predeterminado.Text.Split(',');
            var usings = txt_usings.Text.Split(',');

            if (id.Length!=tooltip.Length||tooltip.Length!=valdefecto.Length)
            {
                MessageBox.Show("Error, introdujiste mal los parametros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto fin;
            }

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineChars = "\r\n";

            string direccion = Environment.CurrentDirectory;
            string nueva = direccion += "\\"+Txt_accesodirecto.Text.ToString()+".snippet";

            XmlWriter escritor = XmlWriter.Create(nueva, settings);

            escritor.WriteStartDocument(true);
            escritor.WriteStartElement("CodeSnippets");
            escritor.WriteStartElement("CodeSnippet");
            escritor.WriteAttributeString("Format", "1.0.0");
            escritor.WriteStartElement("Header");
                    escritor.WriteElementString("Title", txt_Titulo.Text.ToString().Trim());
                    escritor.WriteElementString("Shortcut", Txt_accesodirecto.Text.ToString().Trim());
                    escritor.WriteElementString("Description", Txt_comentario.Text.ToString().Trim());
                    escritor.WriteElementString("Author", "Gonzalo Santiago Martinez");
                            escritor.WriteStartElement("SnippetTypes");
                                escritor.WriteElementString("SnippetType", "Expansion");
                                escritor.WriteElementString("SnippetType", "SurroundsWith");
                            escritor.WriteEndElement();
            escritor.WriteEndElement();

            escritor.WriteStartElement("Snippet");
                escritor.WriteStartElement("Declarations");

                for (int i = 0; i < id.Length; i++)
                {
                    escritor.WriteStartElement("Literal");
                    escritor.WriteElementString("ID", id[i].ToString().Trim());
                    escritor.WriteElementString("ToolTip", tooltip[i].ToString().Trim());
                    escritor.WriteElementString("Default", valdefecto[i].ToString().Trim());
                    escritor.WriteEndElement();

                }
                escritor.WriteEndElement();


                escritor.WriteStartElement("Code");
                escritor.WriteAttributeString("Language", cmb_lenguajes.Text.Trim());

                if (check_final.Checked)
                {
                    escritor.WriteCData(txt_Codigo.Text.Trim() + "$end$");
                }
                else
                {
                    escritor.WriteCData(txt_Codigo.Text.Trim());
                }
            

                escritor.WriteEndElement();

                escritor.WriteStartElement("Imports");
                    for (int i = 0; i < usings.Length; i++)
                    {
                        escritor.WriteStartElement("Import");
                        escritor.WriteElementString("Namespace", usings[i].ToString().Trim());
                        escritor.WriteEndElement();
                    }
            escritor.WriteEndElement();

                escritor.WriteEndElement();
                escritor.WriteEndElement();
                escritor.WriteEndElement();

            escritor.Close();
        fin:
            MessageBox.Show("Snippet Generado Correctamente","Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_lenguajes.SelectedIndex = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {//buscar archivo
              
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                Title = "Buscar Snippets",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "snippet",
                Filter = "Archivos Snippet (*.snippet)|*.snippet",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_direccion.Text = openFileDialog1.FileName;

                    abrirSnippet();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al abrir archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void abrirSnippet()
        {
            txt_Codigo.Text = "";
            Txt_comentario.Text = "";
            Txt_descripcion.Text = "";
            txt_ID.Text = "";
            Txt_predeterminado.Text = "";
            txt_Titulo.Text = "";
            txt_usings.Text = "";

            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(@txt_direccion.Text);

            try
            {
                txt_Titulo.Text = xdoc.GetElementsByTagName("Title")[0].InnerText;
            }
            catch (Exception)
            {
                Console.WriteLine("Error al obtener el titulo");
            }

            try
            {
                Txt_accesodirecto.Text = xdoc.GetElementsByTagName("Shortcut")[0].InnerText;
            }
            catch (Exception)
            {
                Console.WriteLine("Error al obtener el acceso directo");
            }

            try
            {
                Txt_comentario.Text = xdoc.GetElementsByTagName("Description")[0].InnerText;
            }
            catch (Exception)
            {
                Console.WriteLine("Error al obtener el comentario");
            }


            try
            {
                XElement XTemp = XElement.Load(@txt_direccion.Text);
                var queryCDATAXML = from element in XTemp.DescendantNodes()
                                    where element.NodeType == System.Xml.XmlNodeType.CDATA
                                    select element.Parent.Value.Trim();
                txt_Codigo.Text = queryCDATAXML.ToList<string>()[0].ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al obtener el CDATA");
            }


            try
            {
                if (txt_Codigo.Text.EndsWith("$end$"))
                {
                    check_final.Checked = true;
                    try
                    {
                        txt_Codigo.Text = txt_Codigo.Text.Substring(0, txt_Codigo.Text.Length - 5);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error al obtener el código");
                    }
                }
                else
                {
                    check_final.Checked = false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al hacer parsing de CDATA");
            }
            

            try
            {
                var res = xdoc.GetElementsByTagName("Code");
                cmb_lenguajes.Text = res[0].Attributes["Language"].Value;
            }
            catch (Exception)
            {
                Console.WriteLine("Error al obtener el lenguaje");
            }
            


            var ids = xdoc.GetElementsByTagName("ID");
            foreach (XmlNode item in ids)
            {
                txt_ID.Text += item.InnerText + ", ";
            }

            var descps = xdoc.GetElementsByTagName("ToolTip");
            foreach (XmlNode item in descps)
            {
                Txt_descripcion.Text += item.InnerText + ", ";
            }

            var defaultz = xdoc.GetElementsByTagName("Default");
            foreach (XmlNode item in defaultz)
            {
                Txt_predeterminado.Text += item.InnerText + ", ";
            }

            var usninzsd = xdoc.GetElementsByTagName("Namespace");
            foreach (XmlNode item in usninzsd)
            {
                txt_usings.Text += item.InnerText + ", ";
            }

            //txt_ID.Text = xdoc.GetElementsByTagName("ID")[0].InnerText;
            //Txt_descripcion.Text = xdoc.GetElementsByTagName("ToolTip")[0].InnerText;
            //Txt_predeterminado.Text = xdoc.GetElementsByTagName("Default")[0].InnerText;
            //txt_usings.Text = xdoc.GetElementsByTagName("Namespace")[0].InnerText;
            if (txt_ID.Text.EndsWith(" "))
            {
                try
                {
                    txt_ID.Text = txt_ID.Text.Substring(0, txt_ID.Text.Length - 2);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al obtener el id");
                }
            }
            if (Txt_descripcion.Text.EndsWith(" "))
            {
                try
                {
                    Txt_descripcion.Text = Txt_descripcion.Text.Substring(0, Txt_descripcion.Text.Length - 2);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al obtener la descripcion");
                }
            }
            if (Txt_predeterminado.Text.EndsWith(" "))
            {
                try
                {
                    Txt_predeterminado.Text = Txt_predeterminado.Text.Substring(0, Txt_predeterminado.Text.Length - 2);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al obtener los valores predeterminados");
                }
            }
            if (txt_usings.Text.EndsWith(" "))
            {
                try
                {
                    txt_usings.Text = txt_usings.Text.Substring(0, txt_usings.Text.Length - 2);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al obtener usings");
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txt_direccion.Text = files[0];
                abrirSnippet();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void Form1_DragOver(object sender, DragEventArgs e)
        {
            //string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            //txt_direccion.Text = files[0];
            //abrirSnippet();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                txt_direccion.Text = files[0];
                abrirSnippet();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al abrir archivo","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
