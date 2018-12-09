using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyEffect : MonoBehaviour {


	public GameObject money;
	private ScoreManager scoreManager;
	private float width;
	private float height;

	void Start () {
		scoreManager = FindObjectOfType<ScoreManager>();
		width = (float)Screen.width / 2.0f;
		height = (float)Screen.height / 2.0f;
	}

	public void ShowMoneyEffect () {
		GameObject newMoney = Instantiate(money, new Vector3 (scoreManager.touchPos.position.x - width, scoreManager.touchPos.position.y - height, 0.0f), transform.rotation) as GameObject;
		newMoney.transform.SetParent(GameObject.FindGameObjectWithTag("canvas").transform, false);
	}
}
