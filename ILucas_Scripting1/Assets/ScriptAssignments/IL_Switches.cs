using UnityEngine;
using System.Collections;

public class IL_Switches : MonoBehaviour {

    public int Strength = 6;
    
	
    void Start()
    {
        Lift();
    }
	// Update is called once per frame
	void Lift ()
    {
        Debug.Log("You happen upon a large rock.");
        switch (Strength)
        {
            case 6:
                print("You easily lift the rock and hurl it into the river.");
                break;
            case 5:
                print("You manage to lift the rock and toss it into the river.");
                break;
            case 4:
                print("You roll the rock into the nearby river, providing a way to cross.");
                break;
            case 3:
                print("You struggle to roll the rock into the nearby river.");
                break;
            case 2:
                print("You can't budge the rock.");
                break;
            case 1:
                print("You hurt your back trying to move the rock.");
                break;
            default:
                print("You decide not to move the rock.");
                break;
        }
	
	}
}
