using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace UI_UX_Dashboard_P1
{
    public partial class Form1 : Form
    {
        private void Crea(string progressivo, string formato,
              string tipo,
              string dA,
              string idDispositivo,
              string latGeo,
              string longGeo,
              string dal,
              string al,
              string dataOraRilevazione,
              string aliquotaIVA,
              string imposta,
              string natura,
              string ventilazioneIVA,
              string ammontare,
              string rifNormativo,
              string importoParziale,
              string totaleAmmontareResi,
              string totaleAmmontareAnnulli,
              string beniInSospeso,
              string nonRiscossoServizi,
              string nonRiscossoFatture,
              string totaleDaFattureRT,
              string nonRiscossoDCRaSSN,
              string nonRiscossoOmaggio,
              string codiceAttivita,
              string numeroDocCommerciali,
              string pagatoContanti,
              string pagatoElettronico,
              string scontoApagare,
              string pagatoTicket,
              string numeroTicket,
              string venduto,
              string vendutoContante,
              string vendutoNoContante,
              string incassato,
              string incassatoRicarica,
              string incassatoVendita,
              string totaleResoTubiResto,
              string totaleCaricatoTubiResto,
              string totaleResoManualeTubiResto,
              string totaleCaricatoManualeTubiResto,
              string dataOraPrelievoPrec,
              string progressivoPrelievo,
              string vendutoC,
              string vendutoContanteC,
              string vendutoNoContanteC,
              string incassatoC,
              string incassatoRicaricaC,
              string incassatoVenditaC,
              string totaleResoTubiRestoC,
              string totaleCaricatoTubiRestoC,
              string totaleResoManualeTubiRestoC,
              string totaleCaricatoManualeTubiRestoC,
              string cFTecnico,
              string idPaese,
              string idCodice,
              string dataOra,
              string codice,
              string note,
              string numeroSw,
              string dataRelease,
              string matricola,
              string dataOraS,
              string codiceS,
              string noteS)
        {
            XDocument xDoc = new XDocument(
                 new XDeclaration("1.0", "utf-8", "yes"),
                 new XElement("DatiCorrispettivi", //Create the Root Element with specified Attributes such as Name
                     new XAttribute("versione", "COR10"),

                 new XElement("Trasmissione", //Create first Child that has mutliple Attributes
                      new XElement("Progressivo", progressivo),
                      new XElement("Formato", formato),
                      new XElement("Dispositivo",
                            new XElement("Tipo",tipo),
                            new XElement("IdDispositivo",idDispositivo),
                            new XElement("GeoLocalizzazione",
                                new XElement("Lat",latGeo),
                                new XElement("Long", longGeo)) 
                      )
                 ),

                new XElement("PeriodoInattivo", //Create first Child that has mutliple Attributes
                      new XElement("Dal", dal),
                      new XElement("Al", al)
                 ),

                new XElement("DataOraRilevazione", dataOraRilevazione),

                new XElement("DatiRT", //Create first Child that has mutliple Attributes
                      new XElement("Riepilogo",
                      new XElement("IVA",
                            new XElement("AliquotaIVA", aliquotaIVA),
                            new XElement("Imposta", imposta)
                      ),
                      new XElement("Natura", natura),
                      new XElement("VentilazioneIVA", ventilazioneIVA),
                      new XElement("Ammontare", ammontare),
                      new XElement("RifNormativo", rifNormativo),
                      new XElement("ImportoParziale", importoParziale),
                      new XElement("RifNormativo", rifNormativo),
                      new XElement("TotaleAmmontareResi", totaleAmmontareResi),
                      new XElement("TotaleAmmontareAnnulli", totaleAmmontareAnnulli),
                      new XElement("BeniInSospeso", beniInSospeso),
                      new XElement("NonRiscossoServizi", nonRiscossoServizi),
                      new XElement("NonRiscossoFatture", nonRiscossoFatture),
                      new XElement("TotaleDaFattureRT", totaleDaFattureRT),
                      new XElement("NonRiscossoDCRaSSN", nonRiscossoDCRaSSN),
                      new XElement("NonRiscossoOmaggi", nonRiscossoOmaggio),
                      new XElement("CodiceAttivita", codiceAttivita),
                      new XElement("Totali",
                            new XElement("NumeroDocCommerciali", numeroDocCommerciali),
                            new XElement("PagatoContanti", pagatoContanti),
                            new XElement("PagatoElettronico", pagatoElettronico),
                            new XElement("ScontoApagare", scontoApagare),
                            new XElement("Ticket",
                                new XElement("PagatoTicket", pagatoTicket),
                                new XElement("NumeroTicket", numeroTicket))
                      ))
                 ),



                new XElement("DatiDA", //Create first Child that has mutliple Attributes
                      new XElement("Periodo",
                        new XElement("Venduto", venduto),
                        new XElement("VendutoContante", vendutoContante),
                        new XElement("VendutoNoContante", vendutoNoContante),
                        new XElement("Incassato", incassato),
                        new XElement("IncassatoRicarica", incassatoRicarica),
                        new XElement("IncassatoVendita", incassatoVendita),
                        new XElement("TotaleResoTubiResto", totaleResoManualeTubiResto),
                        new XElement("TotaleCaricatoTubiResto", totaleCaricatoManualeTubiResto),
                        new XElement("TotaleResoManualeTubiResto", totaleResoManualeTubiResto),
                        new XElement("DataOraPrelievoPrec", dataOraPrelievoPrec),
                        new XElement("ProgressivoPrelievo", progressivoPrelievo)
                      ),
                      new XElement("Cumulato",
                        new XElement("Venduto", vendutoC),
                        new XElement("VendutoContante", vendutoContanteC),
                        new XElement("VendutoNoContante", vendutoNoContanteC),
                        new XElement("Incassato", incassatoC),
                        new XElement("IncassatoRicarica", incassatoRicaricaC),
                        new XElement("IncassatoVendita", incassatoVenditaC),
                        new XElement("TotaleResoTubiResto", totaleResoManualeTubiRestoC),
                        new XElement("TotaleCaricatoTubiResto", totaleCaricatoManualeTubiRestoC),
                        new XElement("TotaleResoManualeTubiResto", totaleResoManualeTubiRestoC)
                      )
                 ),

                new XElement("InterventoTecnico", //Create first Child that has mutliple Attributes
                      new XElement("CFTecnico", cFTecnico),
                      new XElement("IdIVALaboratorio",
                        new XElement("IdPaese", idPaese),
                        new XElement("IdCodice", idCodice)
                      ),
                     new XElement("DataOra", dataOra),
                     new XElement("Codice", codice),
                     new XElement("Note", note),
                     new XElement("NumeroSw", numeroSw),
                     new XElement("DataRelease", dataRelease)
                 ),
                 new XElement("Segnalazione",
                     new XAttribute("Matricola", matricola),
                     new XAttribute("DataOra", dataOraS),
                     new XAttribute("Codice", codiceS),
                     new XAttribute("Note", noteS)
                 ) //the second string is the value between brackets

                     ) //end of Root Element
                 );
            //save the data into a file name/path.
            xDoc.Save("scontrino.xml");
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnGeneraXML_Click(object sender, EventArgs e)
        {
            Crea(textBox66.Text, 
                textBox67.Text,
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text,
                textBox9.Text,
                textBox10.Text,
                textBox11.Text,
                textBox12.Text,
                textBox13.Text,
                textBox14.Text,
                textBox15.Text,
                textBox16.Text,
                textBox17.Text,
                textBox18.Text,
                textBox19.Text,
                textBox20.Text,
                textBox21.Text,
                textBox22.Text,
                textBox24.Text,
                textBox25.Text,
                textBox26.Text,
                textBox27.Text,
                textBox28.Text,
                textBox29.Text,
                textBox30.Text,
                textBox23.Text,
                textBox31.Text,
                textBox32.Text,
                textBox33.Text,
                textBox34.Text,
                textBox35.Text,
                textBox36.Text,
                textBox37.Text,
                textBox38.Text,
                textBox39.Text,
                textBox40.Text,
                textBox41.Text,
                textBox42.Text,
                textBox43.Text,
                textBox44.Text,
                textBox45.Text,
                textBox46.Text,
                textBox47.Text,
                textBox48.Text,
                textBox49.Text,
                textBox50.Text,
                textBox51.Text,
                textBox52.Text,
                textBox53.Text,
                textBox54.Text,
                textBox55.Text,
                textBox56.Text,
                textBox57.Text,
                textBox58.Text,
                textBox59.Text,
                textBox60.Text,
                textBox61.Text,
                textBox62.Text,
                textBox63.Text,
                textBox64.Text
                );
        }
    }
}
