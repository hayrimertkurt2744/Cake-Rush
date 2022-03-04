using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    [SerializeField] float horSpeed;
    float hor;
    private bool shouldMove=true;
    public GameObject cubeToGetTransform;
    private NodeMovement nodeMovementScript;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 5;
        horSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldMove == true)
        {
            hor = Input.GetAxis("Horizontal");
            transform.Translate(new Vector3(movementSpeed * Time.deltaTime, 0, -hor * horSpeed * Time.deltaTime));
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag=="gate_finish")
        {
            transform.Translate(new Vector3(0, 0, 0));
            shouldMove = false;
            gameObject.transform.position = new Vector3(cubeToGetTransform.transform.position.x, cubeToGetTransform.transform.position.y+1, cubeToGetTransform.transform.position.z);
            
        }
       
    }
}
