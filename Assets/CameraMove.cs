using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float mouseSensitivity;
    public Transform player;
    float Xrot = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        

            int i = 0;
            while (i < Input.touchCount)
            {
                Touch t = Input.GetTouch(i);
                if (t.phase == TouchPhase.Began)
                {
                    Debug.Log("touBegan");
                }
                else if (t.phase == TouchPhase.Ended)
                {
                    Debug.Log("touchEnded");
                }
                else if (t.phase == TouchPhase.Moved)
                {
                    Debug.Log(Input.GetTouch(0).position.x);
                    float x = Input.GetTouch(0).position.x * -mouseSensitivity * Time.deltaTime;
                    player.Rotate(player.up * x);
                }
                ++i;
            }


            //    float x = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            //player.Rotate(player.up * x);
            //float y = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
            //Xrot = Xrot - y;
            //Xrot = Mathf.Clamp(Xrot, -45, 45);
            //transform.localRotation = Quaternion.Euler(Xrot, 0, 0);

        }
  //  }
}
