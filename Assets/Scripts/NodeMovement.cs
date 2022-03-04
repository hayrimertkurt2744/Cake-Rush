using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform connectedNode;
    [SerializeField] private float offset = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            (connectedNode.position.x - offset),
            connectedNode.position.y,
            Mathf.Lerp(transform.position.z, connectedNode.position.z, Time.deltaTime * 20));
    }
}
