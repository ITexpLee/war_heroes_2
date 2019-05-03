using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rosScript : MonoBehaviour {

	private Image image;
	public bool filled;

	// Use this for initialization
	void Start () {
		image = GetComponent<Image>();	
		filled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (image.sprite != null)
		{
			if (image.sprite.name == "")
				filled = false;
			else
				filled = true;
		}
	}
}
