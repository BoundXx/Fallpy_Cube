using UnityEngine;
using System.Collections;

public class PlayerController2D : MonoBehaviour
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
        Jump();
	}

	void FixedUpdate ()
	{
	
	}

	void Jump()
	{

        // Jump if the jumpButton is pressed Input.GetKeyDown(jumpButton)
        if (Input.touchCount > 0 || Input.GetKeyDown(jumpButton))
        {
            //Debug.Log("Jump");
            rigBody.velocity = new Vector2(0, jumpHeight);
        }
	}
}
