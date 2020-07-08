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
    public class AutomobilGateway
    {
        public static string SqlSelect = "Select ida,znacka,Model,Rok_vyroby,Informace_o_poskozeni, Hladina_paliva, Zpusobily_jizdy,Cena_za_den from automobil";
        public static string SqlSelectByZnacka = "Select ida, znacka, Model, Rok_vyroby, Informace_o_poskozeni, Hladina_paliva, Zpusobily_jizdy, Cena_za_den FROM automobil where znacka = @znacka";
        public static string SqlSelectByZnackaModel = "Select  ida,znacka,Model,Rok_vyroby,Informace_o_poskozeni, Hladina_paliva, Zpusobily_jizdy,Cena_za_den from automobil where znacka = @znacka and Model = @model";
        public static string SqlDetail = "Select  ida,znacka,Model,Rok_vyroby,Informace_o_poskozeni, Hladina_paliva, Zpusobily_jizdy,Cena_za_den from automobil where znacka = @znacka and Model = @model";
        public static string SqlSelectById = "Select ida,znacka,Model,Rok_vyroby,Informace_o_poskozeni, Hladina_paliva, Zpusobily_jizdy,Cena_za_den from automobil WHERE ida = @Id";

        public static Collection<Automobil> Select()
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlSelect);
            SqlDataReader reader = db.Select(command);

            Collection<Automobil> automobily = Read(reader);
            reader.Close();

            db.Close();
            return automobily;

        }

        public static Automobil Detail(String Znacka, String Model)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlDetail);

            command.Parameters.AddWithValue("@znacka", Znacka);
            command.Parameters.AddWithValue("@model", Model);
            SqlDataReader reader = db.Select(command);

            Collection<Automobil> automobily = Read(reader);
            Automobil automobil = null;
            if (automobily.Count == 1)
            {
                automobil = automobily[0];
            }
            reader.Close();

            db.Close();
            return automobil;
        }

        public static Collection<Automobil> SelectByID(int Id)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlSelectById);

            command.Parameters.AddWithValue("@Id", Id);
            SqlDataReader reader = db.Select(command);

            Collection<Automobil> automobily = Read(reader);
            reader.Close();

            db.Close();
            return automobily;
        }


        public static Collection<Automobil> SelectByZnackaModel (String Znacka, String Model)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlSelect);


            command.Parameters.AddWithValue("@znacka", Znacka);
            command.Parameters.AddWithValue("@model", Model);
            SqlDataReader reader = db.Select(command);

            Collection<Automobil> automobily = Read(reader);
            reader.Close();

            db.Close();
            return automobily;
        }

        public static Collection<Automobil> SelectByZnacka(String Znacka)
        {
            var db = new Database();
            db.Connect();

            SqlCommand command = db.CreateCommand(SqlSelectByZnacka);

            command.Parameters.AddWithValue("@znacka", Znacka);
            SqlDataReader reader = db.Select(command);

            Collection<Automobil> automobily = Read(reader);
            reader.Close();

            db.Close();
            return automobily;
        }


        private static Collection<Automobil> Read(SqlDataReader reader)
        {
            Collection<Automobil> automobily = new Collection<Automobil>();

            while (reader.Read())
            {
                //idTrasy, idObj , adresa, firma, typ"
                Automobil automobil = new Automobil();
                int i = -1;
                automobil.Ida = reader.GetInt32(++i);
                automobil.Znacka = reader.GetString(++i);
                automobil.Model = reader.GetString(++i);
                automobil.Rok_vyroby = reader.GetInt32(++i);
                automobil.Informace_o_poskozeni = reader.GetString(++i);
                automobil.Hladina_paliva = reader.GetString(++i);
                automobil.Zpusobily_jizdy = reader.GetInt32(++i);
                automobil.Cena_za_den = reader.GetInt32(++i);
                automobily.Add(automobil);
            }
            return automobily;
        }


        public static void ExportToXML(string fileName,int Id)
        {
            using (StringWriter stringWriter = new StringWriter(new StringBuilder()))
            {

                //Select()
                Collection<Automobil> automobily = SelectByID(Id);
                foreach (var automobil in automobily)
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Automobil));
                    xmlSerializer.Serialize(stringWriter, automobil);
                }
                File.WriteAllText(fileName + ".xml", stringWriter.ToString());
            }
        }


        public static void ExportModel()
        {

        }

    }
}
