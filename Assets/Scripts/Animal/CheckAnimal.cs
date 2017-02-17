using UnityEngine;
using System.Collections;

public class CheckAnimal : MonoBehaviour {

    public static int ThisAnimal;
    private int TheAnimal;

    public static string NameOfAnimal;
    private string AnimalTile;
    private string AnimalName;

    public void FindAnimal()
    {
        AnimalTile = Check.GName;
        TheAnimal = AnimalSpawn.TypeAnimal;

        if (AnimalTile == "Land")
        {
            switch (TheAnimal)
            {
                case 0:
                    AnimalName = "Lion";
                    AnimalName = NameOfAnimal;
                    break;
                case 1:
                    AnimalName = "Deer";
                    AnimalName = NameOfAnimal;
                    break;
                case 3:
                    AnimalName = "Giraffe";
                    AnimalName = NameOfAnimal;
                    break;
            }
        }
        if (AnimalTile == "Air")
        {
            switch (TheAnimal)
            {
                case 0:
                    AnimalName = "Bird";
                    AnimalName = NameOfAnimal;
                    break;
                case 1:
                    AnimalName = "Bird";
                    AnimalName = NameOfAnimal;
                    break;
                case 3:
                    AnimalName = "Bird";
                    AnimalName = NameOfAnimal;
                    break;
            }
        }
        if (AnimalTile == "Water")
        {
            switch (TheAnimal)
            {
                case 0:
                    AnimalName = "Crocodile";
                    AnimalName = NameOfAnimal;
                    break;
                case 1:
                    AnimalName = "Crocodile";
                    AnimalName = NameOfAnimal;
                    break;
                case 3:
                    AnimalName = "Crocodile";
                    AnimalName = NameOfAnimal;
                    break;
            }
        }

    }
}
