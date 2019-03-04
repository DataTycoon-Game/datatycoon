using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveDataEncrypter
{

    public int money;
	public int imageNumber;

	public SaveDataEncrypter(IncrementMoney incrementMoney, ImageManager imageManager)
    {

        money = incrementMoney.money;

		imageNumber = imageManager.imageNumber;

        Debug.Log(money + ", " + imageNumber);

    }

}
