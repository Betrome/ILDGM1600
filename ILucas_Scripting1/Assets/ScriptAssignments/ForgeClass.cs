using UnityEngine;
using System.Collections;

public class ForgeClass : MonoBehaviour
{
 
    public void Forge (float a, float b)
    {      
        if ((a + b) / 5 >= 1)
        {
            Debug.Log ("Successfully forged an Iron Blade");
        }
        else
        {
            Debug.Log("Failure...");
        }

    }

}
