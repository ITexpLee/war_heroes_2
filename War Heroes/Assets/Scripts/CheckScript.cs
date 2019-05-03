using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
	{
	
		
	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "detector")
		{
			Destroy(this.gameObject);
			Debug.Log("ASDASDA");
		}		
		
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
