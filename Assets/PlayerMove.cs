using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public CharacterController playerController;
    public float playerSpeed;
    public FixedJoystick joyStick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //float leftRight = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        //float forBack  = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        float leftRight = joyStick.Horizontal * playerSpeed * Time.deltaTime;
        float forBack = joyStick.Vertical * playerSpeed * Time.deltaTime;

        playerController.Move(transform.forward * forBack);
       // playerController.Move(transform.right * leftRight);

    }
}

