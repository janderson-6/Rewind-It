using UnityEngine;

public class RedCubeCollision : MonoBehaviour
{
    public GameObject EndGoal;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("RedTrigger") == true)
        {
            Debug.Log("collision");
            EndGoal.SetActive(true);
        }

        else
        {
            EndGoal.SetActive(false);
        }
    }
}