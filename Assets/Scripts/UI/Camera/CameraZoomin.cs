using UnityEngine;
using System.Collections;

public class CameraZoomin : MonoBehaviour
{
    private Camera CamZ; //Hold Main Camera.
    private float CamSize; //Hold orthographicSize.
    private GameObject Target; //Hold Target to zoom in to.

    void Start()
    {
        CamZ = GameObject.Find("Main Camera").GetComponent<Camera>();
        CamSize = Camera.main.orthographicSize;
        //Set Main Camera and it's orthographic to camera and float.
    }

    public void ZoomCamera()
    {
        StartCoroutine(ZoomIn());
        //GameObject.Find().BroadcastMessage("StopCamera", SendMessageOptions.DontRequireReceiver);
    }

    public void PickTarget()
    {
        //GameObject.Find(Check.LName).BroadcastMessage("", SendMessageOptions.DontRequireReceiver);
        Target = GameObject.Find("AnimalSpawner"); //Find the Spawner to zoom in to.
        CamZ.transform.position = new Vector3(Target.transform.position.x, transform.position.y -2f, transform.position.z); //Set the position of camera on the right spot.
    }

    IEnumerator ZoomIn()
    {
        if (CamZ.orthographicSize > 4f)
        {
            GameObject.Find("TemplateForSpawning").BroadcastMessage("MessageBlocker", SendMessageOptions.DontRequireReceiver);
        } //Stops objects from moving up and away when zooming in.
        while (CamZ.orthographicSize > 4f)
        {
            CamZ.orthographicSize -= 0.01f;
            yield return new WaitForSeconds(0.0001f);
        } //Zoom in steadily and at decent speed.
        if (CamZ.orthographicSize < 4f)
        {
            GameObject.Find("TemplateForSpawning").BroadcastMessage("MessageEnabler", SendMessageOptions.DontRequireReceiver);
        } //Enable the point of the sizer script again.
    }
}
