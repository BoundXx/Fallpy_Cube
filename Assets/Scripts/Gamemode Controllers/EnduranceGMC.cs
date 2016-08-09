using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnduranceGMC : MonoBehaviour
{

    public int score;
    public Text scoreText;
    public GameObject triggerer;

    /*
    void Awake()
    {
        scoreText.text = score.ToString();
	}
	void Update ()
    {
        scoreText.text = score.ToString();
    }
    */


    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Line")
        {
            Debug.Log("collided");
            SceneManager.LoadScene("End-SP-desktop");
        }
    }
}
