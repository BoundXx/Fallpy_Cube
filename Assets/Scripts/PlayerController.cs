using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float jumpHeight;
	public KeyCode jumpButton;

	private Rigidbody2D rigBody;
	
	// Use this for initialization
	void Start ()
	{
		rigBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void FixedUpdate ()
	{
		Jump ();
	}

	void Jump()
	{
		// Jump if the jumpButton is pressed
		if (Input.GetKeyDown(jumpButton))
		{
			//Debug.Log("Jump");
			rigBody.velocity = new Vector2 (0, jumpHeight);
		}
	}
}
