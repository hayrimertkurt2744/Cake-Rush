using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private NodeMovement nodeMovementScript;
    public int collectedMaterial=0;
    private void Update()
    {
        Debug.Log(collectedMaterial);
    }
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.CompareTag("collect_dough"))
        {
                collectedMaterial++;
                Destroy(gameObject.GetComponent<Collect>());
                other.gameObject.AddComponent<Collect>();
                other.gameObject.AddComponent<NodeMovement>();
                other.gameObject.GetComponent<NodeMovement>().connectedNode = transform;
                other.gameObject.tag = "collected_dough";

        }
       
    }
}
