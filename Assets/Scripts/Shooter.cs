using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public ParticleSystem muzzleFlash;
    public GameObject bullet;
    public GameObject firePoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //left click to shoot
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }

        // Rotate the firepoint with the main camera
        Quaternion cameraRotation = Camera.main.transform.rotation;

        // Set the firepoint's rotation to match the camera's rotation
       firePoint.GetComponent<Transform>().rotation = cameraRotation;

    }
    void Shoot()
    {

        var clone = Instantiate(bullet, firePoint.transform.position, firePoint.transform.rotation);
        Destroy(clone, 2f);
    }
}
