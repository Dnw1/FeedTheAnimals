using UnityEngine;
using System.Collections;

public class Shuffler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void reshuffle(GameObject[] Objects)
    {
        // Knuth shuffle algorithm :: courtesy of Wikipedia :)
        for (int t = 0; t < Objects.Length; t++)
        {
            GameObject tmp = Objects[t];
            int r = Random.Range(t, Objects.Length);
            Objects[t] = Objects[r];
            Objects[r] = tmp;
        }
    }
}
