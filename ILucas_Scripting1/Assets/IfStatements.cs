using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour {

		public float life = 100.0f;
		public float maxpsn = 10.0f;
		public float minorpsn = 40.0f;
		
		
		void Update()
		{

		if (Input.GetKey (KeyCode.Space))
			psncounter ();

        life -= Time.deltaTime * 6f;

    }
		
		
		void psncounter ()
		{
			if(life <= maxpsn)
			{
				print("You succumbed to radiation poisoning!");
			}
			
		else if(life < minorpsn && life > maxpsn)
			{
				print("You are suffering from minor radiation poisoning.");
			}
			
			else
			{
				print("You are A Okay.");
			}
		}
	}
