using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyScript : MonoBehaviour
{

    public Collider[] hitColliders;
    public int dist;
    private Camera camera;

    void Start()
    {
      camera = Camera.main;
    }

    void Update()
    {

      hitColliders = Physics.OverlapSphere(transform.position, dist, 1 << 9);
      if (hitColliders.Length > 0 && camera.clearFlags == CameraClearFlags.Skybox)
          camera.clearFlags = CameraClearFlags.Nothing;

      else if(hitColliders.Length == 0 && camera.clearFlags == CameraClearFlags.Nothing)
        camera.clearFlags = CameraClearFlags.Skybox;
    }
}
