using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MarketSet : MonoBehaviour
{
    
    // Start is called before the first frame update
    public Button market;
    public GameObject money;
    void Start()
    {
        //print(market.gameObject.active);
        market.gameObject.active = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Somethings"+collision.gameObject.tag);
        if (collision.gameObject.tag == "1" || collision.gameObject.tag == "2" || collision.gameObject.tag == "3" || collision.gameObject.tag == "4" || collision.gameObject.tag == "5" || collision.gameObject.tag == "6")
        {
            print("Hey hey hey 1 2 3 " + collision.gameObject.name);
            market.gameObject.active = true;
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.AddListener(() => Upgrade(collision.gameObject.tag));
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "1" || collision.gameObject.tag == "2" || collision.gameObject.tag == "3" || collision.gameObject.tag == "4" || collision.gameObject.tag == "5" || collision.gameObject.tag == "6")
        {
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
            market.gameObject.active = false;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Upgrade(string name)
    {
        var item = GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>();
        var moneys = Convert.ToInt32(money.GetComponent<Text>().text);
        print(moneys);
        if (item.upgraded == true)
        {
            print("ALready upgraded");
            GameObject.Find("Grid").GetComponent<unitTurn>().pushAnnouncement("Already Upgraded");
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
            market.gameObject.active = false;
        }
        else if (moneys < 10)
        {
            print("Not enough Money");
            GameObject.Find("Grid").GetComponent<unitTurn>().pushAnnouncement("Not Enough Money");
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
            market.gameObject.active = false;
        }
        else if (item.name=="Archer(Clone)" && item.upgraded==false && moneys>=10)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().defense += 1;
            GameObject.Find("Grid").GetComponent<unitTurn>().pushAnnouncement("Item Upgraded");
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
            market.gameObject.active = false;
        }
        else if (item.name == "Warrior(Clone)" && item.upgraded==false && moneys >= 10)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().attack += 2;
            GameObject.Find("Grid").GetComponent<unitTurn>().pushAnnouncement("Item Upgraded");
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
            market.gameObject.active = false;
        }
        else if (item.name == "Thief(Clone)" && item.upgraded == false && moneys >= 10)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().defense += 1;
            GameObject.Find("Grid").GetComponent<unitTurn>().pushAnnouncement("Item Upgraded");
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
            market.gameObject.active = false;
        }
        else if (item.name == "Sorceress(Clone)" && item.upgraded == false && moneys >= 10)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().range += 2;
            GameObject.Find("Grid").GetComponent<unitTurn>().pushAnnouncement("Item Upgraded");
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
            market.gameObject.active = false;
        }
        else if (item.name == "Cleric(Clone)" && item.upgraded == false && moneys >= 10)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().range += 2;
            GameObject.Find("Grid").GetComponent<unitTurn>().pushAnnouncement("Item Upgraded");
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
            market.gameObject.active = false;
        }
        else if (item.name == "Cavalry(Clone)" && item.upgraded == false && moneys >= 10)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().attack += 1;
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().defense += 1;
            GameObject.Find("Grid").GetComponent<unitTurn>().pushAnnouncement("Item Upgraded");
            GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
            market.gameObject.active = false;
        }
    }
   
}
