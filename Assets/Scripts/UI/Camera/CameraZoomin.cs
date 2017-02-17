using UnityEngine;
using System.Collections;
using System.Runtime.CompilerServices;

public class CameraZoomin : MonoBehaviour
{

    private Camera CamZ;

    void Start()
    {
        CamZ = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    public void ZoomCamera()
    {
        StartCoroutine(ZoomIn());
    }

    IEnumerator ZoomIn()
    {
        //Debug.Log("He found the Zoom");
        while (CamZ.orthographicSize > 4)
        {
            CamZ.orthographicSize -= 0.01f;
            yield return new WaitForSeconds(0.0001f);
        }
    }
}
