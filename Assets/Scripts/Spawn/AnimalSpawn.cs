using UnityEngine;
using System.Collections;
using System.Net.NetworkInformation;
using JetBrains.Annotations;

public class AnimalSpawn : MonoBehaviour
{

    [SerializeField] private GameObject[] LandAnimals;
    [SerializeField] private GameObject[] WaterAnimals;
    [SerializeField] private GameObject[] AirAnimals;

    private GameObject[] SpawnedArray;
    //Store animal prefabs for location.
    private Vector3 AValues;
    private int _randAnimal;
    public static int TypeAnimal;
    private string CamHolder = "Main Camera";

    /*
    private int FirstTaken;
    private int SecondTaken;
    private int ThirdTaken;
    */

    public void ListenForMessage()
    {
        AnimalSpawning();
    }

    void AnimalSpawning()
    {
        if (gameObject.tag.Contains("Animal"))
        {
            CheckType();
                _randAnimal = Random.Range(0, SpawnedArray.Length); //Picks random animal from Animals.

                Vector3 spawnPosition = new Vector3(Random.Range(-AValues.x, -AValues.y), 1,
                    Random.Range(AValues.x, AValues.y)); //The location of where the animal will spawn.

                Instantiate(SpawnedArray[_randAnimal], spawnPosition + transform.TransformPoint(0, 0, 0),
                    gameObject.transform.rotation); //Spawning the animal.
                TypeAnimal = _randAnimal;
                //Debug.Log(TypeAnimal);
                GameObject.Find(CamHolder).BroadcastMessage("StopCamera", SendMessageOptions.DontRequireReceiver);
        }
     }

    private void CheckType()
    {
        if (Check.GName == "Land")
        {
            SpawnedArray = LandAnimals;
        }
        if (Check.GName == "Water")
        {
            SpawnedArray = WaterAnimals;
        }
        if (Check.GName == "Air")
        {
            SpawnedArray = AirAnimals;
        }
    }
}