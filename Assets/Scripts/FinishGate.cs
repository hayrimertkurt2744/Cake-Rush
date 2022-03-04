using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGate : MonoBehaviour
{
    private Movement movementScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("CakeMov") )
        {
            
            Debug.Log("collision detected");
        }
        else
        {
            Destroy(other.gameObject);
        }
        
    }
}
