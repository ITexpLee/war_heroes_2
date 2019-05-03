using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    public GameObject Slots;
    private GameObject InfoTransfer;

    // Start is called before the first frame update
    public void OpenBattleGround()
    {
        if (Slots)
        {
            if (Slots.transform.GetChild(1).gameObject.GetComponent<rosScript>().filled)
            {
                InfoTransfer.GetComponent<InfoTransferScript>().BattleG = true;
                if (GameObject.Find("ros1").GetComponent<Image>().sprite == null)
                {
                    Destroy(GameObject.Find("ros1"));
                }
                if (GameObject.Find("ros2").GetComponent<Image>().sprite == null)
                {
                    Destroy(GameObject.Find("ros2"));
                }
                if (GameObject.Find("ros3").GetComponent<Image>().sprite == null)
                {
                    Destroy(GameObject.Find("ros3"));
                }
                if (GameObject.Find("ros4").GetComponent<Image>().sprite == null)
                {
                    Destroy(GameObject.Find("ros4"));
                }
                SceneManager.LoadScene("BattleGround");
            }
        }
    }
    public void OpenMainMenu()
    {
        FindObjectOfType<AudioManager>().play("Select");
        SceneManager.LoadScene("Menu");
    }
    public void OpenSelectionMenu()
    {
        FindObjectOfType<AudioManager>().play("Select");
        SceneManager.LoadScene("UnitSelectMenu");
    }

    void Update()
    {
	InfoTransfer = GameObject.Find("InfoTransfer");


    }
}
