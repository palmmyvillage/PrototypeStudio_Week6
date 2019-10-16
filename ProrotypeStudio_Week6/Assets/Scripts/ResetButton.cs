using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    public KeyCode resetGameButton, resetSceneButton, quitGameButton;

    public bool enableNextScene;
    public KeyCode nextSceneButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ResetGame();
        ResetScene();
        QuitGame();
        goNextScene();
    }

    void ResetGame()
    {
        if (Input.GetKeyDown(resetGameButton))
        {
            SceneManager.LoadScene(0);
            Debug.Log("resetGame");
        }
    }

    void ResetScene()
    {
        if (Input.GetKeyDown(resetSceneButton))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Debug.Log("resetScene");
        }
    }

    void QuitGame()
    {
        if (Input.GetKeyDown(quitGameButton))
        {
            Application.Quit();
            Debug.Log("quitGame");
        }
    }

    void goNextScene()
    {
        if (enableNextScene == true)
        {
            if (Input.GetKeyDown(nextSceneButton))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                Debug.Log("nextScene");
            }
        }
    }
}
