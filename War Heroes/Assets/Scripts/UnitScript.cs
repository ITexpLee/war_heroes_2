using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class UnitScript : MonoBehaviour
{
    public int id;
    public bool upgraded;
    private int camera;
    //attributes
    public int health;
    public int defense;
    public int range;
    public int speed;
    public int attack;
    public int cash;

    //for animation
    int idleHash;
    int walkHash;
    int attackHash;
    int defendHash;
    int powerHash;
    int powerHash_atk;
    int powerHash_def;
    int deadHash;
    RaycastHit hit;

    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        upgraded = false;
        Scene currentScene = SceneManager.GetActiveScene();
        camera = 0;
        if (currentScene.name == "BattleGround")
        {
            GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 0;
            //rangeFinder(1,2);
            GameObject.Find("Player Phase").GetComponent<Animation>().Play("Phase show");
        }

        //testing
        setAttributes();
        agent = GetComponent<NavMeshAgent>();
    }

    public void focus1()
    {

        if (GameObject.FindGameObjectWithTag("1").GetComponent<UnitScript>().id == 1)
        {
            GameObject.Find("Main Camera").transform.position = Vector3.MoveTowards(GameObject.Find("Main Camera").transform.position, new Vector3(GameObject.FindGameObjectWithTag("1").transform.position.x, GameObject.FindGameObjectWithTag("1").transform.position.y,-2), 200);
            if (GameObject.Find("Main Camera").transform.position.x <= -0.16f)
                GameObject.Find("Main Camera").transform.position = new Vector3(-0.16f, GameObject.Find("Main Camera").transform.position.y, -2);
            if (GameObject.Find("Main Camera").transform.position.x >= 2.40f)
                GameObject.Find("Main Camera").transform.position = new Vector3(2.40f, GameObject.Find("Main Camera").transform.position.y, -2);
            if (GameObject.Find("Main Camera").transform.position.y >= 0.28f)
                GameObject.Find("Main Camera").transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, 0.28f, -2);
            if (GameObject.Find("Main Camera").transform.position.y <= -1.88f)
                GameObject.Find("Main Camera").transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, -1.88f, -2);
            if (camera == 1)
            {
                //GameObject.Find("Camera").GetComponent<Animation>().Play("CameraIn");
                if (GameObject.Find("ros1") != null)
                {
                    GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 0;
                    GameObject.Find("ros1").GetComponent<Image>().color = Color.white;
                }
                camera = 0;
            }
            else
            {
                /*
                if (camera == 0)
                {
                    GameObject.Find("Camera").GetComponent<Animation>().Play("CameraOut");
                }
                */
                if (GameObject.Find("ros1") != null)
                {
                    GameObject.Find("ros1").GetComponent<Image>().color = Color.green;
                    GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 1;
                    //takeTurn(curUnitTurnId);
                }
                if (GameObject.Find("ros2") != null)
                    GameObject.Find("ros2").GetComponent<Image>().color = Color.white;
                if (GameObject.Find("ros3") != null)
                    GameObject.Find("ros3").GetComponent<Image>().color = Color.white;
                if (GameObject.Find("ros4") != null)
                    GameObject.Find("ros4").GetComponent<Image>().color = Color.white;
                camera = 1;
            }
        }
    }
    public void focus2()
    {
        if (GameObject.FindGameObjectWithTag("2").GetComponent<UnitScript>().id == 2)
        {
            GameObject.Find("Main Camera").transform.position = Vector3.MoveTowards(GameObject.Find("Main Camera").transform.position, new Vector3(GameObject.FindGameObjectWithTag("2").transform.position.x, GameObject.FindGameObjectWithTag("2").transform.position.y, -2), 200);
            if (GameObject.Find("Main Camera").transform.position.x <= -0.16f)
                GameObject.Find("Main Camera").transform.position = new Vector3(-0.16f, GameObject.Find("Main Camera").transform.position.y, -2);
            if (GameObject.Find("Main Camera").transform.position.x >= 2.40f)
                GameObject.Find("Main Camera").transform.position = new Vector3(2.40f, GameObject.Find("Main Camera").transform.position.y, -2);
            if (GameObject.Find("Main Camera").transform.position.y >= 0.28f)
                GameObject.Find("Main Camera").transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, 0.28f, -2);
            if (GameObject.Find("Main Camera").transform.position.y <= -1.88f)
                GameObject.Find("Main Camera").transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, -1.88f, -2);
            if (camera == 2)
            {
                //GameObject.Find("Camera").GetComponent<Animation>().Play("CameraIn");
                if (GameObject.Find("ros2") != null)
                {
                    GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 0;
                    GameObject.Find("ros2").GetComponent<Image>().color = Color.white;
                }
                camera = 0;
            }
            else
            {
                /*
                if (camera == 0)
                {
                    GameObject.Find("Camera").GetComponent<Animation>().Play("CameraOut");
                }
                */
                if (GameObject.Find("ros1") != null)
                    GameObject.Find("ros1").GetComponent<Image>().color = Color.white;
                if (GameObject.Find("ros2") != null)
                {
                    GameObject.Find("ros2").GetComponent<Image>().color = Color.green;
                    GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 2;
                    //takeTurn(curUnitTurnId);
                }
                if (GameObject.Find("ros3") != null)
                    GameObject.Find("ros3").GetComponent<Image>().color = Color.white;
                if (GameObject.Find("ros4") != null)
                    GameObject.Find("ros4").GetComponent<Image>().color = Color.white;
                camera = 2;
            }
        }
    }
    public void focus3()
    {
        if (GameObject.FindGameObjectWithTag("3").GetComponent<UnitScript>().id == 3)
        {
            GameObject.Find("Main Camera").transform.position = Vector3.MoveTowards(GameObject.Find("Main Camera").transform.position, new Vector3(GameObject.FindGameObjectWithTag("3").transform.position.x, GameObject.FindGameObjectWithTag("3").transform.position.y, -2), 200);
            if (GameObject.Find("Main Camera").transform.position.x <= -0.16f)
                GameObject.Find("Main Camera").transform.position = new Vector3(-0.16f, GameObject.Find("Main Camera").transform.position.y, -2);
            if (GameObject.Find("Main Camera").transform.position.x >= 2.40f)
                GameObject.Find("Main Camera").transform.position = new Vector3(2.40f, GameObject.Find("Main Camera").transform.position.y, -2);
            if (GameObject.Find("Main Camera").transform.position.y >= 0.28f)
                GameObject.Find("Main Camera").transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, 0.28f, -2);
            if (GameObject.Find("Main Camera").transform.position.y <= -1.88f)
                GameObject.Find("Main Camera").transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, -1.88f, -2);
            if (camera == 3)
            {
                //GameObject.Find("Camera").GetComponent<Animation>().Play("CameraIn");
                if (GameObject.Find("ros3") != null)
                {
                    GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 0;
                    GameObject.Find("ros3").GetComponent<Image>().color = Color.white;
                }
                camera = 0;
            }
            else
            {
                /*
                if (camera == 0)
                {
                    GameObject.Find("Camera").GetComponent<Animation>().Play("CameraOut");
                }
                */
                if (GameObject.Find("ros1") != null)
                    GameObject.Find("ros1").GetComponent<Image>().color = Color.white;
                if (GameObject.Find("ros2") != null)
                    GameObject.Find("ros2").GetComponent<Image>().color = Color.white;
                if (GameObject.Find("ros3") != null)
                {
                    GameObject.Find("ros3").GetComponent<Image>().color = Color.green;
                    GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 3;
                    //takeTurn(curUnitTurnId);
                }
                if (GameObject.Find("ros4") != null)
                    GameObject.Find("ros4").GetComponent<Image>().color = Color.white;
                camera = 3;
            }
        }
    }
    public void focus4()
    {
        if (GameObject.FindGameObjectWithTag("4").GetComponent<UnitScript>().id == 4)
        {
            GameObject.Find("Main Camera").transform.position = Vector3.MoveTowards(GameObject.Find("Main Camera").transform.position, new Vector3(GameObject.FindGameObjectWithTag("4").transform.position.x, GameObject.FindGameObjectWithTag("4").transform.position.y, -2), 200);
            if (GameObject.Find("Main Camera").transform.position.x <= -0.16f)
                GameObject.Find("Main Camera").transform.position = new Vector3(-0.16f, GameObject.Find("Main Camera").transform.position.y, -2);
            if (GameObject.Find("Main Camera").transform.position.x >= 2.40f)
                GameObject.Find("Main Camera").transform.position = new Vector3(2.40f, GameObject.Find("Main Camera").transform.position.y, -2);
            if (GameObject.Find("Main Camera").transform.position.y >= 0.28f)
                GameObject.Find("Main Camera").transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, 0.28f, -2);
            if (GameObject.Find("Main Camera").transform.position.y <= -1.88f)
                GameObject.Find("Main Camera").transform.position = new Vector3(GameObject.Find("Main Camera").transform.position.x, -1.88f, -2);
            if (camera == 4)
            {
                //GameObject.Find("Camera").GetComponent<Animation>().Play("CameraIn");
                if (GameObject.Find("ros4") != null)
                {
                    GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 0;
                    GameObject.Find("ros4").GetComponent<Image>().color = Color.white;
                }
                camera = 0;
            }
            else
            {
                /*
                if (camera == 0)
                {
                    GameObject.Find("Camera").GetComponent<Animation>().Play("CameraOut");
                }
                */
                if (GameObject.Find("ros1") != null)
                    GameObject.Find("ros1").GetComponent<Image>().color = Color.white;
                if (GameObject.Find("ros2") != null)
                    GameObject.Find("ros2").GetComponent<Image>().color = Color.white;
                if (GameObject.Find("ros3") != null)
                    GameObject.Find("ros3").GetComponent<Image>().color = Color.white;
                if (GameObject.Find("ros4") != null)
                {
                    GameObject.Find("ros4").GetComponent<Image>().color = Color.green;
                    GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 4;
                    //takeTurn(curUnitTurnId);
                }

                camera = 4;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        disableUnitButtons();
        //rangeFinder(curUnitTurnId, 0);
        //rangeFinder(1, 0);

        //check for click
        if (Input.GetMouseButtonDown(0))
        {
            //empty RaycastHit object which raycast puts the hit details into
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            var a = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, transform.forward);
            //print("hits len" + hits.Length+hits);
            for (int i = 0; i  < hits.Length; i++)
            {
                var ourObject = hits[i];
                //Debug.Log("object that was hit:---------------- " + ourObject.collider.name);
            }
        }

        //print("enemyTurn" + GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId);

        
    }



    void startEnemyTurn()
    {
        print("enemy turn started");
        GameObject.Find("Enemy Phase").GetComponent<Animation>().Play();
        GameObject.Find("Grid").GetComponent<unitTurn>().unitsTookTurn.Clear();
        GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId = 0;
        GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId = 5;
        GameObject.Find("Grid").GetComponent<unitTurn>().isMyTurn = false;

        if (true)
        {
            for (int i = 0; i < 4; i++)
            {
                GameObject.Find("ros" + i).GetComponent<Button>().interactable = true;
            }
        }

        //one by one turn
        /**
        for (int i = 5; i<=8; i++)
        {
            ///focus camera on unit
            print("enemy unit turn");
            GameObject.Find("Main Camera").transform.position = Vector3.MoveTowards(GameObject.Find("Main Camera").transform.position, new Vector3(GameObject.FindGameObjectWithTag(i.ToString()).transform.position.x, GameObject.FindGameObjectWithTag(i.ToString()).transform.position.y, -2), 200);
            GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId = id;
            print("enemyid" + GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId);
            moveEnemyUnit(i);

        }
        **/
        ///GameObject.Find("Grid").GetComponent<unitTurn>().isMyTurn = true;
    }

    void moveEnemyUnit(int id)
    {
        //move to enemy unit
        var enemyUnitLocation = GameObject.FindGameObjectWithTag(id.ToString());
        if (GameObject.Find("Grid").GetComponent<unitTurn>().minDistanceToAllEnemies(false) < GameObject.FindGameObjectWithTag(id.ToString()).GetComponent<UnitScript>().range)
        {
            GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[0]=  GameObject.FindGameObjectWithTag(GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeId.ToString()).GetComponent<UnitScript>().transform.position.x;
            GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[1]=  GameObject.FindGameObjectWithTag(GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeId.ToString()).GetComponent<UnitScript>().transform.position.y;
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

    void disableUnitButtons()
    {
        if (GameObject.Find("Grid")) {
            for(int i=0; i< GameObject.Find("Grid").GetComponent<unitTurn>().unitsTookTurn.Count; i++)
            {
                GameObject.Find("ros" + GameObject.Find("Grid").GetComponent<unitTurn>().unitsTookTurn[i].ToString()).GetComponent<Button>().interactable = false;
            }
            var unitsBought = 0;
            for (int i = 0; i <= 4; i++)
            {
                if(GameObject.Find("ros" + (i+1).ToString()) != null)
                {
                    unitsBought += 1;
                }
            }
            if (GameObject.Find("Grid").GetComponent<unitTurn>().unitsTookTurn.Count == unitsBought)
            {
                startEnemyTurn();
            }
        }

        if (GameObject.Find("Grid").GetComponent<unitTurn>().isMyTurn == false)
        {
            for (int i = 0; i < 4; i++)
            {
                GameObject.Find("ros" + i).GetComponent<Button>().interactable = true;
            }
        }
        

        /*
        int rangeFinder(int id, int steps)
        {
            if (id != 0)
            {
                
                var playerPos = GameObject.FindGameObjectWithTag(id.ToString()).transform.position;
                print("playerPos----" + playerPos);
                //var tile = (Tile)GameObject.Find("Tilemap").GetComponent<Tilemap>().GetTile(new Vector3Int(System.Convert.ToInt32(playerPos.x), System.Convert.ToInt32(playerPos.y), 0));
                var tile = (Tile)GameObject.Find("Tilemap").GetComponent<Tilemap>().GetTile(new Vector3Int(System.Convert.ToInt32(5), System.Convert.ToInt32(5), 0));
            
                print("tile----"+ tile);
                tile.color = Color.green;

                for (int i = 0; i < 200; i++)
                {
                    for (int j = 0; j < 200; j++)
                    {
                        tile = (Tile)GameObject.Find("Tilemap").GetComponent<Tilemap>().GetTile(new Vector3Int(System.Convert.ToInt32(i), System.Convert.ToInt32(j), 0));
                        tile.color = Color.green;
                    }
                }
                
            }
            //return 1;
        }
        */
    }

    void setAttributes()
    {
        var unitName = gameObject.name;

        if (unitName == "Archer(Clone)")
        {
            print("archer detected");
            health = 2;
            defense = 5;
            range = 100;
            speed = 500;
            attack = 4;
            walkHash = Animator.StringToHash("walk_archer");
            attackHash = Animator.StringToHash("attack_archer");
            idleHash = Animator.StringToHash("idle_archer");
            defendHash = Animator.StringToHash("defend_archer");
            powerHash = Animator.StringToHash("power_archer");
            deadHash = Animator.StringToHash("dead_archer");
        }
        else if (unitName == "Cleric(Clone)")
        {
            print("cleric detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 360;
            attack = 12;
            walkHash = Animator.StringToHash("walk_cleric");
            attackHash = Animator.StringToHash("attack_cleric");
            idleHash = Animator.StringToHash("idle_cleric");
            defendHash = Animator.StringToHash("defend_cleric");
            powerHash = Animator.StringToHash("power_cleric");
            deadHash = Animator.StringToHash("dead_cleric");
        }
        else if (unitName == "Warrior(Clone)")
        {
            print("warrior detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 500;
            attack = 12;
            walkHash = Animator.StringToHash("walk_warrior");
            attackHash = Animator.StringToHash("attack_warrior");
            idleHash = Animator.StringToHash("idle_warrior");
            defendHash = Animator.StringToHash("defend_warrior");
            powerHash = Animator.StringToHash("power_warrior");
            deadHash = Animator.StringToHash("dead_warrior");

        }
        else if (unitName == "Cavalry(Clone)")
        {
            print("Calvary detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 360;
            attack = 12;
            walkHash = Animator.StringToHash("walk_calvary");
            attackHash = Animator.StringToHash("attack_calvary");
            idleHash = Animator.StringToHash("idle_calvary");
            defendHash = Animator.StringToHash("defend_calvary");
            powerHash = Animator.StringToHash("power_calvary");
            deadHash = Animator.StringToHash("dead_calvary");

        }
        else if (unitName == "Sorceress(Clone)")
        {
            print("Soceress detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 260;
            attack = 12;
            walkHash = Animator.StringToHash("walk_soceress");
            attackHash = Animator.StringToHash("attack_soceress");
            idleHash = Animator.StringToHash("idle_soceress");
            defendHash = Animator.StringToHash("defend_soceress");
            powerHash_atk = Animator.StringToHash("power_atk_soceress");
            powerHash_def = Animator.StringToHash("power_def_soceress");

        }
        else if (unitName == "Thief(Clone)")
        {
            print("Thief detected");
            health = 2;
            defense = 2;
            range = 102;
            speed = 400;
            attack = 12;
            walkHash = Animator.StringToHash("walk_thief");
            attackHash = Animator.StringToHash("attack_thief");
            idleHash = Animator.StringToHash("idle_thief");
            defendHash = Animator.StringToHash("defend_thief");
            powerHash = Animator.StringToHash("power_thief");
            deadHash = Animator.StringToHash("dead_thief");
        }
    }

}