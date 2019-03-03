using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnFinished : MonoBehaviour {

	private Animator anim;
	private float animLenght;

	void Start () {
		anim = GetComponentInChildren<Animator>();
		animLenght = anim.GetCurrentAnimatorStateInfo(0).length;
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine(DestroyWithDelay());
	}

	IEnumerator DestroyWithDelay() {
		yield return new WaitForSecondsRealtime(animLenght);
		Destroy(this.gameObject);
	}
}
