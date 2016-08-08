using UnityEngine;
using System.Collections;

public class TouchInput : MonoBehaviour
{

    public GameObject player;
    public float jumpHeight;
    public AudioClip pewSound;

    private Rigidbody rigBody;

	// Use this for initialization
	void Start ()
    {
        rigBody = player.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Debug.Log("Jump");
            rigBody.velocity = new Vector2(0, jumpHeight);

            AudioSource.PlayClipAtPoint(pewSound, player.transform.position);
        }

	}
}
