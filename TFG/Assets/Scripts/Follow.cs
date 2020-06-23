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
        if (following)
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
                new_position.y -= speed;
            }

            if (transform.position.y < player.transform.position.y)
            {
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
