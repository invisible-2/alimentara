namespace Alimentara
{
    class Departament
    {
        public int ID_Departament { get; set; }
        public string Nume { get; set; }

        public string GetDepartament
        {
            get { return $" {ID_Departament} {Nume}"; }
        }

    }
}
