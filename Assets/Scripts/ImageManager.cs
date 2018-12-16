using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour {

	public int i;
	public int upgradeCost;
	public Sprite[] textures;
	public Image uiImageH;

	private int numberOfBG;
	private float width;
	private float height;

	private ScoreManager incrementScore;

	void Start() {
		uiImageH.sprite = textures[0];
		incrementScore = FindObjectOfType<ScoreManager>();

		SettingImageToCanvasSize();
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

	void SettingImageToCanvasSize() {
		width = (float)Screen.width;
		height = (float)Screen.height;

		uiImageH.rectTransform.sizeDelta = new Vector2(width, height);
	}
}
