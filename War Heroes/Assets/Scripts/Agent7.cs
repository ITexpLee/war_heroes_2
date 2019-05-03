using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Tilemaps;

public class Agent7 : MonoBehaviour
{
    // Start is called before the first frame update
    private NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        //print("curUnitTurnId+"+GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId);
        //print("Agent 1");
        if (GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId == 7)
        {
            var myLocation = new Vector3Int((int)GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[0], (int)GameObject.Find("Grid").GetComponent<unitTurn>().myUnitInEnemyRangeLocation[1], 1);
            var point = GameObject.Find("Tilemap").GetComponent<Tilemap>().WorldToCell(myLocation);
            var point2 = GameObject.Find("Tilemap").GetComponent<Tilemap>().CellToWorld(point);
            var point3 = new Vector3(point2.x + 0.16f, point2.y + 0.16f, point2.z);
            agent.SetDestination(point3);
            GameObject.Find("Grid").GetComponent<unitTurn>().moveEnemyUnit(8);
            GameObject.Find("Grid").GetComponent<unitTurn>().curEnemyUnitTurnId = 8;
            //unit turn done
            //GameObject.Find("Grid").GetComponent<unitTurn>().unitsTookTurn.Add(GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId);
        }
    }
}
