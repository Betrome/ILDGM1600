using UnityEngine;
using System.Collections;

public class IL_Loop : MonoBehaviour {

    public int maxHp = 0;

	// Use this for initialization
	/*void Start () {
	
	}*/
	
	// Update is called once per frame
	void Start () {
        for (int hp = 3;  hp <= 100; hp++)
        {
            Debug.Log("HP: " + hp);
            maxHp = hp;
        }
        if (maxHp == 100)
        {
            Debug.Log("Max HP reached.");
        }
	}
}
