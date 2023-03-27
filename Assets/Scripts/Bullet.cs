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
        rb= GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
    }
    void OnTriggerEnter(Collider other)
    {
        //checks the bullet to make sure its a target that hits
        if(other.CompareTag("Target"))
        {
            var target = other.GetComponent<Target>();

            if (target != null) target.TakeDamage(0, instaKill: true);
        }
        // Enemy
        if(other.CompareTag("Damageable"))
        {
            // var target = other.GetComponent<Health>();
        //enemy takes damage if 0 dead
            // if (target != null) target.Damage(5);
        }
    }
}