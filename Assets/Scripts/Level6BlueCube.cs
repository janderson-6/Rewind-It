using UnityEngine;

public class Level6BlueCube : MonoBehaviour
{
    public int blue = 0;

    public int OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("BlueTrigger") == true)
        {
            blue = 1;
            return blue;
        }

        return 0;
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("BlueTrigger"))
        {
            blue = 0;
        }
    }
}