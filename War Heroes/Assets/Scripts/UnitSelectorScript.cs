using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelectorScript : MonoBehaviour
{
	public static string selectedUnit;
	public GameObject Cards;
	private static GameObject LastCard;

	
	void Start()
	{
		LastCard = Cards.transform.GetChild(0).gameObject;
	}
	
	public void OnButtonPressed()
	{
		
		 if (this.name == "pos1")
		{	
			LastCard.SetActive(false);
			LastCard = Cards.transform.GetChild(0).gameObject;
			selectedUnit = "archer";
			Cards.transform.GetChild(0).gameObject.SetActive(true);
            FindObjectOfType<AudioManager>().play("Laser");
        }
	        if (this.name == "pos2")
		{
			LastCard.SetActive(false);
			LastCard = Cards.transform.GetChild(1).gameObject;
			selectedUnit = "cavalry";
			Cards.transform.GetChild(1).gameObject.SetActive(true);
            FindObjectOfType<AudioManager>().play("Laser");
        }
		else if (this.name == "pos3")
		{
			
			LastCard.SetActive(false);
			Cards.transform.GetChild(2).gameObject.SetActive(true);
			LastCard = Cards.transform.GetChild(2).gameObject;
			selectedUnit = "cleric";
            FindObjectOfType<AudioManager>().play("Laser");
        }
	        if (this.name == "pos4")
		{
			LastCard.SetActive(false);
			Cards.transform.GetChild(3).gameObject.SetActive(true);
			selectedUnit = "sorceress";
			LastCard = Cards.transform.GetChild(3).gameObject;
            FindObjectOfType<AudioManager>().play("Laser");
        }
	        if (this.name == "pos5")
		{
			
			LastCard.SetActive(false);
			Cards.transform.GetChild(4).gameObject.SetActive(true);
			selectedUnit = "thief";			
			LastCard = Cards.transform.GetChild(4).gameObject;
            FindObjectOfType<AudioManager>().play("Laser");
        }
		 if (this.name == "pos6")
		{
			
			LastCard.SetActive(false);
			Cards.transform.GetChild(5).gameObject.SetActive(true);
			LastCard = Cards.transform.GetChild(5).gameObject;
			selectedUnit = "warrior";
            FindObjectOfType<AudioManager>().play("Laser");
        }
	}
	
	
    // Update is called once per frame
    void Update()
    {
       
    }
}
