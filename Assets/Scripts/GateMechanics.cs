using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMechanics : MonoBehaviour
{
    [SerializeField] private Material matCake;
    [SerializeField] private Material matFrosting;
    [SerializeField] private Material matBurned;
    [SerializeField] private Material matDough;
    [SerializeField] private Material matGarbage;
    [SerializeField] private float height=0f;
    [SerializeField] private Movement movement;
    private void OnTriggerExit(Collider other)
    {
        OvenAndFrostingGate(other);
        //FinishGate(other);

    }
    private void OvenAndFrostingGate(Collider other)
    {
        //1.1 dough+oven=cake
        if (other.gameObject.CompareTag("collected_dough") && gameObject.tag == "gate_oven")
        {
            other.gameObject.tag = "collected_cake";
            other.gameObject.GetComponent<Renderer>().material = matCake;

        }
        //1.2 cake+oven=burned
        else if ((other.gameObject.CompareTag("collected_cake") || other.gameObject.CompareTag("collected_frosting")) && gameObject.tag == "gate_oven")
        {

            other.gameObject.tag = "collected_burned";
            other.gameObject.GetComponent<Renderer>().material = matBurned;

        }
        //if it is a garbage ,there will be no change
        //2.1 dough+frosting=garbage
        else if (other.gameObject.CompareTag("collected_dough") && gameObject.tag == "gate_frosting")
        {

            other.gameObject.tag = "collected_garbage";
            other.gameObject.GetComponent<Renderer>().material = matGarbage;

        }
        //2.2 cake+frosting=frostedd
        else if (other.gameObject.CompareTag("collected_cake") && gameObject.tag == "gate_frosting")
        {

            other.gameObject.tag = "collected_frosting";
            other.gameObject.GetComponent<Renderer>().material = matFrosting;

        }

        //if it is a garbage ,there will be no change
        //also for frosting+frosting=there will be no change
    }
  
    /* private void FinishGate(Collider other)
    {  height++;
        movement = GetComponent<Movement>();
        if (other.gameObject.CompareTag("collected_frosting")|| other.gameObject.CompareTag("collected_cake") && gameObject.tag=="finish_gate")
        {
            
            
        }
    }*/
}
