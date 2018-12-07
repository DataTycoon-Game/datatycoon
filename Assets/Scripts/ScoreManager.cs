using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

	public Text textMoney;
	public int money;
	private ImageManager imageManager;
	public Text buttonUpgrade;

	void Start() {
		imageManager = FindObjectOfType<ImageManager>();
	} 

	void Update()
	{
		Touches();
		ButtonText();
	}

	void Touches()
	{
		if (Input.touchCount > 0)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began)
			{
				money++;
				textMoney.text = "Money: " + money.ToString();
			}
		}
	}

	void ButtonText() {
		if (imageManager.textures.Length >= imageManager.i + 1)
		{
			buttonUpgrade.text = "Buy next upgrade for: " + imageManager.upgradeCost.ToString();
		}
		else {
			buttonUpgrade.text = "Upgrade Maxed Out";
		}
	}
}