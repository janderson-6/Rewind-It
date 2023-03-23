using UnityEngine;

public class Level6RedCube : MonoBehaviour
{
    public int red = 0;

    public int OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("RedTrigger") == true)
        {
            red = 1;
            return red;
        }

        return 0;
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("RedTrigger"))
        {
            red = 0;
        }
    }
}