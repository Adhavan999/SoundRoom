using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donthitball : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>(),false);
    }
}
