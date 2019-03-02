using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncrementMoney : MonoBehaviour
{

    public Text text;
    public int money;

    void Start()
    {
        money = 0;
    }

    public void Increment()
    {
        money++;
        text.text = ("Money= " + money);
    }

}
