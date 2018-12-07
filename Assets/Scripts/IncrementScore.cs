using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IncrementScore : MonoBehaviour
{

	public Text textMoney;
	private int money;

	void Update()
	{
		Touches();
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
}