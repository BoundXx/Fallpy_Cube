using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class EnduranceGMC : MonoBehaviour
{

    public float score;
    public Text scoreText;

    void Awake()
    {
        scoreText.text = score.ToString();
	}
	void Update ()
    {
        score = Time.timeSinceLevelLoad;
        scoreText.text = score.ToString();
    }
}
