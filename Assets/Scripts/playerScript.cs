using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public GameObject target;
    public float speed;
    private Vector3 dir;
    public int dist;
    public float rayOffset;
    public float hitNormalTimes;
    // Start is called before the first frame update
    void Start()
    {
      // target = transform.forward;
      // dir = new Vector3(Random.Range(-0.5f, 0.5f), 0, Random.Range(-0.5f, 0.5f));
      // dir = new Vector3(0,Random.Range(-1.0f, 1.0f),0);

    }

    // Update is called once per frame
    void Update()
    {
      // target = transform.TransformDirection(transform.forward);
      move();
    }



    void move()
    {
      Vector3 targetVector = target.transform.position;

      RaycastHit hit;

      // if (Random.Range(0.0f, 1.0f) > 0.75f)
        // dir += new Vector3(0, Random.Range(-1.0f, 1.0f), 0);

      // dir = (target.transform.position - transform.position).normalized;

      // dir += (transform.TransformDirection(Vector3.forward) - transform.position).normalized;

      Vector3[] rays = new Vector3[3];

      for (int i = 0; i < rays.Length; i++)
      {
        rays[i] = transform.position;
      }

      rays[1] = transform.TransformPoint(Vector3.right * rayOffset);
      rays[2] = transform.TransformPoint(-Vector3.right * rayOffset);


      // rays[2].up -= 100;

      // rays[3].y += 10;
      // rays[4].y -= 10;

      foreach (Vector3 ray in rays)
      {
        // int layer = 1 << 8; //// Bitshift to Boundries Layer

        if (Physics.Raycast(ray, transform.TransformDirection(Vector3.forward), out hit, dist))
        {

          // if (hit.transform.gameObject.layer == layer)
          // {
            // dir += hit.normal * (dist - hit.distance);
            // dir += hit.normal * 0.01f;
            dir += hit.normal * hitNormalTimes;
            // dir += (hit.normal + transform.TransformDirection(Vector3.forward)).normalized * hitNormalTimes;
            // dir += -ray.direction * (dist - hit.distance);
            // dir += Vector3.Cross(transform.TransformDirection(Vector3.forward)
            Debug.DrawLine(ray, hit.point, Color.red);
          // }
        }



      }

      dir += (targetVector - transform.position).normalized;
      // dir = new Vector3 (0, dir.y, 0);
      Quaternion rotation = Quaternion.LookRotation(dir);
      transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
      transform.position += transform.forward * speed * Time.deltaTime;


    }
}
