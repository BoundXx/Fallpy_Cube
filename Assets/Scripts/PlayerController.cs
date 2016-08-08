﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float jumpHeight;
	public KeyCode jumpButton;

	private Rigidbody rigBody;
	
	// Use this for initialization
	void Start ()
	{
		rigBody = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
	{
        Jump();
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
