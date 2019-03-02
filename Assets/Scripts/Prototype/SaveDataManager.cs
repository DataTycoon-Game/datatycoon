using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{

    private IncrementMoney incrementMoney;

    private void Start ()
    {
        incrementMoney = GetComponent<IncrementMoney>();
    }

    public void Save ()
    {
        SaveDataModel.SaveData(incrementMoney);
    }

    
    public void Load ()
    {
        SaveDataEncrypter data = SaveDataModel.LoadData();

        incrementMoney.money = data.money;

        incrementMoney.text.text = "Money= " + data.money;
    }

}
