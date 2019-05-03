using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerSpawnerScript : MonoBehaviour
{
    private GameObject InfoTransfer;
	public GameObject Archer;
	public GameObject Warrior;
	public GameObject Cavalry;
	public GameObject Cleric;
	public GameObject Sorceress;
	public GameObject Thief;
    public int id;
	
    void Start()
    {
		InfoTransfer = GameObject.Find("InfoTransfer");
		
		//spawn unit1
		if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit1 == "roster archer" )
		{
			Debug.Log("InstatntiatedArcher");
			GameObject archer = Instantiate(Archer);
			archer.transform.position = new Vector3(-1.440559f, -0.1595188f, -1f);
            archer.GetComponent<UnitScript>().id = 1;
            archer.gameObject.tag= "1";
            foreach (Transform t in archer.transform)
            {
                t.gameObject.tag = "1";
            }
        }
		else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit1 == "roster warrior" )
		{
			Debug.Log("Instatntiatedwarr");
			GameObject warrior = Instantiate(Warrior);
			warrior.transform.position = new Vector3(-1.440559f, -0.1595188f, -1f);
            warrior.GetComponent<UnitScript>().id = 1;
            warrior.gameObject.tag = "1";
            foreach (Transform t in warrior.transform)
            {
                t.gameObject.tag = "1";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit1 == "roster cleric" )
		{
			Debug.Log("Instatntiatedcler");
			GameObject cleric = Instantiate(Cleric);
			cleric.transform.position = new Vector3(-1.440559f, -0.1595188f, -1f);
            cleric.GetComponent<UnitScript>().id = 1;
            cleric.gameObject.tag = "1";
            foreach (Transform t in cleric.transform)
            {
                t.gameObject.tag = "1";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit1 == "roster sorceress" )
		{
			Debug.Log("Instatntiatedsorc");
			GameObject sorceress = Instantiate(Sorceress);
			sorceress.transform.position = new Vector3(-1.440559f, -0.1595188f, -1f);
            sorceress.GetComponent<UnitScript>().id = 1;
            sorceress.gameObject.tag = "1";
            foreach (Transform t in sorceress.transform)
            {
                t.gameObject.tag = "1";
            }
        }		
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit1 == "roster thief" )
		{
			Debug.Log("Instatntiatedtgeuf");
			GameObject thief = Instantiate(Thief);
			thief.transform.position = new Vector3(-1.440559f, -0.1595188f, -1f);
            thief.GetComponent<UnitScript>().id = 1;
            thief.gameObject.tag = "1";
            foreach (Transform t in thief.transform)
            {
                t.gameObject.tag = "1";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit1 == "roster cavalry" )
		{
			Debug.Log("Instatntiatedcava");
			GameObject cavalry = Instantiate(Cavalry);
			cavalry.transform.position = new Vector3(-1.440559f, -0.1595188f, -1f);
            cavalry.GetComponent<UnitScript>().id = 1;
            cavalry.gameObject.tag = "1";
            foreach (Transform t in cavalry.transform)
            {
                t.gameObject.tag = "1";
            }
        }	
		
		//spawn unit2
		if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit2 == "roster archer" )
		{
			Debug.Log("InstatntiatedArcher");
			GameObject archer = Instantiate(Archer);
			archer.transform.position = new Vector3(-1.120559f, -0.1595188f, -1f);
            archer.GetComponent<UnitScript>().id = 2;
            archer.gameObject.tag = "2";
            foreach (Transform t in archer.transform)
            {
                t.gameObject.tag = "2";
            }
        }
		else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit2 == "roster warrior" )
		{
			Debug.Log("Instatntiatedwarr");
			GameObject warrior = Instantiate(Warrior);
			warrior.transform.position = new Vector3(-1.120559f, -0.1595188f, -1f);
            warrior.GetComponent<UnitScript>().id = 2;
            warrior.gameObject.tag = "2";
            foreach (Transform t in warrior.transform)
            {
                t.gameObject.tag = "2";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit2 == "roster cleric" )
		{
			Debug.Log("Instatntiatedcler");
			GameObject cleric = Instantiate(Cleric);
			cleric.transform.position = new Vector3(-1.120559f, -0.1595188f, -1f);
            cleric.GetComponent<UnitScript>().id = 2;
            cleric.gameObject.tag = "2";
            foreach (Transform t in cleric.transform)
            {
                t.gameObject.tag = "2";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit2 == "roster sorceress" )
		{
			Debug.Log("Instatntiatedsorc");
			GameObject sorceress = Instantiate(Sorceress);
			sorceress.transform.position = new Vector3(-1.120559f, -0.1595188f, -1f);
            sorceress.GetComponent<UnitScript>().id = 2;
            sorceress.gameObject.tag = "2";
            foreach (Transform t in sorceress.transform)
            {
                t.gameObject.tag = "2";
            }
        }		
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit2 == "roster thief" )
		{
			Debug.Log("Instatntiatedtgeuf");
			GameObject thief = Instantiate(Thief);
			thief.transform.position = new Vector3(-1.120559f, -0.1595188f, -1f);
            thief.GetComponent<UnitScript>().id = 2;
            thief.gameObject.tag = "2";
            foreach (Transform t in thief.transform)
            {
                t.gameObject.tag = "2";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit2 == "roster cavalry" )
		{
			Debug.Log("Instatntiatedcava");
			GameObject cavalry = Instantiate(Cavalry);
			cavalry.transform.position = new Vector3(-1.120559f, -0.1595188f, -1f);
            cavalry.GetComponent<UnitScript>().id = 2;
            cavalry.gameObject.tag = "2";
            foreach (Transform t in cavalry.transform)
            {
                t.gameObject.tag = "2";
            }
        }	
		
		//spawn unit3
		if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit3 == "roster archer" )
		{
			Debug.Log("InstatntiatedArcher");
			GameObject archer = Instantiate(Archer);
			archer.transform.position = new Vector3(-0.8005594f, -0.1595188f, -1f);
            archer.GetComponent<UnitScript>().id = 3;
            archer.gameObject.tag = "3";
            foreach (Transform t in archer.transform)
            {
                t.gameObject.tag = "3";
            }
        }
		else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit3 == "roster warrior" )
		{
			Debug.Log("Instatntiatedwarr");
			GameObject warrior = Instantiate(Warrior);
			warrior.transform.position = new Vector3(-0.8005594f, -0.1595188f, -1f);
            warrior.GetComponent<UnitScript>().id = 3;
            warrior.gameObject.tag = "3";
            foreach (Transform t in warrior.transform)
            {
                t.gameObject.tag = "3";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit3 == "roster cleric" )
		{
			Debug.Log("Instatntiatedcler");
			GameObject cleric = Instantiate(Cleric);
			cleric.transform.position = new Vector3(-0.8005594f, -0.1595188f, -1f);
            cleric.GetComponent<UnitScript>().id = 3;
            cleric.gameObject.tag = "3";
            foreach (Transform t in cleric.transform)
            {
                t.gameObject.tag = "3";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit3 == "roster sorceress" )
		{
			Debug.Log("Instatntiatedsorc");
			GameObject sorceress = Instantiate(Sorceress);
			sorceress.transform.position = new Vector3(-0.8005594f, -0.1595188f, -1f);
            sorceress.GetComponent<UnitScript>().id = 3;
            sorceress.gameObject.tag = "3";
            foreach (Transform t in sorceress.transform)
            {
                t.gameObject.tag = "3";
            }
        }		
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit3 == "roster thief" )
		{
			Debug.Log("Instatntiatedtgeuf");
			GameObject thief = Instantiate(Thief);
			thief.transform.position = new Vector3(-0.8005594f, -0.1595188f, -1f);
            thief.GetComponent<UnitScript>().id = 3;
            thief.gameObject.tag = "3";
            foreach (Transform t in thief.transform)
            {
                t.gameObject.tag = "3";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit3 == "roster cavalry" )
		{
			Debug.Log("Instatntiatedcava");
			GameObject cavalry = Instantiate(Cavalry);
			cavalry.transform.position = new Vector3(-0.8005594f, -0.1595188f, -1f);
            cavalry.GetComponent<UnitScript>().id = 3;
            cavalry.gameObject.tag = "3";
            foreach (Transform t in cavalry.transform)
            {
                t.gameObject.tag = "3";
            }
        }	
		
		//spawn unit4
		if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit4 == "roster archer" )
		{
			Debug.Log("InstatntiatedArcher");
			GameObject archer = Instantiate(Archer);
			archer.transform.position = new Vector3(-0.4805594f, -0.1595188f, -1f);
            archer.GetComponent<UnitScript>().id = 4;
            archer.gameObject.tag = "4";
            foreach (Transform t in archer.transform)
            {
                t.gameObject.tag = "4";
            }
        }
		else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit4 == "roster warrior" )
		{
			Debug.Log("Instatntiatedwarr");
			GameObject warrior = Instantiate(Warrior);
			warrior.transform.position = new Vector3(-0.4805594f, -0.1595188f, -1f);
            warrior.GetComponent<UnitScript>().id = 4;
            warrior.gameObject.tag = "4";
            foreach (Transform t in warrior.transform)
            {
                t.gameObject.tag = "4";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit4 == "roster cleric" )
		{
			Debug.Log("Instatntiatedcler");
			GameObject cleric = Instantiate(Cleric);
			cleric.transform.position = new Vector3(-0.4805594f, -0.1595188f, -1f);
            cleric.GetComponent<UnitScript>().id = 4;
            cleric.gameObject.tag = "4";
            foreach (Transform t in cleric.transform)
            {
                t.gameObject.tag = "4";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit4 == "roster sorceress" )
		{
			Debug.Log("Instatntiatedsorc");
			GameObject sorceress = Instantiate(Sorceress);
			sorceress.transform.position = new Vector3(-0.4805594f, -0.1595188f, -1f);
            sorceress.GetComponent<UnitScript>().id = 4;
            sorceress.gameObject.tag = "4";
            foreach (Transform t in sorceress.transform)
            {
                t.gameObject.tag = "4";
            }
        }		
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit4 == "roster thief" )
		{
			Debug.Log("Instatntiatedtgeuf");
			GameObject thief = Instantiate(Thief);
			thief.transform.position = new Vector3(-0.4805594f, -0.1595188f, -1f);
            thief.GetComponent<UnitScript>().id = 4;
            thief.gameObject.tag = "4";
            foreach (Transform t in thief.transform)
            {
                t.gameObject.tag = "4";
            }
        }	
	    else if ( InfoTransfer.GetComponent<InfoTransferScript>().Unit4 == "roster cavalry" )
		{
			Debug.Log("Instatntiatedcava");
			GameObject cavalry = Instantiate(Cavalry);
			cavalry.transform.position = new Vector3(-0.4805594f, -0.1595188f, -1f);
            cavalry.GetComponent<UnitScript>().id = 4;
            cavalry.gameObject.tag = "4";
            foreach (Transform t in cavalry.transform)
            {
                t.gameObject.tag = "4";
            }
        }

        //placing enemy

        Debug.Log("InstatntiatedcavaEnemy");
        GameObject cavalryEnemy = Instantiate(Cavalry);
        cavalryEnemy.GetComponent<Renderer>().material.color = new Color(0.0313f, 0.8431f, 1, 1);
        cavalryEnemy.transform.position = new Vector3(3.045f, -2.373f, -1f);
        cavalryEnemy.GetComponent<UnitScript>().id = 5;
        cavalryEnemy.gameObject.tag = "5";

        Debug.Log("InstatntiatedArcherEnemy");
        GameObject archerEnemy = Instantiate(Archer);
        archerEnemy.GetComponent<Renderer>().material.color = new Color(0.0313f, 0.8431f, 1, 1);
        archerEnemy.transform.position = new Vector3(3.045f, -2.053f, -1f);
        archerEnemy.GetComponent<UnitScript>().id = 6;
        archerEnemy.gameObject.tag = "6";

        Debug.Log("InstatntiatedwarrEnemy");
        GameObject warriorEnemy = Instantiate(Warrior);
        warriorEnemy.GetComponent<Renderer>().material.color = new Color(0.0313f, 0.8431f, 1, 1);
        warriorEnemy.transform.position = new Vector3(2.727f, -2.373f, -1f);
        warriorEnemy.GetComponent<UnitScript>().id = 7;
        warriorEnemy.gameObject.tag = "7";

        Debug.Log("InstatntiatedclerEnemy");
        GameObject clericEnemy = Instantiate(Cleric);
        clericEnemy.GetComponent<Renderer>().material.color = new Color(0.0313f,0.8431f,1,1);
        clericEnemy.transform.position = new Vector3(2.727f, -2.053f, -1f);
        clericEnemy.GetComponent<UnitScript>().id = 8;
        clericEnemy.gameObject.tag = "8";
    }
    
    // Update is called once per frame
    void Update()
    {
        
	}

}
