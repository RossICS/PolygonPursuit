using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffScrean : MonoBehaviour
{
    public float leftLimit = 10;
    public float rightLimit = 10;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < -leftLimit)
        {
            Destroy(gameObject);
        }
        //Right
        else if (transform.position.x > rightLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if y position is less than bottomLimit
      else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
