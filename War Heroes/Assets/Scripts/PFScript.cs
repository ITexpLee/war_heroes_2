using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PFScript : MonoBehaviour
{
	public int steps;
	private int delay = 0;
    private bool create = true;
    public string instantiator;
    public bool source = false;
    public static List<Vector3> myList = new List<Vector3>();
    private GameObject SelectorRight;
    private GameObject SelectorDown;
    private GameObject SelectorUp;
    private GameObject SelectorLeft;

    
    void OnCollisionEnter2D(Collision2D col)
	{
        if (instantiator == "1")
            if (col.gameObject.tag == "collider" || col.gameObject.tag == "2" || col.gameObject.tag == "3" || col.gameObject.tag == "4" || col.gameObject.tag == "5" || col.gameObject.tag == "6" || col.gameObject.tag == "7" || col.gameObject.tag == "8")
                Destroy(gameObject);
        if (instantiator == "2")
            if (col.gameObject.tag == "collider" || col.gameObject.tag == "1" || col.gameObject.tag == "3" || col.gameObject.tag == "4" || col.gameObject.tag == "5" || col.gameObject.tag == "6" || col.gameObject.tag == "7" || col.gameObject.tag == "8")
                Destroy(gameObject);
        if (instantiator == "3")
            if (col.gameObject.tag == "collider" || col.gameObject.tag == "2" || col.gameObject.tag == "1" || col.gameObject.tag == "4" || col.gameObject.tag == "5" || col.gameObject.tag == "6" || col.gameObject.tag == "7" || col.gameObject.tag == "8")
                Destroy(gameObject);
        if (instantiator == "4")
            if (col.gameObject.tag == "collider" || col.gameObject.tag == "2" || col.gameObject.tag == "3" || col.gameObject.tag == "1" || col.gameObject.tag == "5" || col.gameObject.tag == "6" || col.gameObject.tag == "7" || col.gameObject.tag == "8")
                Destroy(gameObject);
        if (instantiator == "5")
            if (col.gameObject.tag == "collider" || col.gameObject.tag == "2" || col.gameObject.tag == "3" || col.gameObject.tag == "4" || col.gameObject.tag == "1" || col.gameObject.tag == "6" || col.gameObject.tag == "7" || col.gameObject.tag == "8")
                Destroy(gameObject);
        if (instantiator == "6")
            if (col.gameObject.tag == "collider" || col.gameObject.tag == "2" || col.gameObject.tag == "3" || col.gameObject.tag == "4" || col.gameObject.tag == "5" || col.gameObject.tag == "1" || col.gameObject.tag == "7" || col.gameObject.tag == "8")
                Destroy(gameObject);
        if (instantiator == "7")
            if (col.gameObject.tag == "collider" || col.gameObject.tag == "2" || col.gameObject.tag == "3" || col.gameObject.tag == "4" || col.gameObject.tag == "5" || col.gameObject.tag == "6" || col.gameObject.tag == "1" || col.gameObject.tag == "8")
                Destroy(gameObject);
        if (instantiator == "8")
            if (col.gameObject.tag == "collider" || col.gameObject.tag == "2" || col.gameObject.tag == "3" || col.gameObject.tag == "4" || col.gameObject.tag == "5" || col.gameObject.tag == "6" || col.gameObject.tag == "7" || col.gameObject.tag == "1")
                Destroy(gameObject);
    }
	
    // Start is called before the first frame update
    void Start()
    {
        if (source)
        {
            for (var i = 0; i < myList.Count; i++)
                {
                    myList.RemoveAt(i);
                }
        }
		delay++;
        myList.Add(transform.position);

    }

    // Update is called once per frame
    void Update()
    {
		if (delay > 0)
			delay++;
		if (delay == 3)
		{
			if (steps > 0)
			{
                
				Debug.Log(steps);
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] == new Vector3 (transform.position.x - 0.32f, transform.position.y, transform.position.z))
                    {
                        create = false;
                        
                    }
                    
                }
                if (create)
                {
                    SelectorLeft = Instantiate(this.gameObject, new Vector3(transform.position.x - 0.32f, transform.position.y, -1), Quaternion.identity);
                    SelectorLeft.GetComponent<PFScript>().steps = this.steps - 1;
                    SelectorLeft.GetComponent<PFScript>().instantiator = this.instantiator;
                    SelectorLeft.transform.parent = GameObject.FindGameObjectWithTag("CAN").GetComponent<Transform>().transform;
                    myList.Add(new Vector3(transform.position.x - 0.32f, transform.position.y, -1));
                    create = true;
                }
                create = true;
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] == new Vector3(transform.position.x + 0.32f, transform.position.y, transform.position.z))
                    {
                        create = false;

                    }

                }
                if (create)
                {
                    SelectorRight = Instantiate(this.gameObject, new Vector3(transform.position.x + 0.32f, transform.position.y, -1), Quaternion.identity);
                    SelectorRight.GetComponent<PFScript>().steps = this.steps - 1;
                    SelectorRight.GetComponent<PFScript>().instantiator = this.instantiator;
                    SelectorRight.transform.parent = GameObject.FindGameObjectWithTag("CAN").GetComponent<Transform>().transform;
                    myList.Add(new Vector3(transform.position.x + 0.32f, transform.position.y, -1));
                    create = true;
                }
                create = true;
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] == new Vector3(transform.position.x, transform.position.y - 0.32f, transform.position.z))
                    {
                        create = false;

                    }
                    
                }
                if (create)
                {
                    SelectorDown = Instantiate(this.gameObject, new Vector3(transform.position.x, transform.position.y - 0.32f, -1), Quaternion.identity);
                    SelectorDown.GetComponent<PFScript>().steps = this.steps - 1;
                    SelectorDown.GetComponent<PFScript>().instantiator = this.instantiator;
                    SelectorDown.transform.parent = GameObject.FindGameObjectWithTag("CAN").GetComponent<Transform>().transform;
                    myList.Add(new Vector3(transform.position.x, transform.position.y - 0.32f, -1));
                    create = true;
                }
                create = true;
                for (int i = 0; i < myList.Count; i++)
                {
                    if (myList[i] == new Vector3(transform.position.x, transform.position.y + 0.32f, transform.position.z))
                    {
                        create = false;

                    }
                    
                }
                if (create)
                {
                    SelectorUp = Instantiate(this.gameObject, new Vector3(transform.position.x, transform.position.y + 0.32f, -1), Quaternion.identity);
                    SelectorUp.GetComponent<PFScript>().steps = this.steps - 1;
                    SelectorUp.GetComponent<PFScript>().instantiator = this.instantiator;
                    SelectorUp.transform.parent = GameObject.FindGameObjectWithTag("CAN").GetComponent<Transform>().transform;
                    myList.Add(new Vector3(transform.position.x, transform.position.y + 0.32f, -1));
                    create = true;
                }
                create = true;
				delay = 0;
			}
		}
    }
}