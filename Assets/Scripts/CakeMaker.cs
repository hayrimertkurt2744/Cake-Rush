using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeMaker : MonoBehaviour
{
    private CakeDetector cakeDetector;
    public GameObject prefab;
    public GameObject doughPrefab;
    public GameObject cakePrefab;
    public GameObject frostingPrefab;
    public GameObject garbagePrefab;
    public GameObject burnedPrefab;
    public bool makeTheCake = false;

    private void Start()
    {
      
        
        /*if (collisionCakeMaker == true)
        {w
            for (int i = 0; i < cakeDetector.burnedCount; i++)
            {
                Instantiate(cakeDetector.burnedPrefab, new Vector3(0, 0, 0), Quaternion.identity);
                Debug.Log("cake instantiated");
            }
        }*/
    }
    private void LateUpdate()
    {
        if (makeTheCake==true)
        {
            for (int i = 0; i <5 ; i++)
            { Instantiate(prefab, new Vector3(0, 1/2+i, 0), Quaternion.identity); }
            makeTheCake = false;
        }
    }
    /* private void OnTriggerExit(Collider other)
     {
         if (other.gameObject.tag == "CakeMov")
         {
             collisionCakeMaker = true;
             Debug.Log("cake maker collision is true");
         }
     }*/

}
