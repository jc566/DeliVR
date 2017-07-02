using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changepanel3 : MonoBehaviour {
	public static int[] colorArray = new int[] { 1, 1, 2, 3, 3, 0, 1, 2};
	// Use this for initialization
	// 0 = red, 1 = green, 2 = blue, 3 = white
	void Start () {
		Image img = GameObject.Find ("colorlabel").GetComponent<Image>();
		img.color = UnityEngine.Color.green;
	}
}
