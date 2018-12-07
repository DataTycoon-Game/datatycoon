using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChanging : MonoBehaviour {

	public Sprite[] textures;
	public Image uiImageH;
	private IncrementScore incrementScore;
	private int numberOfBG;

	void Start() {
		uiImageH.sprite = textures[0];
		incrementScore = FindObjectOfType<IncrementScore>();
	}

	public void ChangeImage() {
		if (incrementScore.money >= 100) {
			uiImageH.sprite = textures[1];
			incrementScore.money = incrementScore.money - 100;
			incrementScore.textMoney.text = "Money: " + incrementScore.money.ToString();
		}
	}
}
