using UnityEngine;
using System.Collections;

public class Sizer : MonoBehaviour
{

    private SpriteRenderer sr;
    public static bool EnablerCheck = false;
    private bool Enabler = true;

	// Use this for initialization
	void Start () {
        sr = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        ScaleEnabled();
    }

    void ScaleEnabled()
    {
        if (Enabler)
        {
            Scaling();
        }
    }

    void Scaling()
    {
        float worldScreenHeight = Camera.main.orthographicSize * 2;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector3(worldScreenWidth / sr.sprite.bounds.size.x, worldScreenHeight / sr.sprite.bounds.size.y, 1);
    }

    void MessageBlocker()
    {
        Enabler = false;
    }

    void MessageEnabler()
    {
        Enabler = true;
    }
}
