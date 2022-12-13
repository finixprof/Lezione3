using GenericAndInterface;

namespace Lezione3.GenericAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            var generico = new Generico<int>();
            generico.Procedure(10);
            var x = generico.Method();

            var generico2 = new Generico<string>();
            generico2.Procedure("ciao");
            var y = generico2.Method();


            var dictionary = new Dictionary<string, int>();
            dictionary.Add("Valerio", 7);
            dictionary.Add("Luca", 4);
            dictionary.Add("Cristian", 2);
            //foreach (KeyValuePair<string,int> item in dictionary)
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{ item.Key} voto {item.Value}");    
            }

            foreach (var item in dictionary.Keys) //elenco delle chiavi
            {
                Console.WriteLine($"Chiave {item} valore {dictionary[item]}");
            }

            foreach(var item in dictionary.Values) //elenco dei valori
            {
                Console.WriteLine($"Valore {item} ");
            }

            var searchItem = "Salvo";
            if (dictionary.ContainsKey(searchItem))
                Console.WriteLine($"Chiave {searchItem} valore {dictionary[searchItem]}");
            else
                Console.WriteLine($"Non trovo {searchItem}");

        }
    }
}