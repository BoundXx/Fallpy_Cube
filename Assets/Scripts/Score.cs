using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour
{

    public GameObject player;
    public GameObject ground;

    private float distance;
    private Text scoreText;

	// Use this for initialization
	void Start ()
    {
        scoreText = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update ()
    {
        distance = Vector2.Distance(player.transform.position, ground.transform.position);
        scoreText.text = distance.ToString("#.");
    }
}
