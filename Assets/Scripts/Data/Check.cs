using UnityEngine;
using System.Collections;
using System;

public class Check : MonoBehaviour
{
    public static string LName;
    public static string GName;
    private string Hold;

    public void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("Fire?");
        if (coll.gameObject.tag == "Check")
        {
            //Debug.Log("Problem is in layer");
            if (coll.gameObject.layer == 9)
            {
                GName = "Land";
                Hold = "groundLand(Clone)";
                //Debug.Log("He Got inside LayerCheck");
            }
            if (coll.gameObject.layer == 4)
            {
                GName = "Water";
                Hold = "groundWater(Clone)";
            }
            if (coll.gameObject.layer == 8)
            {
                GName = "Air";
                Hold = "groundAir(Clone)";
            }
            if (GName == "Land" || GName == "Water" || GName == "Air")
            {
                LName = Hold;
                //Debug.Log("He sends message to Hold");
                GameObject.Find(Hold).BroadcastMessage("ListenForMessage", SendMessageOptions.DontRequireReceiver);
                Debug.Log(Hold);
            }
        }
    }
}
