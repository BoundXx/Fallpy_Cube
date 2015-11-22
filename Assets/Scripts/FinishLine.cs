using UnityEngine;
using System.Collections;

public class FinishLine : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		// Cube 1 finished
		if (col.name == "PlayerCube01")
		{
			Debug.Log("Cube 1");
		}
		// Cube 2 finished
		else if (col.name == "PlayerCube02")
		{
			Debug.Log("Cube 2");
		}
	}
}
