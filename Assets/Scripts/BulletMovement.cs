using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 10f; // Speed of the bullet

    void Update()
    {

    }

    private void OnMouseDown()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        // Move the bullet forward at a constant speed
        //if ()
        //{
        //transform.Translate(Vector3.left * speed * Time.deltaTime);
        //}
        //else
        //{
        //transform.Translate(Vector3.right * speed * Time.deltaTime);
        //}


    }
}