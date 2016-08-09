using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    private GameObject player;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update ()
    {
        // If player is higher than the center of the camera lock the camera to the player 
        if (player.transform.position.y >= 4.4f)
        {
            transform.position = new Vector3(0, player.transform.position.y, -10);
        }
        else
        {
            transform.position = new Vector3(0, 4.4f, -10);
        }
    }
}
