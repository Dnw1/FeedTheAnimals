using UnityEngine;
using System.Collections;

public class AnimalSpawn : MonoBehaviour
{

    [SerializeField] private GameObject[] LandAnimals;
    [SerializeField] private GameObject[] WaterAnimals;
    [SerializeField] private GameObject[] AirAnimals;
    //Store the animals in their types.

    private GameObject[] SpawnedArray;
    //Store animal prefabs for location.
    private Vector3 AValues; //Values for spawn location.
    private int _randAnimal; //Holds integer for picked random animal.
    public static int TypeAnimal; //Share integer for other scripts.
    private string CamHolder = "Main Camera"; //Hold main camera integer to send messages.

    public void ListenForMessage()
    {
        AnimalSpawning(); //Spawn animal when trigger sends message.
    }

    void AnimalSpawning()
    {
        if (gameObject.tag.Contains("Animal")) //Check to make sure object has animal tag.
        {
            CheckType(); //Pick which SpawnedArray depending on Check.
            _randAnimal = Random.Range(0, SpawnedArray.Length); //Picks random animal from Animals.

            Vector3 spawnPosition = new Vector3(Random.Range(-AValues.x, -AValues.y), 1, Random.Range(AValues.x, AValues.y)); //The location of where the animal will spawn.

            Instantiate(SpawnedArray[_randAnimal], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation); //Spawning the animal.
            TypeAnimal = _randAnimal;

            GameObject.Find(CamHolder).BroadcastMessage("StopCamera", SendMessageOptions.DontRequireReceiver);
            GameObject.Find(CamHolder).BroadcastMessage("PickTarget", SendMessageOptions.DontRequireReceiver);
            GameObject.Find("Picker").BroadcastMessage("RightFood", SendMessageOptions.DontRequireReceiver);
            //Send messages after animal has spawned.
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
    } //Check what type of animal spawner holds and set SpawnedArray to the right one.
}