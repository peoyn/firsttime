using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SealController_1 : MonoBehaviour
{
    Rigidbody2D rb2d;

    public float maxHeight;
    public float flapVelocity;

    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && transform.position.y < maxHeight)
        {
            Flap();
        }

    }

    public void Flap()
    {

        rb2d.velocity = new Vector2(0.0f, flapVelocity);
    }
}
