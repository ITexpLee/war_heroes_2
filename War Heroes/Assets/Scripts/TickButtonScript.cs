using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TickButtonScript : MonoBehaviour
{
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;
    public GameObject pos5;
    public GameObject pos6;
	public GameObject ros1;
	public GameObject ros2;
	public GameObject ros3;
	public GameObject ros4;
    public GameObject nCoins;
    public int nCash = 40;
    public int[] cost = { 10, 20, 5 };
    // Update is called once per frame
    public void Update()
    {
        
    }
    public void OnButtonPressed()
    {
        nCash = Convert.ToInt32(nCoins.GetComponent<Text>().text);
        if (ros1.GetComponent<Image>().sprite == null)
		{
			if (UnitSelectorScript.selectedUnit == "archer")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros1.GetComponent<Animation>().Play("roster select");
                    ros1.GetComponent<Image>().sprite = pos1.GetComponent<Image>().sprite;
                    ros1.GetComponent<Image>().color = new Color(ros1.GetComponent<Image>().color.r, ros1.GetComponent<Image>().color.g, ros1.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "cavalry")
			{
                if (nCash >= cost[1])
                {
                    nCash -= 20;

                    ros1.GetComponent<Animation>().Play("roster select");
                    ros1.GetComponent<Image>().sprite = pos2.GetComponent<Image>().sprite;
                    ros1.GetComponent<Image>().color = new Color(ros1.GetComponent<Image>().color.r, ros1.GetComponent<Image>().color.g, ros1.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "cleric")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros1.GetComponent<Animation>().Play("roster select");
                    ros1.GetComponent<Image>().sprite = pos3.GetComponent<Image>().sprite;
                    ros1.GetComponent<Image>().color = new Color(ros1.GetComponent<Image>().color.r, ros1.GetComponent<Image>().color.g, ros1.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }	
			else if (UnitSelectorScript.selectedUnit == "sorceress")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros1.GetComponent<Animation>().Play("roster select");
                    ros1.GetComponent<Image>().sprite = pos4.GetComponent<Image>().sprite;
                    ros1.GetComponent<Image>().color = new Color(ros1.GetComponent<Image>().color.r, ros1.GetComponent<Image>().color.g, ros1.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }	
			else if (UnitSelectorScript.selectedUnit == "thief")
			{
                if (nCash >= cost[2])
                {
                    nCash -= 5;

                    ros1.GetComponent<Animation>().Play("roster select");
                    ros1.GetComponent<Image>().sprite = pos5.GetComponent<Image>().sprite;
                    ros1.GetComponent<Image>().color = new Color(ros1.GetComponent<Image>().color.r, ros1.GetComponent<Image>().color.g, ros1.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "warrior")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros1.GetComponent<Animation>().Play("roster select");
                    ros1.GetComponent<Image>().sprite = pos6.GetComponent<Image>().sprite;
                    ros1.GetComponent<Image>().color = new Color(ros1.GetComponent<Image>().color.r, ros1.GetComponent<Image>().color.g, ros1.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			UnitSelectorScript.selectedUnit = null;
			
		}
		else if(ros2.GetComponent<Image>().sprite == null)
		{
			
			if (UnitSelectorScript.selectedUnit == "archer")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros2.GetComponent<Animation>().Play("roster select");
                    ros2.GetComponent<Image>().sprite = pos1.GetComponent<Image>().sprite;
                    ros2.GetComponent<Image>().color = new Color(ros2.GetComponent<Image>().color.r, ros2.GetComponent<Image>().color.g, ros2.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "cavalry")
			{
                if (nCash >= cost[1])
                {
                    nCash -= 20;

                    ros2.GetComponent<Animation>().Play("roster select");
                    ros2.GetComponent<Image>().sprite = pos2.GetComponent<Image>().sprite;
                    ros2.GetComponent<Image>().color = new Color(ros2.GetComponent<Image>().color.r, ros2.GetComponent<Image>().color.g, ros2.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "cleric")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros2.GetComponent<Animation>().Play("roster select");
                    ros2.GetComponent<Image>().sprite = pos3.GetComponent<Image>().sprite;
                    ros2.GetComponent<Image>().color = new Color(ros2.GetComponent<Image>().color.r, ros2.GetComponent<Image>().color.g, ros2.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }	
			else if (UnitSelectorScript.selectedUnit == "sorceress")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros2.GetComponent<Animation>().Play("roster select");
                    ros2.GetComponent<Image>().sprite = pos4.GetComponent<Image>().sprite;
                    ros2.GetComponent<Image>().color = new Color(ros2.GetComponent<Image>().color.r, ros2.GetComponent<Image>().color.g, ros2.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }	
			else if (UnitSelectorScript.selectedUnit == "thief")
			{
                if (nCash >= cost[2])
                {
                    nCash -= 5;

                    ros2.GetComponent<Animation>().Play("roster select");
                    ros2.GetComponent<Image>().sprite = pos5.GetComponent<Image>().sprite;
                    ros2.GetComponent<Image>().color = new Color(ros2.GetComponent<Image>().color.r, ros2.GetComponent<Image>().color.g, ros2.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "warrior")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros2.GetComponent<Animation>().Play("roster select");
                    ros2.GetComponent<Image>().sprite = pos6.GetComponent<Image>().sprite;
                    ros2.GetComponent<Image>().color = new Color(ros2.GetComponent<Image>().color.r, ros2.GetComponent<Image>().color.g, ros2.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			UnitSelectorScript.selectedUnit = null;

			
		}
		else if(ros3.GetComponent<Image>().sprite == null)
		{
			
			if (UnitSelectorScript.selectedUnit == "archer")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros3.GetComponent<Animation>().Play("roster select");
                    ros3.GetComponent<Image>().sprite = pos1.GetComponent<Image>().sprite;
                    ros3.GetComponent<Image>().color = new Color(ros3.GetComponent<Image>().color.r, ros3.GetComponent<Image>().color.g, ros3.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "cavalry")
			{
                if (nCash >= cost[1])
                {
                    nCash -= 20;

                    ros3.GetComponent<Animation>().Play("roster select");
                    ros3.GetComponent<Image>().sprite = pos2.GetComponent<Image>().sprite;
                    ros3.GetComponent<Image>().color = new Color(ros3.GetComponent<Image>().color.r, ros3.GetComponent<Image>().color.g, ros3.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "cleric")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros3.GetComponent<Animation>().Play("roster select");
                    ros3.GetComponent<Image>().sprite = pos3.GetComponent<Image>().sprite;
                    ros3.GetComponent<Image>().color = new Color(ros3.GetComponent<Image>().color.r, ros3.GetComponent<Image>().color.g, ros3.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }	
			else if (UnitSelectorScript.selectedUnit == "sorceress")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros3.GetComponent<Animation>().Play("roster select");
                    ros3.GetComponent<Image>().sprite = pos4.GetComponent<Image>().sprite;
                    ros3.GetComponent<Image>().color = new Color(ros3.GetComponent<Image>().color.r, ros3.GetComponent<Image>().color.g, ros3.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }	
			else if (UnitSelectorScript.selectedUnit == "thief")
			{
                if (nCash >= cost[2])
                {
                    nCash -= 5;

                    ros3.GetComponent<Animation>().Play("roster select");
                    ros3.GetComponent<Image>().sprite = pos5.GetComponent<Image>().sprite;
                    ros3.GetComponent<Image>().color = new Color(ros3.GetComponent<Image>().color.r, ros3.GetComponent<Image>().color.g, ros3.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "warrior")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros3.GetComponent<Animation>().Play("roster select");
                    ros3.GetComponent<Image>().sprite = pos6.GetComponent<Image>().sprite;
                    ros3.GetComponent<Image>().color = new Color(ros3.GetComponent<Image>().color.r, ros3.GetComponent<Image>().color.g, ros3.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			UnitSelectorScript.selectedUnit = null;
		
			
		}
		else if(ros4.GetComponent<Image>().sprite == null)
		{
			
			if (UnitSelectorScript.selectedUnit == "archer")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros4.GetComponent<Animation>().Play("roster select");
                    ros4.GetComponent<Image>().sprite = pos1.GetComponent<Image>().sprite;
                    ros4.GetComponent<Image>().color = new Color(ros4.GetComponent<Image>().color.r, ros4.GetComponent<Image>().color.g, ros4.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "cavalry")
			{
                if (nCash >= cost[1])
                {
                    nCash -= 20;

                    ros4.GetComponent<Animation>().Play("roster select");
                    ros4.GetComponent<Image>().sprite = pos2.GetComponent<Image>().sprite;
                    ros4.GetComponent<Image>().color = new Color(ros4.GetComponent<Image>().color.r, ros4.GetComponent<Image>().color.g, ros4.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "cleric")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros4.GetComponent<Animation>().Play("roster select");
                    ros4.GetComponent<Image>().sprite = pos3.GetComponent<Image>().sprite;
                    ros4.GetComponent<Image>().color = new Color(ros4.GetComponent<Image>().color.r, ros4.GetComponent<Image>().color.g, ros4.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }	
			else if (UnitSelectorScript.selectedUnit == "sorceress")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros4.GetComponent<Animation>().Play("roster select");
                    ros4.GetComponent<Image>().sprite = pos4.GetComponent<Image>().sprite;
                    ros4.GetComponent<Image>().color = new Color(ros4.GetComponent<Image>().color.r, ros4.GetComponent<Image>().color.g, ros4.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }	
			else if (UnitSelectorScript.selectedUnit == "thief")
			{
                if (nCash >= cost[2])
                {
                    nCash -= 5;

                    ros4.GetComponent<Animation>().Play("roster select");
                    ros4.GetComponent<Image>().sprite = pos5.GetComponent<Image>().sprite;
                    ros4.GetComponent<Image>().color = new Color(ros4.GetComponent<Image>().color.r, ros4.GetComponent<Image>().color.g, ros4.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			else if (UnitSelectorScript.selectedUnit == "warrior")
			{
                if (nCash >= cost[0])
                {
                    nCash -= 10;

                    ros4.GetComponent<Animation>().Play("roster select");
                    ros4.GetComponent<Image>().sprite = pos6.GetComponent<Image>().sprite;
                    ros4.GetComponent<Image>().color = new Color(ros4.GetComponent<Image>().color.r, ros4.GetComponent<Image>().color.g, ros4.GetComponent<Image>().color.b, 1f);
                    FindObjectOfType<AudioManager>().play("Treasure");
                }
            }
			UnitSelectorScript.selectedUnit = null;
            

        }
        nCoins.GetComponent<Text>().text = nCash.ToString();
    }
}
