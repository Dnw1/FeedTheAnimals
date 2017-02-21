using UnityEngine;
using System.Collections;

public class CameraZoomin : MonoBehaviour
{
    private Camera CamZ;
    private float CamSize;
    private GameObject Target;

    void Start()
    {
        CamZ = GameObject.Find("Main Camera").GetComponent<Camera>();
        CamSize = Camera.main.orthographicSize;
    }

    public void ZoomCamera()
    {
        StartCoroutine(ZoomIn());
        //GameObject.Find().BroadcastMessage("StopCamera", SendMessageOptions.DontRequireReceiver);
    }

    public void PickTarget()
    {
           //GameObject.Find(Check.LName).BroadcastMessage("", SendMessageOptions.DontRequireReceiver); ;
    }

    IEnumerator ZoomIn()
    {
        if (CamZ.orthographicSize > 4f)
        {
            GameObject.Find("TemplateForSpawning").BroadcastMessage("MessageBlocker", SendMessageOptions.DontRequireReceiver);
            Debug.Log("It fired Blocker");
        }
        while (CamZ.orthographicSize > 4f)
        {
            CamZ.orthographicSize -= 0.01f;
            yield return new WaitForSeconds(0.0001f);
        }
        if (CamZ.orthographicSize < 4f)
        {
            GameObject.Find("TemplateForSpawning").BroadcastMessage("MessageEnabler", SendMessageOptions.DontRequireReceiver);
            Debug.Log("It fired Enabler");
        }
    }
}
