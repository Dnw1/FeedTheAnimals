using UnityEngine;
using System.Collections;

public class CameraAutoMove : MonoBehaviour
{

    private GameObject camM;

    // Use this for initialization
    void Start () {
	    camM = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        MoveCamera();
    }

    private void MoveCamera()
    {
        camM.gameObject.transform.Translate(Vector2.right * Time.deltaTime *6);
    }
}
