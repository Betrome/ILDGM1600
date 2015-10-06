using UnityEngine;
using System.Collections;

public class Public_Class : MonoBehaviour {

    public float iron = 3f;
    public float wood = 2f;

    private ForgeClass IronBlade;

    void Start ()
    {
        IronBlade = new ForgeClass();
        IronBlade.Forge(iron, wood);
    }
    
}
