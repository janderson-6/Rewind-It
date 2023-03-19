using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindTime : MonoBehaviour
{
    private bool isRewinding = false;
    public float recordTime = 10f;

    List<PointInTime> pointsInTime;
    Rigidbody rb;

    void Start()
    {
        pointsInTime = new List<PointInTime>();
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (isRewinding)
        {
            Rewind();
        }

        else
        {
            Record();
        }
    }

    void Record()
    {
        if(pointsInTime.Count > Mathf.Round(recordTime / Time.deltaTime))
        {
            pointsInTime.RemoveAt(pointsInTime.Count - 1);
        }

        pointsInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
    }

    void Rewind()
    {
        if(pointsInTime.Count > 0)
        {
            PointInTime pointInTime = pointsInTime[0];
            transform.position = pointInTime.position;
            transform.rotation = pointInTime.rotation;
            pointsInTime.RemoveAt(0);
        }

        else
        {
            StopRewind();
        }
    }

    public void StartRewind()
    {
        isRewinding = true;
        //rb.isKinematic = true;
    }

    public void StopRewind()
    {
        isRewinding = false;
        Time.timeScale = 1;
        //rb.isKinematic = false;
    }
}