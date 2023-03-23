using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBlueCube : MonoBehaviour
{
    Level6RedCube redCube;

    public GameObject door1;
    public GameObject door2;
    public GameObject door3;
    public GameObject door4;
    //int speed = 5;

    void Start()
    {
        redCube = GameObject.FindGameObjectWithTag("RewindRed").GetComponent<Level6RedCube>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag.Equals("BlueTrigger") == true)
        {
            if (redCube.red == 1)
            {
                Debug.Log("open doors");
                door1.GetComponent<Waypoints>().enabled = true;
                door2.GetComponent<Waypoints>().enabled = true;
                door3.GetComponent<Waypoints>().enabled = true;
                door4.GetComponent<Waypoints>().enabled = true;
            }

            else
            {
                Debug.Log("close doors");
                //door1.transform.Translate(new Vector3(0.049f, -5.58f, 0.05f));

                //float step = speed * Time.deltaTime;
                //door1.transform.position = Vector3.MoveTowards(transform.position, new Vector3(0.049f, -5.58f, 0.05f), 1f);
                //door1.transform.position = new Vector3(0.0494999886f, -5.58916378f, 0.0500001907f);
                //door2.transform.position = new Vector3(1.90950012f, -5.58916378f, 0.0500001907f);
                //door3.transform.position = new Vector3(0.989500046f, -5.58916378f, 0.909999847f);
                //door4.transform.position = new Vector3(0.989499807f, -5.58916378f, -0.813000679f);
            }
        }
    }
}