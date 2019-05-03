using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System;

public class UnitSelection : MonoBehaviour
{
    
    public int nCash = 20;
    private List<GameObject> Selecteditems = new List<GameObject>();
    public GameObject[] games;
    private Sprite img;
    public GameObject roster1;
    public int[] cost = { 10, 20, 5 };
    public GameObject roster2;
    public GameObject roster3;
    public GameObject roster4;
    public GameObject roster5;
    public GameObject roster6;
    private GameObject infoTransfer;
    public GameObject nCoins;

    private void Start()
    {
	    infoTransfer = GameObject.Find("InfoTransfer");       
    }
    private void Update()
    {
        //print(nCash);
    }
    private void Use(string name)
    {
        foreach (var item in Selecteditems)
        {
            if (item.name == name)
            {
                if (GameObject.Find("ros1").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros1").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros1").GetComponent<Image>().color = Color.white;
                    GameObject.Find("ros1").GetComponent<Animation>().Play("roster select");
                    break;
                }
                else if (GameObject.Find("ros2").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros2").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros2").GetComponent<Image>().color = Color.white;
                    GameObject.Find("ros2").GetComponent<Animation>().Play("roster select");
                    break;
                }
                else if (GameObject.Find("ros3").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros3").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros3").GetComponent<Image>().color = Color.white;
                    GameObject.Find("ros3").GetComponent<Animation>().Play("roster select");
                    break;
                }
                else if (GameObject.Find("ros4").GetComponent<Image>().sprite == null)
                {
                    GameObject.Find("ros4").GetComponent<Image>().sprite = item.GetComponent<SpriteRenderer>().sprite;
                    GameObject.Find("ros4").GetComponent<Image>().color = Color.white;
                    GameObject.Find("ros4").GetComponent<Animation>().Play("roster select");
                    break;
                }
            }
        }
    }
    public void dUse1()
    {
        nCash = Convert.ToInt32(nCoins.GetComponent<Text>().text);
        if (GameObject.Find("ros1").GetComponent<Image>().sprite != null)
        {
            string sprit = GameObject.Find("ros1").GetComponent<Image>().sprite.name;
            print(sprit);
            FindObjectOfType<AudioManager>().play("Sword");
            GameObject.Find("ros1").GetComponent<Image>().sprite = null;
            GameObject.Find("ros1").GetComponent<Image>().color = new Color (255,255,255,0f);
            GameObject.Find("ros1").GetComponent<rosScript>().filled = false;
	        infoTransfer.GetComponent<InfoTransferScript>().Unit1 = "";
            if (sprit == "roster cavalry")
            {
                nCash += 20;
            }
            else if (sprit == "roster thief")
            {
                nCash += 5;
            }
            else
            {
                nCash += 10;
            }
            print(nCash);
            nCoins.GetComponent<Text>().text = nCash.ToString();    
        }
    }
    public void dUse2()
    {
        nCash = Convert.ToInt32(nCoins.GetComponent<Text>().text);
        if (GameObject.Find("ros2").GetComponent<Image>().sprite != null)
        {
            string sprit = GameObject.Find("ros2").GetComponent<Image>().sprite.name;
            FindObjectOfType<AudioManager>().play("Sword");
            GameObject.Find("ros2").GetComponent<Image>().sprite = null;
            GameObject.Find("ros2").GetComponent<Image>().color = new Color (255,255,255,0f);
	        GameObject.Find("ros2").GetComponent<rosScript>().filled = false;
	        infoTransfer.GetComponent<InfoTransferScript>().Unit2 = "";
            if (sprit == "roster cavalry")
            {
                nCash += 20;
            }
            else if (sprit == "roster thief")
            {
                nCash += 5;
            }
            else
            {
                nCash += 10;
            }
            print(nCash);
            nCoins.GetComponent<Text>().text = nCash.ToString();
        }
    }   
    public void dUse3()
    {
        nCash = Convert.ToInt32(nCoins.GetComponent<Text>().text);
        if (GameObject.Find("ros3").GetComponent<Image>().sprite != null)
        {
            string sprit = GameObject.Find("ros3").GetComponent<Image>().sprite.name;
            FindObjectOfType<AudioManager>().play("Sword");
            GameObject.Find("ros3").GetComponent<Image>().sprite = null;
            GameObject.Find("ros3").GetComponent<Image>().color = new Color (255,255,255,0f);
            GameObject.Find("ros3").GetComponent<rosScript>().filled = false;
	        infoTransfer.GetComponent<InfoTransferScript>().Unit3 = "";
            if (sprit == "roster cavalry")
            {
                nCash += 20;
            }
            else if (sprit == "roster thief")
            {
                nCash += 5;
            }
            else
            {
                nCash += 10;
            }
            print(nCash);
            nCoins.GetComponent<Text>().text = nCash.ToString();
        }
    }
    public void dUse4()
    {
        nCash = Convert.ToInt32(nCoins.GetComponent<Text>().text);
        if (GameObject.Find("ros4").GetComponent<Image>().sprite != null)
        {
            string sprit = GameObject.Find("ros4").GetComponent<Image>().sprite.name;
            FindObjectOfType<AudioManager>().play("Sword");
            GameObject.Find("ros4").GetComponent<Image>().sprite = null;
            GameObject.Find("ros4").GetComponent<Image>().color = new Color (255,255,255,0f);
            GameObject.Find("ros4").GetComponent<rosScript>().filled = false;
    	    infoTransfer.GetComponent<InfoTransferScript>().Unit4 = "";
            if (sprit == "roster cavalry")
            {
                nCash += 20;
            }
            else if (sprit == "roster thief")
            {
                nCash += 5;
            }
            else
            {
                nCash += 10;
            }
            print(nCash);
            nCoins.GetComponent<Text>().text = nCash.ToString();
        }
    }

    public void ButtonPlus()
    {
        print(Selecteditems.Count);
        foreach (var items in games)
        {
            if (items.activeSelf == true)
            {
                if (items.name == "Archer")
                {
                    if (nCash >= cost[0])
                    {
                        nCash -= 10;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster1);
                            Use("roster archer");
                            break;
                        }
                    }
                }
                if (items.name == "Cavalry")
                {
                    if (nCash >= cost[1])
                    {
                        nCash -= 20;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster2);
                            Use("roster cavalry");
                            break;
                        }
                    }
                }
                if (items.name == "Sorceress")
                {
                    if (nCash >= cost[0])
                    {
                        nCash -= 10;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster3);
                            Use("roster sorceress");
                            break;
                        }
                    }
                }
                if (items.name == "Thief")
                {
                    if (nCash >= cost[2])
                    {
                        nCash -= 5;
                        if (Selecteditems.Count < 4)
                        {
                            print("something");
                            Selecteditems.Add(roster4);
                            Use("roster thief");
                            break;
                        }
                    }
                }
                if (items.name == "Cleric")
                {
                    if (nCash >= cost[0])
                    {
                        nCash -= 10;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster5);
                            Use("roster cleric");
                            break;
                        }
                    }
                }
                if (items.name == "Warrior")
                {
                    if (nCash >= cost[0])
                    {
                        nCash -= 10;
                        if (Selecteditems.Count < 4)
                        {
                            Selecteditems.Add(roster6);
                            Use("roster warrior");
                            break;
                        }
                    }
                }
            }
        }
    }
    public void Player1()
    {
        foreach(var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[0].active = true;
    }
    public void Player2()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[1].active = true;
    }
    public void Player3()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[2].active = true;
    }
    public void Player4()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[3].active = true;
    }
    public void Player5()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[4].active = true;
    }
    public void Player6()
    {
        foreach (var items in games)
        {
            if (items.activeSelf)
            {
                items.active = false;
                break;
            }
        }
        games[5].active = true;
    }
}
    public class Characters{
        public int defence { get; set; }
        public int attack { get; set; }
        public int range { get; set; }
        public int speed { get; set; }
        public int health { get; set; }
        public int price { get; set; }
        public int units { get; set; }
    }
    public class Archer : Characters
    {
        public Archer()
        {
            defence = 1;
            attack = 3;
            health = 4;
            range = 3;
            speed = 2;
            price = 4;
        }
    }
    public class Cavalry : Characters
    {
        public Cavalry()
        {
            defence = 3;
            attack = 3;
            health = 5;
            range = 1;
            speed = 5;
            price = 6;
        }
    }
    public class Thief : Characters
    {
        public Thief()
        {
            defence = 1;
            attack = 1;
            health = 3;
            range = 2;
            speed = 4;
            price = 4;
        }
    }
    public class Sorceress : Characters
    {
        public Sorceress()
        {
            defence = 1;
            attack = 1;
            health = 3;
            range = 2;
            speed = 2;
            price = 4;
        }
    }
    public class Cleric : Characters
    {
        public Cleric()
        {
            defence = 1;
            attack = 2;
            health = 3;
            range = 1;
            speed = 2;
            price = 4;
        }
    }
    public class Warrior : Characters
    {
        public Warrior()
        {
            defence = 2;
            attack = 3;
            health = 5;
            range = 1;
            speed = 3;
            price = 4;
        }
    }