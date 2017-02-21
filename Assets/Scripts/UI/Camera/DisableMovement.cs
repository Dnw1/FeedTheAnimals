using UnityEngine;
using System.Collections;

public class DisableMovement : MonoBehaviour
{

    private CameraAutoMove ScriptSet;
    private string CamName = "Main Camera";

    public void StopCamera()
    {
        Debug.Log("ASpawn Found it");
        ScriptSet = GetComponent<CameraAutoMove>();
        ScriptSet.enabled = false;
        GameObject.Find(CamName).BroadcastMessage("ZoomCamera", SendMessageOptions.DontRequireReceiver);
    }
}
