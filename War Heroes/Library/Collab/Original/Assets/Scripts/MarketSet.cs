using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MarketSet : MonoBehaviour
{
    // Start is called before the first frame update
    public Button market;
    void Start()
    {
        print(market.gameObject.active);
        market.gameObject.active = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("Hey hey hey 1 2 3 "+ collision.gameObject.name);
        market.gameObject.active = true;
        GameObject.Find("Upgrade").GetComponent<Button>().onClick.AddListener(() => Upgrade(collision.gameObject.tag));
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        GameObject.Find("Upgrade").GetComponent<Button>().onClick.RemoveAllListeners();
        market.gameObject.active = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void Upgrade(string name)
    {
        var item = GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>();
        if (item.upgraded == true)
        {
            print("ALready upgraded");
        }
        if (item.name=="Archer(Clone)" && item.upgraded==false)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().defense += 1;
        }
        if (item.name == "Warrior(Clone)" && item.upgraded==false)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().attack += 2;
        }
        if (item.name == "Thief(Clone)" && item.upgraded == false)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().defense += 1;
        }
        if (item.name == "Sorceress(Clone)" && item.upgraded == false)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().range += 2;
        }
        if (item.name == "Cleric(Clone)" && item.upgraded == false)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().range += 2;
        }
        if (item.name == "Cavalry(Clone)" && item.upgraded == false)
        {
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().attack += 1;
            GameObject.FindGameObjectWithTag(name).GetComponent<UnitScript>().defense += 1;
        }
    }
}
