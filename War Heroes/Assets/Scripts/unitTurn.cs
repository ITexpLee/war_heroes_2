using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;

public class unitTurn : MonoBehaviour
{
    public int id;
    private int camera;
    public int curUnitTurnId;
    public int curEnemyUnitTurnId;
    public List<int> unitsTookTurn;
    public List<GameObject> greenGrid;

    public int enemyInRangeId = 0;
    public int myUnitInEnemyRangeId = 0;
    public List<float> enemyInRangeLocation;
    public List<float> myUnitInEnemyRangeLocation;
    public Text AnnouncementBox;
    public bool isMyTurn = true;
    public string announceContent = "";
    public bool newAnnouncement = false;

    public bool showingGreenGrid;
    // Start is called before the first frame update
    void Start()
    {
        curUnitTurnId = 0;
        curEnemyUnitTurnId = 0;
        unitsTookTurn = new List<int>();
        greenGrid = new List<GameObject>();
        showingGreenGrid = false;

        enemyInRangeLocation = new List<float>();
        myUnitInEnemyRangeLocation = new List<float>();

        enemyInRangeLocation.Add(0);
        enemyInRangeLocation.Add(0);
        myUnitInEnemyRangeLocation.Add(0);
        myUnitInEnemyRangeLocation.Add(0);
        isMyTurn = true;
        pushAnnouncement("Eliminate all enemies!");
    }

    // Update is called once per frame
    void Update()
    {
        if (newAnnouncement == true)
        {
            AnnouncementBox.text = announceContent;
            StartCoroutine(hideAnnounce());

        }
    }

