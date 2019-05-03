using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectUnitScript : MonoBehaviour
{
	private Vector3 targetPos;
	public GameObject target;
	public Vector3 posit;
	public GameObject PotentialTarget;
	private GameObject Obj;
	private GameObject CreatedTarget;
	
	void Start()
	{
		posit = new Vector3(-0.0168f, -1.8f, -0.5f);	
	}
	
    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			targetPos.z = transform.position.z;
			if (CreatedTarget != null)
				Destroy(CreatedTarget);
			Obj = Instantiate(PotentialTarget, new Vector3(targetPos.x, targetPos.y, -5f), Quaternion.identity);
		}
		//Debug.Log(Obj.GetComponent<PotentialTargetScript>().created);
		if (Obj != null && Obj.GetComponent<PotentialTargetScript>().created)
		{
			Debug.Log("1111111111");
			CreatedTarget = Instantiate(target, Obj.transform.position, Quaternion.identity);
			if (Obj != null)
			{
				Destroy(Obj);
				Obj.GetComponent<PotentialTargetScript>().created = false;
			}
		}
    }
}
