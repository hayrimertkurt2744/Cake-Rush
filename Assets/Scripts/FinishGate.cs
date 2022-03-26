using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishGate : MonoBehaviour
{
    private Movement movementScript;
    public CakeDetector cakeDetector;
    private CakeMaker cakeMaker;
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
        /*for (int i = 0; i < cakeDetector.pieces.Count; i++)
        {
            Instantiate(cakeDetector.pieces[i], gameObject.transform.position, Quaternion.identity);
        }*/
        if (other.gameObject.CompareTag("CakeMov") )
        {
            
            Debug.Log("collision detected");
            cakeMaker.makeTheCake = true;

            
        }
        else
        {
            Destroy(other.gameObject);
        }
        
    }
}
