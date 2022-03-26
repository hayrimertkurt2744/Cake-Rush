using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeDetector : MonoBehaviour
{
    public int doughCount = 0;
    public int cakeCount = 0;
    public int garbageCount = 0;
    public int frostingCount = 0;
    public int burnedCount = 0;
    public int totalCount;
    public List<int> pieces = new List<int>();

    

    
    public List<GameObject> prefabs = new List<GameObject>();
    public Transform lastTransformPoint;
    public bool startToInstantiate = false;

    private void Start()
    {
       // var prefabs = new List<GameObject>() { burnedPrefab, garbagePrefab, frostingPrefab, cakePrefab, doughPrefab };
        

    }
    private void OnTriggerEnter(Collider other)
    {
        

        if (other.gameObject.tag == "collected_dough")
        {
            doughCount++;
            
        }
        else if (other.gameObject.tag == "collected_cake")
        {
            cakeCount++;
            
        }
        else if (other.gameObject.tag == "collected_garbage")
        {
            garbageCount++;
            
        }
        else if (other.gameObject.tag == "collected_frosting")
        {
            frostingCount++;
            
        }
        else if (other.gameObject.tag == "collected_burned")
        {
            burnedCount++;
            
        }
        


    }

}
                         