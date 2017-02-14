using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Example : MonoBehaviour
{


    void Start()
    {
        string[] paths = {"Path1","Path2","Path3","Path4"}; //List of paths.
        iTween.MoveTo(gameObject, iTween.Hash("path", iTweenPath.GetPath(paths[Random.Range(0, paths.Length)]), "time", 10)); //Move camera from start to end.
    }//Single per play for test.

}
