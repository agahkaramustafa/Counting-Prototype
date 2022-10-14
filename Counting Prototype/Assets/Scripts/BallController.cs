using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    Rigidbody ballRB;
    Vector3 mouseDownPos;
    Vector3 mouseUpPos;
    float forceMultiplier = 250f;

    void Start() 
    {
        ballRB = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RemainInsideBoundries();
    }

    void RemainInsideBoundries()
    {
        if (transform.position.z < -60)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 60f);
        }

        if (transform.position.z > 60)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -60f);
        }

        if (transform.position.y > 30f)
        {
            transform.position = new Vector3(transform.position.x, 30f, transform.position.z);
        }
    }

    void OnMouseDown() {
        mouseDownPos = Input.mousePosition;
        mouseDownPos.z = mouseDownPos.x;
        mouseDownPos.x = 0;
        Debug.Log("down z: " + mouseDownPos);
    }

    void OnMouseUp() {
        mouseUpPos = Input.mousePosition;
        mouseUpPos.z = mouseUpPos.x;
        mouseUpPos.x = 0;
        Debug.Log("up z: " + mouseUpPos);
        Shoot();
    }

    void Shoot()
    {
        Vector3 forceVector = mouseDownPos - mouseUpPos;
        Debug.Log("y: " + forceVector.y + "z: " + forceVector.z);
        ballRB.useGravity = true;
        ballRB.AddForce(forceVector * forceMultiplier);
    }

    public void DestroyTheBall()
    {
        Destroy(gameObject);
    }
}
