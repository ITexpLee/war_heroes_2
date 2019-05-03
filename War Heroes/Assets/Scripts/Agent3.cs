using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Tilemaps;

public class Agent3 : MonoBehaviour
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
        //print("curUnitTurnId+" + GameObject.Find("Canvas").GetComponent<UnitScript>().curUnitTurnId);

        if (Input.GetMouseButtonDown(0) && +GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId == 3)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            print("Somethings in it");
            if (hit && hit.collider.tag == "detector")
            {
                if (this.gameObject.tag == "3")
                {
                    var point = GameObject.Find("Tilemap").GetComponent<Tilemap>().WorldToCell(hit.point);
                    var point2 = GameObject.Find("Tilemap").GetComponent<Tilemap>().CellToWorld(point);
                    var point3 = new Vector3(point2.x + 0.16f, point2.y + 0.16f, point2.z);
                    //print("hit" + hit.point);
                    //print("point2" + point3);
                    //print("agent" + agent.agentTypeID);
                    agent.SetDestination(point3);
                    //unit turn done
                    GameObject.Find("Grid").GetComponent<unitTurn>().takeTurn();
                    //GameObject.Find("Grid").GetComponent<unitTurn>().unitsTookTurn.Add(GameObject.Find("Grid").GetComponent<unitTurn>().curUnitTurnId);
                }
            }
        }
    }
}
