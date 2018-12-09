using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour {

	public Sprite[] textures;
	public Image uiImageH;
	private ScoreManager incrementScore;
	private int numberOfBG;
	public int i;
	public int upgradeCost;

	void Start() {
		uiImageH.sprite = textures[0];
		incrementScore = FindObjectOfType<ScoreManager>();
	}

	public void ChangeImage() {
		if (incrementScore.money >= upgradeCost && i <= textures.Length - 1) {
			uiImageH.sprite = textures[i];
			incrementScore.money = incrementScore.money - upgradeCost;
			incrementScore.textMoney.text = "Money: " + incrementScore.money.ToString();
			i++;
			upgradeCost = upgradeCost * 2;
		}
	}
}
