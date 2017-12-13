using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {
	
	public GameObject PauseUI;
	public Transform StartPoint;
	public GameObject StartMenu;
	public GameObject player;
	public GameObject Beehive1;
	public GameObject Treetrap;
	public GameObject Beehive2;
	public GameObject Vinedoor;
	public GameObject Waterfall;
	public GameObject Waterfall1;
	public GameObject Waterfall2;
	public GameObject Waterfall3;
	public GameObject Waterfall4;
	public GameObject Waterfall5;
	public GameObject Waterfall6;
	public Transform WaterPoint;
	public Transform WaterPoint1;
	public Transform WaterPoint2;
	public Transform WaterPoint3;
	public Transform WaterPoint4;
	public Transform WaterPoint5;
	public Transform WaterPoint6;
	public GameObject Beehive3;
	public GameObject Vine;
	public Transform VinePoint;
	public GameObject Beehive4;
	public GameObject Swamplog;
	public Transform SwampPoint;
	public GameObject Beehive5;
	public GameObject Swamplog1;
	public Transform SwampPoint1;
	public GameObject Beehive6;
	public GameObject Vinedoor1;
	public Transform DoorPoint1;
	public Transform DoorPoint2;
	public Transform DoorPoint3;
	public Transform DoorPoint4;
	public Transform DoorPoint5;
	public Transform DoorPoint6;
	public GameObject TempleDoor1;
	public GameObject TempleDoor2;
	public GameObject TempleDoor3;
	public GameObject TempleDoor4;
	public GameObject TempleDoor5;
	public GameObject TempleDoor6;
	public GameObject Spear1;
	public GameObject Spear2;
	public GameObject Spear3;
	public GameObject Spear4;
	public GameObject Spear5;
	public GameObject Spear6;
	public Transform SpearPoint1;
	public Transform SpearPoint2;
	public Transform SpearPoint3;
	public Transform SpearPoint4;
	public Transform SpearPoint5;
	public Transform SpearPoint6;
	public GameObject Treasure1;
	public GameObject Treasure2;
	public GameObject Treasure3;
	public GameObject Treasure4;
	public GameObject Treasure5;
	public GameObject Treasure6;
	public GameObject Treasure7;
	public GameObject Treasure8;
	

	// Use this for initialization
	public void RestartButton () {
		DoOver();
	}
	
	// Update is called once per frame
	void DoOver () {
		StartMenu.SetActive(true);
		PauseUI.SetActive(false);
		player.transform.position = StartPoint.transform.position;
		Beehive1.SetActive(true);
		Beehive2.SetActive(true);
		Treetrap.SetActive(true);
		Vinedoor.SetActive(true);
		Waterfall.transform.position = WaterPoint.transform.position;
		Waterfall1.transform.position = WaterPoint1.transform.position;
		Waterfall2.transform.position = WaterPoint2.transform.position;
		Waterfall3.transform.position = WaterPoint3.transform.position;
		Waterfall4.transform.position = WaterPoint4.transform.position;
		Waterfall5.transform.position = WaterPoint5.transform.position;
		Waterfall6.transform.position = WaterPoint6.transform.position;
		Beehive3.SetActive(true);
		Vine.transform.position = VinePoint.transform.position;
		Beehive4.SetActive(true);
		Swamplog.transform.position = SwampPoint.transform.position;
		Beehive5.SetActive(true);
		Swamplog1.transform.position = SwampPoint1.transform.position;
		Beehive6.SetActive(true);
		Vinedoor1.SetActive(true);
		TempleDoor1.transform.position = DoorPoint1.transform.position;
		TempleDoor2.transform.position = DoorPoint2.transform.position;
		TempleDoor3.transform.position = DoorPoint3.transform.position;
		TempleDoor4.transform.position = DoorPoint4.transform.position;
		TempleDoor5.transform.position = DoorPoint5.transform.position;
		TempleDoor6.transform.position = DoorPoint6.transform.position;
		Spear1.transform.position = SpearPoint1.transform.position;
		Spear2.transform.position = SpearPoint2.transform.position;
		Spear3.transform.position = SpearPoint3.transform.position;
		Spear4.transform.position = SpearPoint4.transform.position;
		Spear5.transform.position = SpearPoint5.transform.position;
		Spear6.transform.position = SpearPoint6.transform.position;
		Treasure1.SetActive(true);
		Treasure2.SetActive(true);
		Treasure3.SetActive(true);
		Treasure4.SetActive(true);
		Treasure5.SetActive(true);
		Treasure6.SetActive(true);
		Treasure7.SetActive(true);
		Treasure8.SetActive(false);
	
		
	}
}
