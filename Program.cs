namespace Braquage_train;

class Program
{
    static void Main(string[] args)
    {
        /*
         * Consignes :
           - Utiliser une première boucle pour parcourir les quatre wagons.
           - Utiliser une deuxième boucle à l'intérieur pour parcourir les trois coffres de chaque wagon.
           - Afficher chaque coffre inspecté avec son numéro de wagon.
           - Compter le nombre total de coffres inspectés.
           
           Exemple :
               Inspection des 4 wagons du train
               Wagon 1 - Coffre 1 inspecté
               Wagon 1 - Coffre 2 inspecté
               Wagon 1 - Coffre 3 inspecté
               Wagon 2 - Coffre 1 inspecté
               ...
               Total : 12 coffres inspectés.
            
            BONUS 1 : permettre à l'utilisateur de choisir le nombre de wagons
            BONUS 2 : enregistrer l'ensemble du butin trouvé et l'afficher à la fin
         */
        int cartNumber = 1;
        int totalCarts = 4;

        Console.WriteLine("Combien de wagons avez-vous ?");
        totalCarts = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nInspection des " + totalCarts + " Wagons du train \n");

        do
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Wagon " + cartNumber + " - Coffre " + i + " inspecté");
            }
            cartNumber += 1;
            Console.WriteLine("");

        } while (cartNumber <= totalCarts);
    }
}