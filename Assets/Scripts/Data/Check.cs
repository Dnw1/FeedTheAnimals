using UnityEngine;
using System.Collections;

public class Check : MonoBehaviour
{
    public static string LName;
    public static string GName;
    private string Hold;

    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Check")
        {
            //Debug.Log(coll.gameObject.layer)
            if (coll.gameObject.layer == 9)
            {
                //Debug.Log("coll layer");
                GName = "Land";
                Hold = "Grass_Layer4LandSpawn(Clone)";
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
                //Debug.Log("He got in the type check");
                LName = Hold;
                //Debug.Log(Hold);
                GameObject.Find(Hold).BroadcastMessage("ListenForMessage", SendMessageOptions.DontRequireReceiver);
            }
        }
    }
}
