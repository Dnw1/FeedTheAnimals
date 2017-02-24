using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject Parent; //Hold parent object for tiles.
    [SerializeField] private Transform generationPoint; //Hold GenerationPoint.
    [SerializeField] private float distanceBetween; //Hold the distance between the point and previous one.
    [SerializeField] private GameObject[] Objects; //Hold the array for spawn objects.

    private float platformWidth; //Hold width of object.
    private Vector3 ThisVector; //Vector for spawnPosition.

    // Use this for initialization
    void Start()
    {
        StartCoroutine(GoShuffle());
    }

    // Update is called once per frame
    void Update()
    {
        CreateTiles();
    }

    void CreateTiles()
    {
        if (ThisVector.x < generationPoint.position.x) //Check if generationpoint position x is less than vector x.
        {
            foreach (GameObject Objs in Objects) //For each objects in array.
                {
                    ThisVector.y = ThisVector.y + 4f;
                    ThisVector.z = ThisVector.z + 1f;
                    ThisVector = new Vector3(ThisVector.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
                    (Instantiate(Objs, ThisVector, transform.rotation) as GameObject).transform.parent = Parent.transform;
                } //Instantiate object when it is past generationpoint's x pos.
        }
    }

    private void reshuffle()
    {
        // Knuth shuffle algorithm
        for (int t = 0; t < Objects.Length; t++)
        {
            GameObject tmp = Objects[t];
            int r = Random.Range(t, Objects.Length);
            Objects[t] = Objects[r];
            Objects[r] = tmp;
        }
    } //Shuffle Objects in array to make it appear random.

    IEnumerator GoShuffle()
    {
        yield return new WaitForSeconds(10);
        reshuffle();
        StartCoroutine(GoShuffle());
    } //Shuffle every 10 seconds.
}
