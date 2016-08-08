using UnityEngine;
using UnityEngine.SceneManagement;

public class UserInterfaceBehaviour : MonoBehaviour 
{

	public void ChangeScene(int scene)
	{
		SceneManager.LoadScene (scene); //Loads the level specified in the build order (Found in BUILD SETTINGS)
	}

	public void MuteMusic ()
	{
		//Mute the audio source for the music.
	}
}
