using UnityEngine;
using System.Collections;

public class DestroyBullets : MonoBehaviour {

    public float bulletlife = 2.0f;


    void Update ()
    {
        Destroy(gameObject, bulletlife);
    }

}
