using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public float speed = 2f;
    Vector3 directionPlayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        directionPlayer = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        { 
             directionPlayer += Vector3.left;
        }

        if (Input.GetKey(KeyCode.W))
        {
            directionPlayer += Vector3.forward;
        }

        if (Input.GetKey(KeyCode.D))
        {
            directionPlayer += Vector3.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            directionPlayer += Vector3.back;
        }

        if (directionPlayer != Vector3.zero)
        {
            MovePayer(directionPlayer);
        }
    }
       
    private void MovePayer(Vector3 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
