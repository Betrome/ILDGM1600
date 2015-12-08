using UnityEngine;
using System.Collections;

public class DoWhileLoop : MonoBehaviour {

    public bool Continue = false;
	// Use this for initialization
	void Start () {

        do
        {
            print("Continue?");
            print("Yes  No");
        } while (Continue == true);
	
	}
}
