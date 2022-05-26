namespace Alimentara
{
    public class Produs
    {
        public int ID_Produs { get; set; }
        public string Cod { get; set; }
        public string Denumire { get; set; }
        public float Cantitate { get; set; }
        public string Tip_Cantitate { get; set; }
        public float Pret { get; set; }
        public string Data_Valabilitate { get; set; }
        public int ID_Departament { get; set; }
        public int ID_Producator { get; set; }
        public int ID_Magazin { get; set; }

        public string GetProdus
        {
            get { return $"{Cod} {Denumire} - {Cantitate} {Tip_Cantitate} | {Pret} lei, Termen: {Data_Valabilitate} "; }
        }
    }
}
