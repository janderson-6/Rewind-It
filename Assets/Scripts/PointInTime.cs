
using UnityEngine;

public class PointInTime
{
    public Vector3 position;
    public Quaternion rotation;

    public PointInTime (Vector3 p, Quaternion r)
    {
        position = p;
        rotation = r;
    }
}