    IEnumerator hideAnnounce()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(2);
        announceContent = "";
        AnnouncementBox.text = "";
        newAnnouncement = false;
    }
    public void takeTurn()
    {
        unitsTookTurn.Add(curUnitTurnId);
        curUnitTurnId = 0;
    }


    public float minDistanceToAllEnemies(bool myTurn = true)
    {
        float minDis = 1231231231;
        //template
        var uX = GameObject.FindGameObjectWithTag("1").GetComponent<UnitScript>().transform.position.x;
        var uY = GameObject.FindGameObjectWithTag("1").GetComponent<UnitScript>().transform.position.y;
        if (myTurn == true)
        {
            uX = GameObject.FindGameObjectWithTag(curUnitTurnId.ToString()).GetComponent<UnitScript>().transform.position.x;
            uY = GameObject.FindGameObjectWithTag(curUnitTurnId.ToString()).GetComponent<UnitScript>().transform.position.y;

            for (int i = 5; i <= 8; i++)
            {
                var enemyPos = GameObject.FindGameObjectWithTag(i.ToString()).GetComponent<UnitScript>().transform.position;
                var dis = distanceToEnemy(uX, uY, enemyPos.x, enemyPos.y);
                if (dis < minDis)
                {
                    minDis = dis;
                    enemyInRangeId = i;
                }
            }
        }
        else
        {
            uX = GameObject.FindGameObjectWithTag(curEnemyUnitTurnId.ToString()).GetComponent<UnitScript>().transform.position.x;
            uY = GameObject.FindGameObjectWithTag(curEnemyUnitTurnId.ToString()).GetComponent<UnitScript>().transform.position.y;

            for (int i = 1; i <= 4; i++)
            {
                //print("i+" + i);
                if (GameObject.Find("ros" + (i).ToString()) != null)
                {
                    var myUnitPos = GameObject.FindGameObjectWithTag(i.ToString()).GetComponent<UnitScript>().transform.position;
                    var dis = distanceToEnemy(uX, uY, myUnitPos.x, myUnitPos.y);
                    if (dis < minDis)
                    {
                        minDis = dis;
                        myUnitInEnemyRangeId = i;
                    }
                }
            }
        }
        
        return minDis;
    }

    public float distanceToEnemy(float uX, float uY, float oX, float oY)
    {
        return Mathf.Sqrt(Mathf.Pow((uX - oX), 2) + Mathf.Pow((uY - oY), 2));
    }

    public void engageBattle(bool isMyAttack = true)
    {
        print("engaging in battle");
        //doSpecialAttack(units[playerTurn].GetComponent<Unit>().name);
        var attckCount = 0;
        var defendCount = 0;
        var hitScore = 0;
        if (isMyAttack == false)
        {

        }

        //template
        var a = GameObject.FindGameObjectWithTag(curUnitTurnId.ToString()).GetComponent<UnitScript>().attack; //attk
        var b = GameObject.FindGameObjectWithTag(enemyInRangeId.ToString()).GetComponent<UnitScript>().defense; //defend

        //attack
        if (isMyAttack)
        {
            a = GameObject.FindGameObjectWithTag(curUnitTurnId.ToString()).GetComponent<UnitScript>().attack;
            b = GameObject.FindGameObjectWithTag(enemyInRangeId.ToString()).GetComponent<UnitScript>().defense;

            //units[globI].GetComponent<Unit>().attack_anim();
            //enemyUnits[globEI].GetComponent<Unit>().defend_anim();
        }
        else
        {
            //a = enemyUnits[playerEnemyTurn].GetComponent<Unit>().Attack;
            //b = units[randI].GetComponent<Unit>().Defense;

            //enemyUnits[playerEnemyTurn].GetComponent<Unit>().attack_anim();
            //units[randI].GetComponent<Unit>().defend_anim();
        }

        for (int j = 0; j < a; j++)
        {
            if (Random.Range(0.0f, 10.0f) > 5f)
            {
                attckCount = attckCount + 1;
            }
        }
        //defend
        for (int j = 0; j < b; j++)
        {
            if (Random.Range(0.0f, 10.0f) > 5f)
            {
                defendCount = defendCount + 1;
            }
        }

        //score
        if (attckCount >= defendCount)
        {
            hitScore = attckCount - defendCount;
            print("hit score" + hitScore);
        }

        //hit damage
        if (isMyAttack)
        {
            pushAnnouncement("You did " + hitScore + " damage!");
            GameObject.FindGameObjectWithTag(enemyInRangeId.ToString()).GetComponent<UnitScript>().health = GameObject.FindGameObjectWithTag(enemyInRangeId.ToString()).GetComponent<UnitScript>().health - hitScore;
        }
        else
        {
            /**
            if (units[randI].GetComponent<Unit>().DeathStatus == false)
            {
                pushAnnouncement("You lost " + hitScore + " health!");
            }
            **/
            pushAnnouncement("You lost " + hitScore + " health!");
            GameObject.FindGameObjectWithTag(curUnitTurnId.ToString()).GetComponent<UnitScript>().health = GameObject.FindGameObjectWithTag(curUnitTurnId.ToString()).GetComponent<UnitScript>().health - hitScore;
        }

    }

    public void pushAnnouncement(string announce)
    {
        announceContent = announce;
        newAnnouncement = true;
    }

    public void moveEnemyUnit(int id)
    {
        //move to enemy unit
        var enemyUnitLocation = GameObject.FindGameObjectWithTag(id.ToString());
        if (GameObject.Find("Grid").GetComponent<unitTurn>().minDistanceToAllEnemies(false) < GameObject.FindGameObjectWithTag(id.ToString()).GetComponent<UnitScript>().range)
        {
            GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[0] = GameObject.FindGameObjectWithTag(GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeId.ToString()).GetComponent<UnitScript>().transform.position.x;
            GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[1] = GameObject.FindGameObjectWithTag(GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeId.ToString()).GetComponent<UnitScript>().transform.position.y;
        }
        else
        {
            var xAdd = Random.Range(-100, 100);
            var yAdd = Random.Range(-100, 100);
            GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[0] = GameObject.FindGameObjectWithTag(id.ToString()).GetComponent<UnitScript>().transform.position.x + xAdd;
            GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[1] = GameObject.FindGameObjectWithTag(id.ToString()).GetComponent<UnitScript>().transform.position.y + yAdd;
        }
        GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId = id;

    }

}
