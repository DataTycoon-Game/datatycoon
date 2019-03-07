using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour {

    private ExitGame exitGame;

    void Start () {
        exitGame = gameObject.GetComponent<ExitGame>();
    }
	
	public void Play ()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    public void Credits ()
    {
        Debug.Log("Credits");
    }

    public void Exit ()
    {
        exitGame.TriggerExitPopupAnimation();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitGame.TriggerExitPopupAnimation();
        }
    }

}
