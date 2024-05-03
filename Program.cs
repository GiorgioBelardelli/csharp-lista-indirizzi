namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\aster\\Desktop\\Esercizi .NET\\csharp-lista-indirizzi\\ListaIndirizzi.txt";

            var indirizzi = LeggiDaTesto(path);
            foreach (var indirizzo in indirizzi)
                Console.WriteLine(indirizzo.ToString());
        }
        public static List<Indirizzo> LeggiDaTesto(string path)
        {
            
            List<Indirizzo> ListaIndirizzi = new List<Indirizzo>();
            var stream = File.OpenText(path);
            int i = 0;

            while (stream.EndOfStream == false)
            {
                var linea = stream.ReadLine();
                i++;
                if (i < 2)
                {
                    continue;
                }
                try
                {
                    var dati = linea.Split(',');
                    string Nome = dati[0];
                    string Cognome = dati[1];
                    string Via = dati[2];
                    string Citta = dati[3];
                    string Provincia = dati[4];
                    int CAP = int.Parse(dati[5]);

                    Indirizzo dato = new Indirizzo(Nome, Cognome, Via, Citta, Provincia, CAP);
                    ListaIndirizzi.Add(dato);
                }
                catch (Exception e)
                {
                    string errorMessage = $"Errore di dati nella riga {i}: I dati letti dal file non sono validi o mancanti.";
                    Console.WriteLine(errorMessage);
                }
            }
            stream.Dispose();
            return ListaIndirizzi;
        }
    }
}
