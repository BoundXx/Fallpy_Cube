using UnityEngine;
using System.Collections;

public class UserInterfaceBehaviour : MonoBehaviour 
{

	public void ChangeScene(int scene)
	{
		Application.LoadLevel (scene); //Loads the level specified in the build order (Found in BUILD SETTINGS)
	}

	public void MuteMusic ()
	{
		//Mute the audio source for the music.
	}
}
