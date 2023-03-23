using UnityEngine;

public class ActivateEndGoal : MonoBehaviour
{
    public GameObject EndGoal;
    Level6RedCube redCube;
    Level6BlueCube blueCube;

    void Start()
    {
        blueCube = GameObject.FindGameObjectWithTag("BlueCube").GetComponent<Level6BlueCube>();
        redCube = GameObject.FindGameObjectWithTag("RewindRed").GetComponent<Level6RedCube>();
    }

    private void Update()
    {
        if (redCube.red == 1 && blueCube.blue == 1)
        {
            EndGoal.SetActive(true);
        }

        else
        {
            EndGoal.SetActive(false);
        }
    }
}