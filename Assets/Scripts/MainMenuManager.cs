using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour {
	
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
        Debug.Log("Exit");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

}
