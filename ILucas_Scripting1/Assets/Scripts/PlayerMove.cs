using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
	public float speed = 20.0f;

	void FixedUpdate ()
	{ 

		//Movement
		var movespeed = new Vector3 (Input.GetAxis ("Horizontal"), 0, 0);
        float move = Input.GetAxis("Horizontal");

        var movespeedy = new Vector3(0, Input.GetAxis("Vertical"), 0);
        float movey = Input.GetAxis("Vertical");

		GetComponent<Rigidbody>().position += movespeed * speed * Time.deltaTime;
        GetComponent<Rigidbody>().position += movespeedy * speed * Time.deltaTime;
		
	}

    }
