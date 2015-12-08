using UnityEngine;
using System.Collections;

public class IL_Enumeration : MonoBehaviour {

    enum compass { North, East, South, West };

    void Start()
    {
        compass Direction;
        compass dir;

        Direction = compass.North;

        ChangeDirection (Direction);

    }

        compass ChangeDirection(compass dir)
    {
            if (dir == compass.North)
                dir = compass.South;
            else if (dir == compass.South)
                dir = compass.North;
            else if (dir == compass.East)
                dir = compass.West;
            else if (dir == compass.West)
                dir = compass.East;

            Debug.Log("the direction is " + dir);
            return dir;
    }  
}
