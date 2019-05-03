using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Carrymoney : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ncoins;
    public int nCash;
    void Start()
    {
        nCash = 0;
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if (ncoins)
        {
            nCash = Convert.ToInt32(ncoins.GetComponent<Text>().text.ToString());
        }
    }
}
