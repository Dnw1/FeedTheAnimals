using UnityEngine;
using System.Collections;
using System.Linq;

public class Identifier : MonoBehaviour
{

    public static string AnimalName; //Hold name of animal for other scripts.

    void Start()
    {
        CheckAnimalType();
    }

    void CheckAnimalType()
    {
        AnimalName = gameObject.name; //Find animal name of spawned object.
        GameObject.Find(AnimalName).BroadcastMessage("RightFood", SendMessageOptions.DontRequireReceiver); //Start looking for the right food for the spawned animal.
    }
}
