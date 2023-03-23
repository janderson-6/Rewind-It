using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimerCountdown : MonoBehaviour
{
    RewindTime rewindPlayer;
    RewindTime rewindRed;

    public AudioSource rewind;

    public GameObject timeText;
    public GameObject rewindIcon;

    public int secondsLeft;
    public bool takingAway = false;

    float minutes;
    float seconds;

    int loop = 0;

    void Start()
    {
        rewindPlayer = GameObject.FindGameObjectWithTag("RewindPlayer").GetComponent<RewindTime>();
        rewindRed = GameObject.FindGameObjectWithTag("RewindRed").GetComponent<RewindTime>();

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
            rewindRed.StartRewind();
            
            if(loop == 3)
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
        rewindIcon.SetActive(false);
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;

        minutes = Mathf.FloorToInt(secondsLeft / 60);
        seconds = Mathf.FloorToInt(secondsLeft % 60);

        timeText.GetComponent<Text>().text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if(secondsLeft == 0)
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
        rewind.Play();
        rewindIcon.SetActive(true);

        yield return new WaitForSeconds(10);

        loop++;
        takingAway = false;
    }
}