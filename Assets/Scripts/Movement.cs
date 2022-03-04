using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float movementSpeed=5;
    [SerializeField] float horSpeed=5;
    float hor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        transform.Translate(new Vector3(movementSpeed * Time.deltaTime, 0, -hor * horSpeed * Time.deltaTime));
    }
}
