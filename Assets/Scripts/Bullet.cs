using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float bulletSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //Gives the bullet a rigidbody and a speed
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if enemy
        if (collision.gameObject.CompareTag("Enemy")) {
            Debug.Log("Enemy hit!");
            Destroy(collision.gameObject);
        }
    }
}