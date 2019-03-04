using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{

	public Image uiImageHolder;
	public Sprite[] images;
	public int imageNumber;
	public int moneyRequired;

	private IncrementMoney incrementMoney;

    void Start()
    {
		incrementMoney = GetComponent<IncrementMoney>();
		uiImageHolder.sprite = images[imageNumber];
		Debug.Log(images.Length);
    }

	public void BuyOffice ()
	{
		if (images.Length > imageNumber + 1)
		{
			if (incrementMoney.money >= moneyRequired)
			{
				incrementMoney.money = incrementMoney.money - moneyRequired;
				incrementMoney.text.text = "Money= " + incrementMoney.money;
				imageNumber++;
				uiImageHolder.sprite = images[imageNumber];
				moneyRequired = moneyRequired * 2;
			}
		}
		else 
		{
			Debug.Log("No more images!");	
		}
	}
}
