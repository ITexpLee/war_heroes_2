using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthbar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject follow;
    public GameObject Unit;
    private int health;
    void Start()
    {
        health= Unit.GetComponent<UnitScript>().health;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(follow.transform.position.x, follow.transform.position.y+0.181f, follow.transform.position.z);
        transform.localScale = new Vector3((Unit.GetComponent<UnitScript>().health/health) * transform.localScale.x,transform.localScale.y,transform.localScale.z);
    }
}
