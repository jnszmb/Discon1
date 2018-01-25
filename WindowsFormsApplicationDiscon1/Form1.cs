using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplicationDiscon1
{
    public partial class Form1 : Form
    {
        OleDbConnection con = null;
        OleDbDataAdapter adapter = null;
        OleDbDataAdapter adapterArtikel = null;
        OleDbDataAdapter adGruppe = null;
        DataSet ds = null;

        List<DisplayArtikel> lsArtikel = new List<DisplayArtikel>();
        public Form1()
        {
            InitializeComponent();
            ds = new DataSet();
            con = new OleDbConnection();
            con.ConnectionString = Properties.Settings.Default.DBCon;
            adapterArtikel = new OleDbDataAdapter("Select * from tArtikel", con);
            adGruppe = new OleDbDataAdapter("Select * from tArtGruppe", con);
            adGruppe.FillSchema(ds, SchemaType.Source, "AGruppe");
            adGruppe.Fill(ds, "AGruppe");
        }

        private void buttonDataAdapter_Click(object sender, EventArgs e)
        {
            
            adapter = new OleDbDataAdapter("select * from tKunde", con);
            adapter.Fill(ds, "Kunde");
        }

        private void buttonDsRead_Click(object sender, EventArgs e)
        {
            DataTableReader reader = ds.Tables["Kunde"].CreateDataReader();
            listBoxAusgabe.Items.Clear();
            while(reader.Read())
            {
                listBoxAusgabe.Items.Add(reader.GetString(2));
            }
            reader.Close();
            dataGridViewAusgabe.DataSource = ds;
            dataGridViewAusgabe.DataMember = "Kunde";

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            dataGridViewAusgabe.DataSource = null;
        }

        private void buttonArtikel_Click(object sender, EventArgs e)
        {
            adapterArtikel.FillSchema(ds, SchemaType.Source, "Artikel");
            ds.Tables["Artikel"].Columns[0].AutoIncrement = true;
            adapterArtikel.Fill(ds, "Artikel");
            DataTableReader reader = ds.Tables["Artikel"].CreateDataReader();
            while(reader.Read())
            {
                DisplayArtikel da = new DisplayArtikel();
                da.ArtikelOid = reader.GetInt32(0);
                da.ArtNr = reader.GetString(1);
                da.ArtGruppe = GetArtGruppe(reader.GetInt32(2));
                da.Bezeichnung = reader.GetString(3);
                da.Bestand = reader.GetByte(4);
                da.Meldebestand = reader.GetInt16(5);           
                lsArtikel.Add(da);
            }
            reader.Close();
            dataGridViewAusgabe.DataSource = lsArtikel;
            
            
            //dataGridViewAusgabe.DataSource = ds;
            //dataGridViewAusgabe.DataMember = "Artikel";
            //adapterGruppe = new OleDbDataAdapter("Select * from tArtGruppe", con);
            //adapterGruppe.Fill(ds, "ArtGruppe");

           
            
            
            
            
            
            //DataTableReader reader = ds.Tables["Artikel"].CreateDataReader();
            //while(reader.Read())
            //{
            //    DisplayArtikel da = new DisplayArtikel();
            //    da.ArtNr = reader.GetString(1);
            //    da.Bezeichnung = reader.GetString(3);
            //    da.ArtGruppe = GetArtGruppe(reader.GetInt32(2));
            //    lsArtikel.Add(da);

            //}
            //dataGridViewAusgabe.DataSource = lsArtikel;
        }

        private string GetArtGruppe(int id)
        {
            String bez = "xxx";
            DataRow row =  ds.Tables["AGruppe"].Rows.Find(id);
            bez = (String)row[1];
            return bez;
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            ds.WriteXml("Bestellung.xml", XmlWriteMode.DiffGram);
            ds.WriteXmlSchema("Bestellung.xsd");

        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            ds.ReadXmlSchema("Bestellung.xsd"); // liest Datentypen aus
            ds.ReadXml("Bestellung.xml", XmlReadMode.DiffGram);
            dataGridViewAusgabe.DataSource = ds;
            dataGridViewAusgabe.DataMember = "Artikel";
            DataTableReader reader = ds.Tables["Kunde"].CreateDataReader();
            listBoxAusgabe.Items.Clear();
            while (reader.Read())
            {
                listBoxAusgabe.Items.Add(reader.GetString(2));
            }
            reader.Close();
        }
        private void buttonDBSync_Click(object sender, EventArgs e)
        {
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapterArtikel);
            adapterArtikel.DeleteCommand = builder.GetDeleteCommand();
            adapterArtikel.InsertCommand = builder.GetInsertCommand();
            adapterArtikel.UpdateCommand = builder.GetUpdateCommand();
            adapterArtikel.Update(ds.Tables["Artikel"]);
        }
    }
}
