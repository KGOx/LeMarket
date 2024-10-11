/*Le marché
Créez un jeu de gestion de panier de fruits au marché à l'aide d'un tableau de chaînes de caractères.
L'utilisateur peut ajouter maximum 5 fruits, les retirer, les afficher et les rechercher.
Gérez les doublons lors de l'ajout.
Permettez à l'utilisateur de quitter le jeu via le menu.*/

string[] tableau_fruits = new string[5];
int nbr_fruits = 0;

while (true)
{
    Console.WriteLine("Que désirez vous faire ? \n" +
                        "[1] : Ajouter un fruit. \n" + 
                        "[2] : Supprimer un fruit. \n" +
                        "[3] : Afficher le panier. \n" +
                        "[4] : Rechercher un fruit. \n" + 
                        "[5] : Quitter le programme. \n");
    int choix = Convert.ToInt32(Console.ReadLine());

    switch (choix)
    {
        case 1: // add
            Console.Write("Entrez le fruit à ajouter : ");
            string fruit = Console.ReadLine();

            if (nbr_fruits < tableau_fruits.Length)
            {
                tableau_fruits[nbr_fruits] = fruit;
                nbr_fruits ++;
            }
            else 
            {
                Console.WriteLine("Le tableau est plein. Voulez-vous remplacer un fruit existant ? (oui/non)");
                string reponse = Console.ReadLine();
                
                if (reponse.ToLower() == "oui")
                {
                    Console.WriteLine("Quel fruit avec son numéro d'index voulez-vous changez ? (0-4)");
                    int index = Convert.ToInt16(Console.ReadLine());

                    if (index >= 0  && index < tableau_fruits.Length)
                    {
                        tableau_fruits[index] = fruit;
                    }
                    else
                    {
                        Console.WriteLine("Le numéro n'est pas valide");
                    }
                }
                else
                {
                    Console.WriteLine("Aucun fruit ajouté.");
                }
            }
            Console.WriteLine("Fruits actuels : " + string.Join(",", tableau_fruits)+ "\n");
            break;
        case 2: // remove
            break;
        case 3: // display
            for (int i= 0; i <= 4; i++)
            {
                Console.WriteLine(tableau_fruits[i]);
            }
            break;
        case 4: // search
            Console.WriteLine("\nQuel fruit désirez vous recherchez ?");
            string inconnu = Console.ReadLine().ToLower();
            bool fruitFound = false;

            foreach (string j in tableau_fruits)
                {
                if (j != null && inconnu == j.ToLower())
                {
                    fruitFound = true;
                    break;
                }
                }
            if (fruitFound)
            {
                Console.WriteLine($"\n{inconnu} se trouve dans le tableau.");
            }
            else
            {
                Console.WriteLine($"\n{inconnu} ne se trouve pas dans le tableau.");
            }
            break;
        case 5: // quit
            Console.WriteLine("Au revoir !");
            return;
        default:
            Console.WriteLine("Nombre invalide, veuillez entrer un nombre valide.");
            break;
    }
}