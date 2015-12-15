using UnityEngine;
using System.Collections;
using System;

public class Shooting : MonoBehaviour {

    public Rigidbody projectile;
    public float bulletSpeed = 20.0f;
    //private Vector3 screenPoint;

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Space))
        {
            Rigidbody instProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;

            instProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, bulletSpeed));
        }

        /*if (Input.GetKeyDown (KeyCode.Mouse0))
        {
            screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            Rigidbody instProjectile = Instantiate (projectile, transform.position, transform.rotation) as Rigidbody;

            //instProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, bulletSpeed));

            Vector3 fwd = Camera.main.ScreenToWorldPoint(Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z)));


            instProjectile.velocity = transform.TransformDirection(fwd * bulletSpeed);
        }*/

    }

}
