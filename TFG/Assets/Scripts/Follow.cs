using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public bool following = false;
    public GameObject player;
    public float speed = 1.0f;
    private Vector3 new_position;

    // Start is called before the first frame update
    void Start()
    {
        new_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        transform.GetComponent<Animator>().SetBool("front", false);
        transform.GetComponent<Animator>().SetBool("back", false);
        transform.GetComponent<Animator>().SetBool("left", false);
        transform.GetComponent<Animator>().SetBool("right", false);

        if (following)
        {
            if (transform.position.x > player.transform.position.x)
            {
                //transform.GetComponent<Animator>().SetBool("left", true);
                new_position.x -= speed;
            }

            if (transform.position.x < player.transform.position.x)
            {
                //transform.GetComponent<Animator>().SetBool("right", true);
                new_position.x += speed;
            }

            if (transform.position.y > player.transform.position.y)
            {
                transform.GetComponent<Animator>().SetBool("back", true);
                new_position.y -= speed;
            }

            if (transform.position.y < player.transform.position.y)
            {

                transform.GetComponent<Animator>().SetBool("front", true);
                new_position.y += speed;
            }

            transform.position = new_position;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            following = false;
        }
    }
}
