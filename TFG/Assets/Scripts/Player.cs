using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update

   public float rotation_speed = 0.0f;
    public float movement_speed = 0.0f;

    Vector3 new_position;
   Vector3 new_rotation;
    

    void Start()
    {
        Vector3 new_position = Vector3.zero;
        Vector3 new_rotation = Vector3.zero;
        
    }

    // Update is called once per frame
    void Update()
    {
        new_position = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            new_position.z += 0.01f * movement_speed;
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            new_position.z -= 0.01f * movement_speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            new_position.x += 0.01f * movement_speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            new_position.x -= 0.01f * movement_speed;
        }

        transform.position = new_position;

        DoRotation();

    }



    void DoRotation()
    {

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        new_rotation.x -= mouseY * rotation_speed;
        new_rotation.z = 0;
        new_rotation.y += mouseX * rotation_speed;

        transform.rotation = Quaternion.Euler(new_rotation);
    }
}

    