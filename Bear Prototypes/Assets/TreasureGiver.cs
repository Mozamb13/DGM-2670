using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureGiver : MonoBehaviour {
	public GameObject treasure;
	public GameObject TalkUI;
	public GameObject speechUI;

	// Use this for initialization
	public void GiverofGoodsButton () {
		Winner();
	}
	
	void Winner() {
		treasure.SetActive(true);
		TalkUI.SetActive(true);
		speechUI.SetActive(false);
	
	}
}
