using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour {
    Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("Touched.." + col.gameObject.tag);
        if(col.gameObject.tag == "Line")
        {   
            rb = GetComponent<Rigidbody2D>();
            Vector2 bounceline = col.gameObject.GetComponent<LineDrawer>().Returnormal();
            Vector2 vel = rb.velocity;
            float angle = Vector2.Angle(bounceline, vel);
            angle = 2 * angle;
            Debug.Log("Velocity before..." + rb.velocity.ToString());
            vel = Quaternion.Euler(0, 0, Mathf.Deg2Rad * angle) * vel;
            rb.velocity = vel;
            Debug.Log("velocity after..." + rb.velocity.ToString());
        }
    }
}
