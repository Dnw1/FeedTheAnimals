using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clicked : MonoBehaviour
{

    private Sprite RightFoodPicked;
    private Sprite SecondFood;
    private Sprite ThirdFood;

    private Button ButtonOne;
    private Button ButtonTwo;
    private Button ButtonThree;

    public void RightClicked()
    {
        if (ButtonOne)
        {
            //Add points to CurrentScore
            //Animation
            //Moving on
        }
    }

    public void WrongClicked()
    {
        if (SecondFood || ThirdFood)
        {
            //Animation
            //Moving on
        }
    }

    public void SetParamiters()
    {
        RightFoodPicked = FoodSpawner._food1;
        SecondFood = FoodSpawner._food2;
        ThirdFood = FoodSpawner._food3;

        ButtonOne = FoodSpawner.Button1;
        ButtonTwo = FoodSpawner.Button2;
        ButtonThree = FoodSpawner.Button3;
    }

    IEnumerator WaitAFewSeconds()
    {
        //
        yield return new WaitForSeconds(2);
    }
}
