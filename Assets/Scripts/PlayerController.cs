using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2d;

    // Start is called before the first frame update
    void Start()
    {
       rb2d = GetComponent<Rigidbody2D>(); 
       surfaceEffector2d = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        RespondToBoost();

    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmount);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            surfaceEffector2d.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2d.speed = baseSpeed;
        }
        //if We push up, then speed up
        // Otherwise stay at normal speed
        // access the surface  effector2d and change its speed

    }
}
