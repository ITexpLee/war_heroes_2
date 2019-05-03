using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spritefollower : MonoBehaviour
{
    public Transform target;
    public float zoffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        transform.localPosition = new Vector3(target.localPosition.x,target.localPosition.y,transform.localPosition.z+zoffset);
    }
}
