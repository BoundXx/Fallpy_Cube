using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{

    public GameObject ground;

    private GameObject player;
    private float distance;
    private Text scoreText;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        scoreText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Get distance from the player to the ground
        distance = Vector2.Distance(player.transform.position, ground.transform.position);
        scoreText.text = distance.ToString("#.");
    }
}
