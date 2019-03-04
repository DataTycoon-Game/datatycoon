using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataManager : MonoBehaviour
{

    private IncrementMoney incrementMoney;
	private ImageManager imageManager;

    private void Start ()
    {
        incrementMoney = GetComponent<IncrementMoney>();
		imageManager = GetComponent<ImageManager>();
    }

    public void Save ()
    {
        SaveDataModel.SaveData(incrementMoney, imageManager);
    }

    
    public void Load ()
    {
        SaveDataEncrypter data = SaveDataModel.LoadData();

        incrementMoney.money = data.money;
		imageManager.imageNumber = data.imageNumber;

		imageManager.uiImageHolder.sprite = imageManager.images[imageManager.imageNumber];

        incrementMoney.text.text = "Money= " + data.money;
    }

}
