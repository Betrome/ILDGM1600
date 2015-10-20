using UnityEngine;
using System.Collections;

public class IL_Array : MonoBehaviour {

    public GameObject[] ball;

    void Start()
    {
        ball = GameObject.FindGameObjectsWithTag("Ball");

        for (int i = 0; i < ball.Length; i++)
        {
            Debug.Log("Ball Number " + i + " is " + ball[i].name);
        }
    }
}
