using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Scene_Chg : MonoBehaviour {

	public string level;

	public void Scene_Easy()
	{
		SceneManager.LoadScene ("Scene_1");
		level = "Easy";
		PlayerPrefs.SetString ("Level", level);
	}

	public void Scene_Hard()
	{
		SceneManager.LoadScene ("Scene_1");
		level = "Hard";
		PlayerPrefs.SetString ("Level", level);
	}

	public void Scene_Medium()
	{
		SceneManager.LoadScene ("Scene_1");
		level = "Medium";
		PlayerPrefs.SetString ("Level", level);
	}
}
