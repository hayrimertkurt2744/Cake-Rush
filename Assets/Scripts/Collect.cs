using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("collect_dough"))
        {
            other.gameObject.transform.position = transform.position + Vector3.left;
            Destroy(gameObject.GetComponent<Collect>());
            other.gameObject.AddComponent<Collect>();
            other.gameObject.AddComponent<NodeMovement>();
            other.gameObject.GetComponent<NodeMovement>().connectedNode = transform;
            other.gameObject.tag = "collected_dough";
        }
    }
}
