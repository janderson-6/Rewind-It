using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6RedCube : MonoBehaviour
{
    public int red = 0;

    public int OnTriggerStay(Collider other)
    {
        red = 1;

        if (other.gameObject.tag.Equals("RedTrigger") == true)
        {
            return red;
        }
        return 0;
    }
}