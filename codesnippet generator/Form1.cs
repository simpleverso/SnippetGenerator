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
                MessageBox.Show("Error, introduciste mal los parametros");
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
                    escritor.WriteElementString("Title", txt_Titulo.Text.ToString());
                    escritor.WriteElementString("Shortcut", Txt_accesodirecto.Text.ToString());
                    escritor.WriteElementString("Description", Txt_comentario.Text.ToString());
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
                    escritor.WriteElementString("ID", id[i].ToString());
                    escritor.WriteElementString("ToolTip", tooltip[i].ToString());
                    escritor.WriteElementString("Default", valdefecto[i].ToString());
                    escritor.WriteEndElement();

                }
                escritor.WriteEndElement();


                escritor.WriteStartElement("Code");
                escritor.WriteAttributeString("Language", cmb_lenguajes.Text);

                escritor.WriteCData(txt_Codigo.Text+"$end$");

                escritor.WriteEndElement();

                escritor.WriteStartElement("Imports");
                    for (int i = 0; i < usings.Length; i++)
                    {
                        escritor.WriteStartElement("Import");
                        escritor.WriteElementString("Namespace", usings[i].ToString());
                        escritor.WriteEndElement();
                    }
            escritor.WriteEndElement();

                escritor.WriteEndElement();
                escritor.WriteEndElement();
                escritor.WriteEndElement();

            escritor.Close();
        fin:
            MessageBox.Show("Snippet Generado Correctamente");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_lenguajes.SelectedIndex = 1;
        }
    }
}
