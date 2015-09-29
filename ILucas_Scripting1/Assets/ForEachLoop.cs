using UnityEngine;
using System.Collections;

public class ForEachLoop : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        string[] stats = new string[7];

        stats[0] = "Strength 3";
        stats[1] = "Perception 4";
        stats[2] = "Endurance 2";
        stats[3] = "Charisma 2";
        stats[4] = "Intelligence 4";
        stats[5] = "Agility 3";
        stats[6] = "Luck 2";

        foreach (string item in stats)
        {
            print(item);
        }


    }
	
}
