using UnityEngine;

public class Level6BlueCube : MonoBehaviour
{
    public int blue = 0;

    public int OnTriggerStay(Collider other)
    {
        blue = 1;

        if (other.gameObject.tag.Equals("BlueTrigger") == true)
        {
            return blue;
        }

        return 0;
    }
}