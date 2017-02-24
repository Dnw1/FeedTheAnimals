using UnityEngine;
using System.Collections;

public class Picker : MonoBehaviour
{
    public static string FoodForAnimal; //Hold string of correct food for the animal spawned.
    

    void RightFood()
    {
        if (Identifier.AnimalName == "Bear(Clone)")
        {
            FoodForAnimal = "Meat";
            //Debug.Log(FoodForAnimal);
        }
        if (Identifier.AnimalName == "Rabbit(Clone)")
        {
            FoodForAnimal = "Grass";
            //Debug.Log(FoodForAnimal);
        }
        if (Identifier.AnimalName == "Wolf(Clone)")
        {
            FoodForAnimal = "Meat";
        }
        if (Identifier.AnimalName == "Fox(Clone)")
        {
            FoodForAnimal = "Meat";
        }
        if (Identifier.AnimalName == "Squirrel(Clone)")
        {
            FoodForAnimal = "Nuts";
        }
        if (Identifier.AnimalName == "Pidgeon(Clone)")
        {
            FoodForAnimal = "Seeds";
        }
        if (Identifier.AnimalName == "Crow(Clone)")
        {
            FoodForAnimal = "Seeds";
        }
        if (Identifier.AnimalName == "Mole(Clone)")
        {
            FoodForAnimal = "Worms";
        }
        if (Identifier.AnimalName == "Deer(Clone)")
        {
            FoodForAnimal = "Grass";
        }
        if (Identifier.AnimalName == "Tortoise(Clone)")
        {
            FoodForAnimal = "Plants";
        }
        if (Identifier.AnimalName == "Hedgehog(Clone)")
        {
            FoodForAnimal = "Insects";
        }
        if (Identifier.AnimalName == "Eagle(Clone)")
        {
            FoodForAnimal = "Fish";
        }
        GameObject.Find("FoodHolder").BroadcastMessage("FoodSpawn", SendMessageOptions.DontRequireReceiver); //Send message to start Foodspawner.
    } //Easy fix to find the right type of food for the type of gameobject(animal) spawned.
}
