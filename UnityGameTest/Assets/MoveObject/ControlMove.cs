using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMove : MonoBehaviour
{


    public float speed = 5f;
    public Vector3 vec;
    public float MoveLeft()
    {
        vec.x -= speed * Time.deltaTime;
        transform.position = vec;
        return transform.position.x;

    }
    public float MoveRight()
    {
        vec.x += speed * Time.deltaTime;
        transform.position = vec;
        return transform.position.x;
    }
    public float MoveUp()
    {
        vec.y += speed * Time.deltaTime;
        transform.position = vec;
        return transform.position.y;
    }
    public float MoveDown()
    {
        vec.y -= speed * Time.deltaTime;
        transform.position = vec;
        return transform.position.y;
    }


   /* //void Update()
    {
        vec = transform.position;
        if(Input.GetKey(KeyCode.UpArrow))
        {
            vec.y += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            vec.y -= speed * Time.deltaTime;
            
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            vec.x += speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            vec.x -= speed * Time.deltaTime;
        }
        transform.position = vec;
    }*/
}
