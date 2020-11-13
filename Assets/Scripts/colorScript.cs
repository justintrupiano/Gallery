using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorScript : MonoBehaviour
{
    public Material[] randomMaterials;

    void Start()
    {
      transform.GetComponent<Renderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)];

    }

}
