using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
    public Material mt;
    public Color32[] colors;
    // Start is called before the first frame update
    void Start()
    {
        mt = transform.GetComponent<MeshRenderer>().material;
        colors = new Color32[9]
        {
            new Color32(255, 64, 64, 255), //red
            new Color32(255, 153, 64, 255), //orange
            new Color32(255, 249, 64, 255), //yellow
            new Color32(106, 255, 0, 64), //green
            new Color32(64, 0, 255, 246), //blue
            new Color32(64, 166, 255, 255), //darkblue
            new Color32(177, 164, 238, 255), //indigo
            new Color32(241, 64, 255, 255), //violet
            new Color32(255, 64, 135, 255) //fuscia
        };
        StartCoroutine(Cycle());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public IEnumerator Cycle()
    {
        int i = 0;
        while (true)
        {
            for (float interpolant = 0f; interpolant < 1f; interpolant += 0.001f)
            {
                mt.color = Color.Lerp(colors[i % 7], colors[(i + 1) % 7], interpolant);
                yield return null;
            }
            i++;
        }
    }
}