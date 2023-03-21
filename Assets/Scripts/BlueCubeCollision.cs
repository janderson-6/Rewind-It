using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCubeCollision : MonoBehaviour
{
    public GameObject door1;
    public GameObject door2;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("BlueTrigger") == true)
        {
            door1.GetComponent<Waypoints>().enabled = true;
            door2.GetComponent<Waypoints>().enabled = true;
        }
    }
}