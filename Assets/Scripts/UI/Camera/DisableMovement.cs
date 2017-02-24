using UnityEngine;
using System.Collections;

public class DisableMovement : MonoBehaviour
{

    private CameraAutoMove ScriptSet; //Hold Script that auto moves camera.
    private string CamName = "Main Camera"; //Hold string of Main Camera.

    public void StopCamera()
    {
        ScriptSet = GetComponent<CameraAutoMove>(); //Get the component for the script.
        ScriptSet.enabled = false; //Set script enabled to false to stop it.
        GameObject.Find(CamName).BroadcastMessage("ZoomCamera", SendMessageOptions.DontRequireReceiver); //Send message for camera to start zooming in.
    }
}
