using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class CheckTypeFood : MonoBehaviour
{
    public static int RightFood;
    private int TypeFound;

    private string NameAnimal;

    public void FindFood()
    {
        NameAnimal = CheckAnimal.NameOfAnimal;

        if (NameAnimal == "Lion")
        {
            TypeFound = 0;
            TypeFound = RightFood;
        }
        if (NameAnimal == "Deer")
        {
            TypeFound = 1;
            TypeFound = RightFood;
        }
    }

}
