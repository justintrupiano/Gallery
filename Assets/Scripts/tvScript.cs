using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tvScript : MonoBehaviour
{


//// Initally made to shutoff video when the user walks too far from the center of the object.
  public Collider[] hitColliders;
  public int dist;
  public GameObject objectToDisable;


    void Update()
    {
      checkTV();
    }



    void checkTV()
    {
      hitColliders = Physics.OverlapSphere(transform.position, dist, 1 << 9);
      if (hitColliders.Length > 0 && objectToDisable.activeSelf == false)
          objectToDisable.active = true;

      else if(hitColliders.Length == 0 && objectToDisable.activeSelf == true)
        objectToDisable.active = false;


    }
}
