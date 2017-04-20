using System;
using System.Collections.Generic;
using System.Text;
// per Lettura/Scrittura 
using System.IO;
namespace App3
{
    class CRecord
    {
        public static int NCHIAMATA= 0;
        public static int TECNICO = 1;
        public static int CONTRATTO = 2;
        public static int COMMESSA = 3;
        public static int IMPIANTO = 4;
        public static int CODICE = 5;
        public static int CLIENTE = 6;
        public static int TELEFONO = 7;
        public static int EMAIL= 8;
        public static int CONTATTO = 9;
        public static int RIFERIMENTI = 10;
        public static int RICHIESTACLIENTE= 11;
        public static int PRESSO = 12;
        public static int TIPODIINTRVENTO = 13;
        public static int INDIRIZZOEMAIL= 14;
        public static int IDRIGA = 15;
        
        public static int numValori;
        String[] variabili;
        DateTime data;
        public CRecord()
        {
            numValori = 16;
            data = new DateTime();
            variabili = new string[]{
                "nChiamata",
                "Tecnico",
                "Contratto",
                "Commessa",
                "Impianto",
                "Codice",
                "Cliente",
                "Telefono",
                "E-mail",
                "Contatto",
                "Riferimenti",
                "Richiesta Cliente",
                "Presso",
                "Tipo di intervento",
                "Indirizzo E-mail",
                "Idriga"
            };
        }
        string getValore(int pos)
        {
            if ((pos > 0) && (pos < numValori))
            { return variabili[pos]; }
        }
        void setValore(string valore,int pos)
        {
            if ((pos > 0) && (pos < numValori))
            {
                variabili[pos] = valore;
            }
        }



    }

    class CLettura
    {
        CRecord record;
        StreamReader flusso;
        String filename;
        String[] valori;
        int pos, numeroSplit;
        CLettura()
        {
            pos = 0;
            numeroSplit = CRecord.numValori();
            record = new CRecord();
            flusso = new StreamReader();
            filename = "elenco_interventi.csv";
            valori = File.ReadAllText(@fileName).Split(';');  // CHANGES - Forse necessita un foreach per /r/n
        }

          


    }
}
