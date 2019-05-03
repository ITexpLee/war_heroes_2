using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorInstan : MonoBehaviour
{
	public GameObject selector;
	private GameObject Player;
	private Vector3 playerPos;
    private GameObject Selector;
    private bool show = false;

    public void InstantiateSelector(string tag)
	{
        if (tag == "1")
        {
            if(GameObject.Find("ros2"))
                GameObject.Find("ros2").GetComponent<SelectorInstan>().show = false;
            if(GameObject.Find("ros3"))
                GameObject.Find("ros3").GetComponent<SelectorInstan>().show = false;
            if (GameObject.Find("ros4"))
                GameObject.Find("ros4").GetComponent<SelectorInstan>().show = false;
        }
        if (tag == "2")
        {
            if (GameObject.Find("ros1"))
                GameObject.Find("ros1").GetComponent<SelectorInstan>().show = false;
            if (GameObject.Find("ros3"))
                GameObject.Find("ros3").GetComponent<SelectorInstan>().show = false;
            if (GameObject.Find("ros4"))
                GameObject.Find("ros4").GetComponent<SelectorInstan>().show = false;
        }
        if (tag == "3")
        {
            if (GameObject.Find("ros2"))
                GameObject.Find("ros2").GetComponent<SelectorInstan>().show = false;
            if (GameObject.Find("ros1"))
                GameObject.Find("ros1").GetComponent<SelectorInstan>().show = false;
            if (GameObject.Find("ros4"))
                GameObject.Find("ros4").GetComponent<SelectorInstan>().show = false;
        }
        if (tag == "4")
        {
            if (GameObject.Find("ros2"))
                GameObject.Find("ros2").GetComponent<SelectorInstan>().show = false;
            if (GameObject.Find("ros3"))
                GameObject.Find("ros3").GetComponent<SelectorInstan>().show = false;
            if (GameObject.Find("ros1"))
                GameObject.Find("ros1").GetComponent<SelectorInstan>().show = false;
        }
        if (!show)
        {
            if (GameObject.FindGameObjectsWithTag("detector") != null)
            {
                GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("detector");
                foreach (GameObject target in gameObjects)
                {
                    Destroy(target);
                }

            }
            playerPos = GameObject.FindGameObjectWithTag(tag).transform.position;
            Selector = Instantiate(selector, playerPos, Quaternion.identity);
            Selector.GetComponent<PFScript>().source = true;
            if (GameObject.FindGameObjectWithTag(tag).name == "Cavalry" + "(Clone)")
            {
                Selector.GetComponent<PFScript>().steps = 6;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Archer" + "(Clone)")
            {
                Selector.GetComponent<PFScript>().steps = 3;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Sorceress" + "(Clone)")
            {
                Selector.GetComponent<PFScript>().steps = 3;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Warrior" + "(Clone)")
            {
                Selector.GetComponent<PFScript>().steps = 4;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Thief" + "(Clone)")
            {
                Selector.GetComponent<PFScript>().steps = 5;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Cleric" + "(Clone)")
            {
                Selector.GetComponent<PFScript>().steps = 3;
            }

            Selector.GetComponent<PFScript>().instantiator = tag;
            show = true;
        }
        else
        {
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("detector");
            foreach (GameObject target in gameObjects)
            {
                Destroy(target);
            }
            show = false;
        }
    }
}
