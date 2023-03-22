using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour
{
    Scene currentScene;
    string sceneName;

    void Start()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
    }

    void Update()
    {
        //Restart Level if player presses 'R'
        if (Input.GetKey(KeyCode.R))
        {
            if(sceneName != "Main")
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    //THIS WILL BE IN THE FUNCTION THAT THE BUTTON CALLS
    public void NextLevel()
    {
        if(sceneName == "Main")
        {
            SceneManager.LoadScene("Level 1");
        }

        else if (sceneName == "Level 1")
        {
            SceneManager.LoadScene("Level 2");
        }

        else if (sceneName == "Level 2")
        {
            SceneManager.LoadScene("Level 3");
        }

        else if (sceneName == "Level 3")
        {
            SceneManager.LoadScene("Level 4");
        }

        else if (sceneName == "Level 4")
        {
            SceneManager.LoadScene("Level 5");
        }

        else if (sceneName == "Level 5")
        {
            SceneManager.LoadScene("Level 6");
        }

        else if (sceneName == "Level 6")
        {
            SceneManager.LoadScene("Main");
        }
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}