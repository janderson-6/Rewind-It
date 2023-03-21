using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdownNoRed : MonoBehaviour
{
    RewindTime rewindPlayer;

    public GameObject timeText;

    public int secondsLeft;
    public bool takingAway = false;

    float minutes;
    float seconds;

    int loop = 0;

    void Start()
    {
        rewindPlayer = GameObject.FindGameObjectWithTag("RewindPlayer").GetComponent<RewindTime>();

        minutes = Mathf.FloorToInt(secondsLeft / 60);
        seconds = Mathf.FloorToInt(secondsLeft % 60);

        timeText.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (secondsLeft == 0)
        {
            Time.timeScale = 2;

            rewindPlayer.StartRewind();

            if (loop == 3)
            {
                timeText.SetActive(false);
            }

            else
            {
                timeText.GetComponent<Text>().text = "00:10";
                secondsLeft = 10;
            }
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;

        minutes = Mathf.FloorToInt(secondsLeft / 60);
        seconds = Mathf.FloorToInt(secondsLeft % 60);

        timeText.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (secondsLeft == 0)
        {
            StartCoroutine(StopTimer());
            takingAway = true;
        }

        else
        {
            takingAway = false;
        }
    }

    IEnumerator StopTimer()
    {
        takingAway = false;
        yield return new WaitForSeconds(10);

        loop++;
        takingAway = false;
    }
}