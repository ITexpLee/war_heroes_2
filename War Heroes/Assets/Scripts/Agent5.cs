using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Tilemaps;

public class Agent5 : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //print("curUnitTurnId+"+GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId);
        //print("Agent 1");
        if (GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId==5 && GameObject.Find("Grid").GetComponent<unitTurn>().isMyTurn==false)
        {
            GameObject.Find("Main Camera").transform.position = Vector3.MoveTowards(GameObject.Find("Main Camera").transform.position, new Vector3(GameObject.FindGameObjectWithTag(GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId.ToString()).transform.position.x, GameObject.FindGameObjectWithTag(GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId.ToString()).transform.position.y, -2), 200);

            var myLocation = new Vector3Int((int)GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[0], (int)GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[1], 1);
                    var point = GameObject.Find("Tilemap").GetComponent<Tilemap>().WorldToCell(myLocation);
                    var point2 = GameObject.Find("Tilemap").GetComponent<Tilemap>().CellToWorld(point);
                    var point3 = new Vector3(point2.x + 0.16f, point2.y + 0.16f, point2.z);
                    agent.SetDestination(point3);
                GameObject.Find("Grid").GetComponent<unitTurn>().moveEnemyUnit(6);
                GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId = 6;
            print("changed to 6" + GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId);
                    //unit turn done
                    //GameObject.Find("Grid").GetComponent<unitTurn>().unitsTookTurn.Add(GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId);
        }
    }

    bool hitGreenArea()
    {
        /**
        //empty RaycastHit object which raycast puts the hit details into
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        var a = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        RaycastHit2D[] hits = Physics2D.RaycastAll(a, transform.forward);
        for (int i = 0; i <= hits.Length; i++)
        {
            var ourObject = hits[i];
            if (ourObject.collider.name.Contains("Detector"))
            {
                // Do Something // 
                Debug.Log("object that was hit:---------------- " + ourObject.collider.name);
                return true;
            }
        }
        return false;
        **/
        return true;
    }
}
