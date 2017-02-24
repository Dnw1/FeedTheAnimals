using UnityEngine;
using System.Collections;

public class TerrainRemover : MonoBehaviour
{
    private GameObject platformDestructionPoint; //Hold destruction point for objects.

    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint"); //Find the point.

    }

    void Update()
    {
        if (transform.position.x < platformDestructionPoint.transform.position.x) //If their past the point's x position do this.
        {
            Destroy(this.gameObject); //Destroy the gameobject that went past the point.
        }
    }
}
