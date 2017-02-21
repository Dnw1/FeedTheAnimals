using UnityEngine;
using System.Collections;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Foods; //Store food prefabs for location.
    private int _randFood;
    public static int TypeFood;
    private int PickedFood;
    private int Count = 3;
    
    private int Number1;
    private int Number2;
    private int Number3;

    // Use this for initialization
    void Start () {
	    FoodSpawn();
	}

    private void FoodSpawn()
    {
        if (gameObject.tag.Contains("Food"))
        {
            _randFood = Random.Range(1, Foods.Length); //Picks random food from Foods. Make first in list duplicate because checks.
            if (Number1 != _randFood || Number2 != _randFood || Number3 != _randFood)
            {
                Vector3 spawnPosition = gameObject.transform.position; //The location of where the food will spawn.

                GameObject PickedFood = Instantiate(Foods[_randFood], spawnPosition, Quaternion.identity) as GameObject;
                //Spawning the food.
                PickedFood.transform.parent = GameObject.Find("Canvas").transform;
                if (Number1 == 0)
                {
                    Number1 = _randFood;
                }else if (Number2 == 0)
                {
                    Number2 = _randFood;
                }else if (Number3 == 0)
                {
                    Number3 = _randFood;
                }

                //Debug.Log(_randFood);
                int TypeFood = _randFood;
                //PickedFood = Foods[_randFood];
            }
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
