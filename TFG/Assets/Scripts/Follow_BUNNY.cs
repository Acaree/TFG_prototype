using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_BUNNY : MonoBehaviour
{
    public bool following = false;
    public float min_distance = 1.5f;
    private float distance;
    public GameObject player;
    public GameObject secondary_path;
    public bool secondary_obj = false;
    public float speed = 0.1f;
    private Vector3 new_position;

    // Start is called before the first frame update
    void Start()
    {
        new_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.GetComponent<Animator>().SetBool("Front", false);
        transform.GetComponent<Animator>().SetBool("Back", false);

        if (!secondary_obj)
        {

            distance = (player.transform.position - transform.position).magnitude;



            if (distance > min_distance && following)
            {
                if (transform.position.x > player.transform.position.x)
                {
                    new_position.x -= speed;
                }

                if (transform.position.x < player.transform.position.x)
                {
                    new_position.x += speed;
                }

                if (transform.position.y > player.transform.position.y)
                {
                    transform.GetComponent<Animator>().SetBool("Back", true);
                    new_position.y -= speed;
                }

                if (transform.position.y < player.transform.position.y)
                {
                    new_position.y += speed;
                    transform.GetComponent<Animator>().SetBool("Front", true);
                }

            }
        }

        else
        {
            if (transform.position.x > secondary_path.transform.position.x)
            {
                new_position.x -= speed;
            }

            if (transform.position.x < secondary_path.transform.position.x)
            {
                new_position.x += speed;
            }

            if (transform.position.y > secondary_path.transform.position.y)
            {
                transform.GetComponent<Animator>().SetBool("Back", true);
                new_position.y -= speed;

            }

            if (transform.position.y < secondary_path.transform.position.y)
            {
                new_position.y += speed;
                transform.GetComponent<Animator>().SetBool("Front", true);
            }

        }

        transform.position = new_position;
    }

    public void run()
    {
        secondary_obj = true;
    }
   
}
