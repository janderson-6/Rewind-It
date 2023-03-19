using UnityEngine;
using UnityEngine.UI;

public class SwitchLevel : MonoBehaviour
{
    //public TimerCountdown countdown;

    public GameObject levelOne;
    public GameObject levelTwo;
    //public GameObject levelThree;
    //public GameObject levelFour;
    //public GameObject levelFive;
    //public GameObject levelSix;
    public GameObject panel;
    public GameObject gameManager;
    public GameObject player;
    public Text TimerDisplay;

    int level = 1;

    //THIS WILL BE IN THE FUNCTION THAT THE BUTTON CALLS
    public void ButtonPressed()
    {
        level += 1; //increment level by one

        switch (level)
        {
            case 1:
                levelOne.SetActive(true);
                gameManager.GetComponent<TimerCountdown>().enabled = false;
                
                break;

            case 2:
                levelTwo.SetActive(true);   //level 2 object is active
                levelOne.SetActive(false);  //disable level 1 object
                
                //set camera position
                Camera.main.transform.position = Vector3.Lerp(transform.position, new Vector3(20, 16, -15), 1f);

                gameManager.GetComponent<TimerCountdown>().enabled = true;
                //player.GetComponent<PlayerController>().enabled = true;

                //countdown.secondsLeft = 10;
                Time.timeScale = 1;
                TimerDisplay.gameObject.SetActive(true);
                gameManager.SetActive(true);
                panel.SetActive(false);
                break;

            /*case 3:
                levelThree.SetActive(true); //level 3 object is active
                levelTwo.SetActive(false);  //disable level 2 object

                //set camera position
                Camera.main.transform.position = Vector3.Lerp(transform.position, new Vector3(55, 16, -15), 1f);

                TimerDisplay.gameObject.SetActive(true);
                gameManager.SetActive(true);
                panel.SetActive(false);
                break;

            case 4:
                levelFour.SetActive(true);  //level 4 object is active
                levelThree.SetActive(false);    //disable level 3 object

                //set camera position
                Camera.main.transform.position = Vector3.Lerp(transform.position, new Vector3(86, 16, -15), 1f);

                TimerDisplay.gameObject.SetActive(true);
                gameManager.SetActive(true);
                panel.SetActive(false);
                break;

            case 5:
                levelFive.SetActive(true);  //level 5 object is active
                levelFour.SetActive(false); //disable level 4 object

                //set camera position
                Camera.main.transform.position = Vector3.Lerp(transform.position, new Vector3(115.5f, 18, -15), 1f);

                TimerDisplay.gameObject.SetActive(false);
                gameManager.SetActive(false);
                panel.SetActive(false);

                break;

            case 6:
                levelSix.SetActive(true);   //level 6 object is active
                levelFive.SetActive(false); //disable level 5 object

                //set camera position
                Camera.main.transform.position = Vector3.Lerp(transform.position, new Vector3(144.5f, 18, -15), 1f);

                TimerDisplay.gameObject.SetActive(true);
                gameManager.SetActive(true);
                panel.SetActive(false);
                break;*/

            default:
                break;
        }
    }
}