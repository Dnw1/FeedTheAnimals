using UnityEngine;
using System.Collections;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] private GameObject Parent;
    [SerializeField] private Transform generationPoint;
    [SerializeField] private float distanceBetween;
    [SerializeField] private GameObject[] Objects;

    private float platformWidth;
    private Vector3 ThisVector;

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
        if (ThisVector.x < generationPoint.position.x)
        {
            foreach (GameObject Objs in Objects)
                {
                    ThisVector.y = ThisVector.y + 4f;
                    ThisVector.z = ThisVector.z + 1f;
                    ThisVector = new Vector3(ThisVector.x + platformWidth + distanceBetween, transform.position.y, transform.position.z);
                    (Instantiate(Objs, ThisVector, transform.rotation) as GameObject).transform.parent = Parent.transform;
                }
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
    }

    IEnumerator GoShuffle()
    {
        yield return new WaitForSeconds(10);
        reshuffle();
        StartCoroutine(GoShuffle());
    }
}
