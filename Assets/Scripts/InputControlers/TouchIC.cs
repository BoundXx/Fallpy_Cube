using UnityEngine;
using System.Collections;

public class TouchIC : MonoBehaviour
{
    
    public float jumpHeight;
    public AudioClip pewSound;

    private Rigidbody2D rigBody;

	// Use this for initialization
	void Start ()
    {
        rigBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Debug.Log("Jump");
            rigBody.velocity = new Vector2(0, jumpHeight);

            AudioSource.PlayClipAtPoint(pewSound, transform.position);
        }

	}
}
