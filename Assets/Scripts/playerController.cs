
using UnityEngine;
using UnityEngine.AI;
public class playerController : MonoBehaviour{

  public NavMeshAgent agent;
  // public GameObject target;
  public float speed;
  public float lookSpeed;
  private float X;
  private float Y;
  // public bool autopilot;
  public float sensitivity;
  public int startPos;
  public GameObject[] exhibitPositions;

  public GameObject hud;
    void Start()
    {
      teleport(startPos);
    }

    void Update()
    {

        moveConditions();

        if(Input.GetMouseButton(0))
          MouseDirection();




      if (Input.GetKeyUp(KeyCode.M))
        hud.active = !hud.active;

      // if (Input.GetKeyUp(KeyCode.U))
      //   autopilot = !autopilot;

      if (Input.GetKey(KeyCode.Keypad0))
        teleport(0);
      if (Input.GetKey(KeyCode.Alpha0))
        teleport(0);
      if (Input.GetKey(KeyCode.Keypad1))
        teleport(1);
      if (Input.GetKey(KeyCode.Alpha1))
        teleport(1);
      if (Input.GetKeyUp(KeyCode.Keypad2))
        teleport(2);
      if (Input.GetKeyUp(KeyCode.Alpha2))
        teleport(2);
      if (Input.GetKeyUp(KeyCode.Keypad3))
        teleport(3);
      if (Input.GetKeyUp(KeyCode.Alpha3))
        teleport(3);
      if (Input.GetKeyUp(KeyCode.Keypad4))
        teleport(4);
      if (Input.GetKeyUp(KeyCode.Alpha4))
        teleport(4);
      if (Input.GetKeyUp(KeyCode.Keypad5))
        teleport(5);
      if (Input.GetKeyUp(KeyCode.Alpha5))
        teleport(5);
      if (Input.GetKeyUp(KeyCode.Keypad6))
        teleport(6);
      if (Input.GetKeyUp(KeyCode.Alpha6))
        teleport(6);
      if (Input.GetKeyUp(KeyCode.Keypad7))
        teleport(7);
      if (Input.GetKeyUp(KeyCode.Alpha7))
        teleport(7);
      if (Input.GetKeyUp(KeyCode.Keypad8))
        teleport(8);
      if (Input.GetKeyUp(KeyCode.Alpha8))
        teleport(8);
      if (Input.GetKeyUp(KeyCode.Keypad9))
        teleport(9);
      if (Input.GetKeyUp(KeyCode.Alpha9))
        teleport(9);


    }

    void teleport(int exhibit)
      {

        // Debug.Log(exhibitPositions[exhibit].transform.position);
        agent.enabled = false;
        transform.position = new Vector3(exhibitPositions[exhibit].transform.position.x, transform.position.y, exhibitPositions[exhibit].transform.position.z);
        transform.rotation = Quaternion.Euler(0, exhibitPositions[exhibit].transform.localEulerAngles.y, 0);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.forward);
        // Camera.main.transform.rotation = Quaternion.Euler(exhibitPositions[exhibit].transform.localEulerAngles.x, 0, 0);

        agent.enabled = true;

        // agent.Stop();
        // agent.Resume();
        // switch(exhibit)
        // {
        //   case 0:
        //     transform.position = new Vector3(-150f, 1f, -670f);
        //     transform.rotation = Quaternion.Euler(0, 0, 0);
        //     Camera.main.transform.rotation = Quaternion.Euler(0, 0, 0);
        //     break;
        //   case 1:
        //     transform.position = new Vector3(-157f, 1f, -454f);
        //     transform.rotation = Quaternion.Euler(0, 0, 0);
        //     break;
        // }


      }

    // void changeTarget(int exhibit)
    //   {
    //      target.transform.position = exhibitPositions[exhibit].transform.position;
    //      target.transform.rotation = exhibitPositions[exhibit].transform.rotation;
    //   }



    void MouseDirection()
    {
      var c = Camera.main.transform;
      c.Rotate(-Input.GetAxis("Mouse Y")* sensitivity, 0, 0);
      transform.Rotate(0, Input.GetAxis("Mouse X")* sensitivity, 0);
    }


    void moveConditions(){
      if (Input.GetKey(KeyCode.W))
        agent.Move(transform.forward * speed);
      if (Input.GetKey(KeyCode.S))
        agent.Move(-transform.forward * speed);
      if (Input.GetKey(KeyCode.A))
        agent.Move(-transform.right * speed);
      if (Input.GetKey(KeyCode.D))
        agent.Move(transform.right * speed);


    }

}
