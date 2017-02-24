using UnityEngine;
using System.Collections;

public class CameraAutoMove : MonoBehaviour
{
    private GameObject camM; //Hold main camera.

    // Use this for initialization
    void Start () {
	    camM = this.gameObject;
	} //Set Main Camera.
	
	// Update is called once per frame
	void Update () {
        MoveCamera();
    }

    private void MoveCamera()
    {
        camM.gameObject.transform.Translate(Vector2.right * Time.deltaTime *6);
    } //Move camera forward at decent speed.
}
