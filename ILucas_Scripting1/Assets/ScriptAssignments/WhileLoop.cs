using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour {

    public int EnemyChampions = 5;

	// Use this for initialization
	void Start () {

        while (EnemyChampions > 0)
        {
            Debug.Log("You have slain an enemy!");
            EnemyChampions --;
        }

        if (EnemyChampions == 0)
        {
            Debug.Log("Pentakill!");
        }

    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
