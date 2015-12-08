using UnityEngine;
using System.Collections;

public class ILucas_VariablesFunctions : MonoBehaviour
{

	int ex = 12;

	void Start()
	{

		ex = Multiply (ex);
		Debug.Log (ex);

	}
	
	// Update is called once per frame
	int Multiply (int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}
