using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DataLayerHandler.DatatAcces
{
    public class ObjednavkaGateway
    {
        public static string TableName = "objednavka";
        public static string SqlSelect =
        "Select ido, datum_vypujceni, datum_vraceni, informace_o_vraceni, Poskozen, Cena, Stav_automobilu, Sluzby_idS, Automobil_idA, Zakaznik_idZ FROM objednavka";
        public static string SqlSelectPoskozene =
        "Select ido, datum_vypujceni, datum_vraceni, informace_o_vraceni, Poskozen, Cena, Stav_automobilu, Sluzby_idS, Automobil_idA, Zakaznik_idZ FROM objednavka  where Poskozen = 'A'";
        public static string SqlSelectByZakaznik = " Select ido, datum_vypujceni, datum_vraceni, informace_o_vraceni, Poskozen, Cena, Stav_automobilu, Sluzby_idS, Automobil_idA, Zakaznik_idZ FROM objednavka  where Zakaznik_idZ = @idz";



        public static Collection<Objednavka> Select()
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlSelect);
            SqlDataReader reader = db.Select(command);

            Collection<Objednavka> objednavky = Read(reader);
            reader.Close();

            db.Close();
            return objednavky;
        }

        public static Collection<Objednavka> SelectPoskozene()
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlSelectPoskozene);
            SqlDataReader reader = db.Select(command);

            Collection<Objednavka> objednavky = Read(reader);
            reader.Close();

            db.Close();
            return objednavky;
        }

        public static Collection<Objednavka> SelectzByZakaznik(int idz)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlSelectPoskozene);
            command.Parameters.AddWithValue("@idz", idz);
            SqlDataReader reader = db.Select(command);
            Collection<Objednavka> objednavky = Read(reader);
            reader.Close();

            db.Close();
            return objednavky;
        }

        private static Collection<Objednavka> Read(SqlDataReader reader)
        {
            Collection<Objednavka> objednavky = new Collection<Objednavka>();

            while (reader.Read())
            {
                //idTrasy, idObj , adresa, firma, typ"
                Objednavka objednavka = new Objednavka();
                int i = -1;
                objednavka.ido = reader.GetInt32(++i);
                objednavka.datum_vypujceni = reader.GetDateTime(++i);
                objednavka.datum_vraceni = reader.GetDateTime(++i);
                objednavka.informace_o_vraceni = reader.GetString(++i);
                objednavka.Poskozen = reader.GetString(++i);
                objednavka.Cena = reader.GetInt32(++i);
                objednavka.Stav_automobilu = reader.GetString(++i);
                objednavka.Sluzby_idS = reader.GetInt32(++i);
                objednavka.Automobil_idA = reader.GetInt32(++i);
                objednavka.Zakaznik_idZ = reader.GetInt32(++i);

                objednavky.Add(objednavka);
            }
            return objednavky;
        }

        public static void ExportToXML(string fileName, int idz)
        {
            using (StringWriter stringWriter = new StringWriter(new StringBuilder()))
            {
                Collection<Objednavka> objednavky = SelectzByZakaznik(idz);
                foreach (var objednavka in objednavky)
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Objednavka));
                    xmlSerializer.Serialize(stringWriter, objednavka);
                }
                File.WriteAllText(fileName + ".xml", stringWriter.ToString());
            }
        }

    }
}
