using System;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField] private Sprite[] Foods; //Store food prefabs for location.

    private Sprite Food1;
    private Sprite Food2;
    private Sprite Food3;

    public static Sprite _food1;
    public static Sprite _food2;
    public static Sprite _food3;
    //Hold individual Food choices.

    [SerializeField] private Button[] Buttons; //Store buttons in the game to shuffle and assign.

    public static Button Button1;
    public static Button Button2;
    public static Button Button3;

    private String FoodOne; //Assign right food from picker script.

    private Vector2 SpawnSpot; //Hold spawn location.

    public void FoodSpawn()
    {
        if (gameObject.tag.Contains("Food")) //Check to make sure script is on right object.
        {
            BShuffle(); //Shuffle the buttons around.
            FoodOne = Picker.FoodForAnimal; //Get right food.
            for (int i = 0; i < Foods.Length; i++)
            {
                if (Foods[i].name == FoodOne)
                {
                    Food1 = Foods[i];
                    //Debug.Log(Food1);
                } //Go through Foods array to look for right food.
            }

            Food2 = Foods[0];
            if (Food2 == Food1)
            {
                Food2 = Foods[1];
            }

            FShuffle();
            Food3 = Foods[0];

            if (Food3 == Food1 || Food3 == Food2)
            {
                Food3 = Foods[1];
                if (Food3 == Food1 || Food3 == Food2)
                {
                    Food3 = Foods[2];
                }
            } //Get shuffled foods for the other 2 and make sure their not the same.

            Buttons[0].image.overrideSprite = Food1;
            Buttons[1].image.overrideSprite = Food2;
            Buttons[2].image.overrideSprite = Food3;
            //Assign the food sprites picked to buttons.
            SetPublicInfo();

            BShuffle(); //Shuffle the buttons again.

            if (Food1 != null)
            {
                GameObject.Find("TestClicked").BroadcastMessage("SetParamiters", SendMessageOptions.DontRequireReceiver);
            }
        }
     }
    private void BShuffle()
    {
        // Knuth shuffle algorithm
        for (int t = 0; t < Buttons.Length; t++)
        {
            Button tmp = Buttons[t];
            int r = UnityEngine.Random.Range(t, Buttons.Length);
            Buttons[t] = Buttons[r];
            Buttons[r] = tmp;
        }
    } //Button shuffler.

    private void FShuffle()
    {
        for (int s = 0; s < Foods.Length; s++)
        {
            Sprite rmp = Foods[s];
            int e = UnityEngine.Random.Range(s, Foods.Length);
            Foods[s] = Foods[e];
            Foods[e] = rmp;
        }
    } //Food shuffler

    private void SetPublicInfo()
    {
        _food1 = Food1;
        _food2 = Food2;
        _food3 = Food3;

        Button1 = Buttons[0];
        Button2 = Buttons[1];
        Button3 = Buttons[2];
    }
}
