using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectedNode;
    [SerializeField] private float offset = 1;
    public bool isFinished = false;
    private float posX;
    private float posY;
    private float posZ;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        posX = (connectedNode.position.x - offset);
        posY = connectedNode.position.y;
        posZ = Mathf.Lerp(transform.position.z, connectedNode.position.z, Time.deltaTime * 20);

        if (isFinished==false)
        {
         transform.position = new Vector3(posX,posY,posZ);
        }
        
    }
}
