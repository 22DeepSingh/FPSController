using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleTouch : MonoBehaviour
{
   //s public GameObject circle;
    public List<TouchLocation> touches = new List<TouchLocation>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).position.y > Screen.height / 2)
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
                    Debug.Log(Input.GetTouch(0).position.y);
                }
                ++i;
            }
        }
    }
}
