using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class DisableGame : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject panel;
    public Text TimerDisplay;

    public int secondsLeft = 40;
    public bool takingAway = false;

    void Start()
    {
        panel.SetActive(false);
    }

    void Update()
    {
        if (takingAway == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (secondsLeft == 0)
        {
            TimerDisplay.gameObject.SetActive(false);
            gameManager.SetActive(false);
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    IEnumerator TimerTake()
    {
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;

        takingAway = false;
    }
}