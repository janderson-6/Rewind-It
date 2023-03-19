using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameStartCountdown : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    void Start()
    {
        Time.timeScale = 0;
        countdownDisplay.gameObject.SetActive(true);
        StartCoroutine(StartCountdown());
    }

    IEnumerator StartCountdown()
    {
        Time.timeScale = 0;
        float pauseTime = Time.realtimeSinceStartup + 3f;

        while (Time.realtimeSinceStartup < pauseTime)
        {
            yield return 0;
        }

        Time.timeScale = 1;
        countdownDisplay.gameObject.SetActive(false);
    }
}