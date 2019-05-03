using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkInstan : MonoBehaviour
{
    public GameObject selector;
    private GameObject Player;
    private Vector3 playerPos;
    private GameObject Selector;
    private bool show = false;

    public void InstantiateSelector(string tag)
    {
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
            Selector.GetComponent<AtkRange>().source = true;
            if (GameObject.FindGameObjectWithTag(tag).name == "Cavalry" + "(Clone)")
            {
                Selector.GetComponent<AtkRange>().steps = 1;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Archer" + "(Clone)")
            {
                Selector.GetComponent<AtkRange>().steps = 3;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Sorceress" + "(Clone)")
            {
                Selector.GetComponent<AtkRange>().steps = 2;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Warrior" + "(Clone)")
            {
                Selector.GetComponent<AtkRange>().steps = 1;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Thief" + "(Clone)")
            {
                Selector.GetComponent<AtkRange>().steps = 2;
            }
            if (GameObject.FindGameObjectWithTag(tag).name == "Cleric" + "(Clone)")
            {
                Selector.GetComponent<AtkRange>().steps = 1;
            }

            Selector.GetComponent<AtkRange>().instantiator = tag;
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