using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moneyupdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Text>().text=GameObject.Find("carymoney").GetComponent<Carrymoney>().nCash.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
