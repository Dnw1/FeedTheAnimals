using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class PlatformGenerator : MonoBehaviour {

    [SerializeField] private GameObject thePlatform;
    [SerializeField] private Transform generationPoint;
    [SerializeField] private float distanceBetween;

    private float platformWidth;
    private Vector3 ThisVector;

    // Use this for initialization
    void Start()
    {
        platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x;

    }

    // Update is called once per frame
    void Update()
    {
        CreateTiles();
    }

    void CreateTiles()
    {
        if (ThisVector.x < generationPoint.position.x)
        {
            ThisVector.y = ThisVector.y + 4f;
            ThisVector.z = ThisVector.z + 1f;
            ThisVector = new Vector3(ThisVector.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(thePlatform, ThisVector, transform.rotation);
        }
    }
}
