using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 100.0f;
 
    void Update()
    {
        if(Input.GetKey("up"))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
 
        if(Input.GetKey("down"))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
 
        if(Input.GetKey("right"))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
 
        if(Input.GetKey("left"))
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
