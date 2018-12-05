﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncrementScore : MonoBehaviour {

	public Text textMoney;
	private int money;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 1) {
			if (Input.GetTouch(0).phase == TouchPhase.Began) {
				money++;
				textMoney.text = "Money: " + money.ToString();
			}
		}
	}
}
