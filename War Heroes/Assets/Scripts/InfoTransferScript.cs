using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTransferScript : MonoBehaviour
{
	public GameObject ros1;
	public GameObject ros2;
	public GameObject ros3;
	public GameObject ros4;
	public string Unit1;
	public string Unit2;
	public string Unit3;
	public string Unit4;
	public bool BattleG;
	public GameObject Slots;
	private int delay;
	void Awake()
	{
		DontDestroyOnLoad(gameObject);
	}
	

    void Start()
    {
	BattleG = false;
	delay = 0;
    }

    // Update is called once per frame
    void Update()
    {
		if (BattleG)
		{
			if (delay >= 150)
			{
				Slots.transform.position = new Vector3(100f,300f,1f);
				Slots.transform.localScale = new Vector3(2.4f, 2.4f, 0);
			}
		}
		if (ros1 != null && ros2 != null && ros3 != null && ros4 != null)
		{
			if (ros1.GetComponent<Image>().sprite != null)
				Unit1 = ros1.GetComponent<Image>().sprite.name;
			if (ros2.GetComponent<Image>().sprite != null)
				Unit2 = ros2.GetComponent<Image>().sprite.name;
			if (ros3.GetComponent<Image>().sprite != null)
				Unit3 = ros3.GetComponent<Image>().sprite.name;
			if (ros4.GetComponent<Image>().sprite != null)
				Unit4 = ros4.GetComponent<Image>().sprite.name;
		}
		delay++;
    }
}
