using UnityEngine;
using System.Collections;

public class Sizer : MonoBehaviour
{

    private SpriteRenderer sr; //Hold Sprite renderer.
    public static bool EnablerCheck = false; //Hold public enabler to set to false or true for CameraZoomin.
    private bool Enabler = true; //Hold enabler check for object.

    // Use this for initialization
    void Start () {
        sr = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        ScaleEnabled(); //Constantly enable the scaling.
    }

    void ScaleEnabled()
    {
        if (Enabler)
        {
            Scaling();
        } //Check if enabler is true and ZoominCamera has not made it false.
    }

    void Scaling()
    {
        float worldScreenHeight = Camera.main.orthographicSize * 2;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector3(worldScreenWidth / sr.sprite.bounds.size.x, worldScreenHeight / sr.sprite.bounds.size.y, 1);
    } //Scale the objects to the right size for the camera of the phone.

    void MessageBlocker()
    {
        Enabler = false; //Set enabler false for CameraZoomin.
    }

    void MessageEnabler()
    {
        Enabler = true; //Set enabler true because zooming stopped.
    }
}
