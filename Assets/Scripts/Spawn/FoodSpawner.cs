using UnityEngine;
using System.Collections;

public class FoodSpawner : MonoBehaviour {

    [SerializeField]
    private GameObject[] Foods; //Store food prefabs for location.
    private int _randFood;
    public static int TypeFood;
    private int PickedFood;
    private int Count = 3;

    // Use this for initialization
    void Start () {
	    FoodSpawn();
	}

    private void FoodSpawn()
    {
        if (gameObject.tag.Contains("Food"))
        {
            for (int i = 0; i < Count; i++)
            {
                _randFood = Random.Range(0, Foods.Length); //Picks random food from Foods.

                Vector3 spawnPosition = gameObject.transform.position; //The location of where the food will spawn.

                GameObject PickedFood = Instantiate(Foods[_randFood], spawnPosition, Quaternion.identity) as GameObject;
                //Spawning the food.
                PickedFood.transform.parent = GameObject.Find("Canvas").transform;

                //Debug.Log(_randFood);
                int TypeFood = _randFood;
                //PickedFood = Foods[_randFood];
            }
        }
    }
    /*
    public void ShuffleArray<T>(T[] Foods)
    {
        for (int i = Foods.Length - 1; i > 0; i--)
        {
            _randFood = Random.Range(0, i);
            T tmp = Foods[i];
            Foods[i] = Foods[_randFood];
            Foods[_randFood] = tmp;
        }
    }*/
}
