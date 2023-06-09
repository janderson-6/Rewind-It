using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public GameObject[] waypoints;
    int current = 0;
    public float speed;
    float WPradius = 1;

    void Update()
    {
        if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
        {
            current++;

            if(current >= waypoints.Length)
            {
                current = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);

        if(Time.timeScale == 2)
        {
            speed = 2.5f;
        }

        else
        {
            speed = 5f;
        }
    }
}