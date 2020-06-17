using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Vector2 new_position;
    public float movement_speed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        new_position = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.W))
        {
            new_position.y += movement_speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            new_position.y -= movement_speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            new_position.x -= movement_speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            new_position.x += movement_speed;
        }


        transform.position = new_position;

    }
}
