using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{

    [SerializeField] private GameObject[] Animals; //Store animal prefabs for location.
    [SerializeField] private Vector3 Values;
    private int _randAnimal;

    public void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        _randAnimal = Random.Range(0, Animals.Length); //Picks random animal from _animals list.

        Vector3 spawnPosition = new Vector3(Random.Range (-Values.x, -Values.y), 1, Random.Range(Values.x, Values.y)); //The location of where they will spawn.

        Instantiate(Animals[_randAnimal], spawnPosition + transform.TransformPoint(0,0,0), gameObject.transform.rotation); //Spawning the animal.
    }
}
