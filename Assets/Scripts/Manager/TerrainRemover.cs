using UnityEngine;
using System.Collections;

public class TerrainRemover : MonoBehaviour
{
    private GameObject platformDestructionPoint;

    void Start()
    {
        platformDestructionPoint = GameObject.Find("PlatformDestructionPoint"); ;

    }

    void Update()
    {
        if (transform.position.x < platformDestructionPoint.transform.position.x)
        {
            Destroy(this.gameObject);
        }
    }
}
