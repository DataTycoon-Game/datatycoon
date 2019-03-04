using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour {

    private Exit exit;

    void Start () {
        exit = gameObject.GetComponent<Exit>();
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
        exit.TriggerExitPopupAnimation();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exit.TriggerExitPopupAnimation();
        }
    }

}
