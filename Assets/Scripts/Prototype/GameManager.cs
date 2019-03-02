using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public Text text;
	private int money;

	void Start(){
		money = 0;
	}

	public void Increment(){
		money++;
		text.text = ("Money= " + money);	}
}
