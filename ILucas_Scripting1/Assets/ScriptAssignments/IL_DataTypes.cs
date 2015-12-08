using UnityEngine;
using System.Collections;

public class IL_DataTypes : MonoBehaviour {

	void Start () {

        Vector3 move = transform.position;
        move = new Vector3(5, 5, 0);

        Transform cc = transform;
        cc.position = new Vector3(5, 5, 0);

    }

}
