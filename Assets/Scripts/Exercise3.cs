using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise3 : MonoBehaviour
{

    private float jumpDistance = 60f;
    private float limits=120f;
    private Vector3 nextJump;
    

    // Update is called once per frame
    void Update()
    {
        //Like this we make the movement. If we press the button,and we didn't reach the limit, the player will move towards the indicated position
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != limits)
        {
            nextJump = new Vector3(transform.position.x, transform.position.y + jumpDistance, transform.position.z);
            transform.position = nextJump;
            

        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -limits)
        {
           nextJump= new Vector3(transform.position.x, transform.position.y - jumpDistance, transform.position.z);
            transform.position = nextJump;
            

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x != -limits)
        {
            nextJump = new Vector3(transform.position.x - jumpDistance, transform.position.y, transform.position.z);
            transform.position = nextJump;
            

        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x != limits)
        {
            nextJump = new Vector3(transform.position.x + jumpDistance, transform.position.y, transform.position.z);
            transform.position = nextJump;
            
        }
    }

}
