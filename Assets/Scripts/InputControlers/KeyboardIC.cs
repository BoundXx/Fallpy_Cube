using UnityEngine;
using System.Collections;

public class KeyboardIC : MonoBehaviour
{
	public float jumpHeight;
	public KeyCode jumpButton;

	private Rigidbody2D rigBody;
	
    void Awake()
    {
        rigBody = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
    }

    void unFreeze()
    {
        Time.timeScale = 1.0f;
    }


    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    void Jump()
	{
        bool isFrozen = true;
        
        // Jump if the jumpButton is pressed Input.GetKeyDown(jumpButton)
        if (Input.touchCount > 0 || Input.GetKeyDown(jumpButton))
        {
            if (isFrozen)
            {
                unFreeze();
                isFrozen = false;
            }

            rigBody.velocity = new Vector2(0, jumpHeight);
           
            
        }
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Line")
        {
            Debug.Log("You lose!");
        }
    }
}
