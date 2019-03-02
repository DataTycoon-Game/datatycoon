using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveDataEncrypter
{

    public int money;

    public SaveDataEncrypter(IncrementMoney incrementMoney)
    {

        money = incrementMoney.money;

        Debug.Log(money);

    }

}
