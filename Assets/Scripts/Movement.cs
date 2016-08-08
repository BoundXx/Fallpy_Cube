using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public GameObject player;

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (player.transform.position.y >= 4.4f)
        {
            this.transform.position = new Vector3(0, player.transform.position.y, -10);
        }
        else
        {
            this.transform.position = new Vector3(0, 4.4f, -10);
        }
    }
}
