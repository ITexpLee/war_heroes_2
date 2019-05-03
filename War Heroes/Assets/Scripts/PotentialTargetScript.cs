using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotentialTargetScript : MonoBehaviour
{
    public bool created;
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "collider")
		{
			transform.position = col.transform.position;
			created = true;
			Debug.Log("!!!!!!!!!!!");
		}
	}
	
	void Start()
	{
		created = false;
	}
}
