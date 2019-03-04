using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim.GetComponent<Animation>();
    }

    // Update is called once per frame
    public void TriggerExitPopupAnimation()
    {
        anim.Play("ExitPopup");
    }

    public void TriggerReverseExitPopupAnimation() {
        anim.Play("ReverseExitPopup");
    }

    public void ExitGame(){

        Debug.Log("Game Exited");
        Application.Quit();

    }
}
