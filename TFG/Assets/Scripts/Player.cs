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

        transform.GetComponent<Animator>().SetBool("Front", false);
        transform.GetComponent<Animator>().SetBool("Back", false);
        transform.GetComponent<Animator>().SetBool("Left", false);
        transform.GetComponent<Animator>().SetBool("Right", false);

        if (Input.GetKey(KeyCode.W))
        {
            new_position.y += movement_speed;
            transform.GetComponent<Animator>().SetBool("Front", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.GetComponent<Animator>().SetBool("Back", true);
            new_position.y -= movement_speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.GetComponent<Animator>().SetBool("Left", true);
            new_position.x -= movement_speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.GetComponent<Animator>().SetBool("Right", true);
            new_position.x += movement_speed;
        }


        transform.position = new_position;

    }
}
