using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Vector2 new_position;
    public float movement_speed = 0.0f;
    public GameObject right_margin;
    public GameObject left_margin;
    public GameObject bot_margin;
    public GameObject top_margin;

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
            transform.GetComponent<Animator>().SetBool("Front", true);
            //transform.GetComponent<Animator>().Play("Front_walk");
            if(transform.position.y < top_margin.transform.position.y)
            new_position.y += movement_speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.GetComponent<Animator>().SetBool("Back", true);
            //transform.GetComponent<Animator>().Play("back_walk");
            if (transform.position.y > bot_margin.transform.position.y)
                new_position.y -= movement_speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.GetComponent<Animator>().SetBool("Left", true);
            //transform.GetComponent<Animator>().Play("Left_walk");
            if (transform.position.x > left_margin.transform.position.x)
                new_position.x -= movement_speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.GetComponent<Animator>().SetBool("Right", true);
            //transform.GetComponent<Animator>().Play("Right_walk");
            if (transform.position.x < right_margin.transform.position.x)
                new_position.x += movement_speed;
        }


        transform.position = new_position;

    }
}
