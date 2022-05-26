using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Alimentara
{
    class OperatiiBD
    {
        public void AdaugaProdus(string cod, string denumire, float cantitate, string tipCantitate, float pret, string dataValabilitate, int ID_Dept, int ID_Prod, int ID_Magaz)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {
                List<Produs> produse = new List<Produs>();

                produse.Add(new Produs
                {
                    Cod = cod,
                    Denumire = denumire,
                    Cantitate = cantitate,
                    Tip_Cantitate = tipCantitate,
                    Pret = pret,
                    Data_Valabilitate = dataValabilitate,
                    ID_Departament = ID_Dept,
                    ID_Producator = ID_Prod,
                    ID_Magazin = ID_Magaz

                });

                connection.Execute("AdaugaProdus @Cod, @Denumire, @Cantitate, @Tip_Cantitate, @Pret, @Data_Valabilitate, @ID_Departament, @ID_Producator, @ID_Magazin",
                    produse);

                connection.Close();
            }
        }

        public void ActualizeazaProdus(int id, string cod, string denumire, float cantitate, string tipCantitate, float pret, string dataValabilitate)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {
                List<Produs> produse = new List<Produs>();

                produse.Add(new Produs
                {
                    ID_Produs = id,
                    Cod = cod,
                    Denumire = denumire,
                    Cantitate = cantitate,
                    Tip_Cantitate = tipCantitate,
                    Pret = pret,
                    Data_Valabilitate = dataValabilitate

                });

                connection.Execute("ActualizeazaProdus @ID_Produs, @Cod, @Denumire, @Cantitate, @Tip_Cantitate, @Pret, @Data_Valabilitate",
                    produse);

                connection.Close();
            }
        }

        public void StergeProdus(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {
                Produs produs = new Produs { ID_Produs = id };

                connection.Execute("StergeProdus @ID_Produs", produs);

                connection.Close();
            }
        }

        public List<Produs> CautaProdusDupaCod(int cod)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {
                var output = connection.Query<Produs>("CautaProdusDupaCod @Cod", 
                    new { Cod = cod }).ToList();

                connection.Close();
                return output;
            } 
        }

        public List<Departament> CautaDepartamentDupaID(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<Departament>("CautaDepartamentDupaID @ID_Departament", 
                    new { ID_Departament = id }).ToList();
               

                connection.Close();
                return output;
            }
        }

        public List<Producator> CautaProducatorDupaID(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<Producator>("CautaProducatorDupaID @ID_Producator",
                    new { ID_Producator = id }).ToList();


                connection.Close();
                return output;
            }
        }

        public List<Magazin> CautaMagazinDupaID(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<Magazin>("CautaMagazinDupaID @ID_Magazin",
                    new { ID_Magazin = id }).ToList();


                connection.Close();
                return output;
            }
        }

        public List<Produs> GetProduse(string nume)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<Produs>("GetProduse @Nume",
                    new {Nume = nume}).ToList();


                connection.Close();
                return output;
            }
        }

        public List<Localitate> CautaLocalitateDupaID(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {
                var output = connection.Query<Localitate>("CautaLocalitateDupaID @ID_Localitate",
                    new { ID_Localitate = id}).ToList();

                connection.Close();
                return output;
            }
        }

        public void AdaugaMagazin(string nume, string adresa, string telefon, int ID_Localit)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {
                List<Magazin> magazin = new List<Magazin>();

                magazin.Add(new Magazin
                {
                    Nume = nume,
                    Adresa = adresa,
                    Telefon = telefon,
                    ID_Localitate = ID_Localit

                });

                connection.Execute("AdaugaMagazin @Nume, @Adresa, @Telefon, @ID_Localitate",
                    magazin);

                connection.Close();
            }
        }

        public List<Produs> CautaProduse(string denumire)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<Produs>("CautaProduse @Denumire",
                    new { Denumire = denumire }).ToList();


                connection.Close();
                return output;
            }
        }

        public List<Produs> GetProduseDinMagazin(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<Produs>("GetProduseDinMagazin @ID_Magazin",
                    new { ID_Magazin = id }).ToList();


                connection.Close();
                return output;
            }
        }

        public List<Produs> CautaProdusDupaID(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (Connection.ConString("AlimentaraBD")))
            {

                var output = connection.Query<Produs>("CautaProdusDupaID @ID_Produs",
                    new { ID_Produs = id }).ToList();


                connection.Close();
                return output;
            }
        }
 
    }
}
