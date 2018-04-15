using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    //public Scene StartLevel;

	public void PlayGame() {
        //if (StartLevel == null)
        //{
        //    Debug.Log("Start Level was not assigned");
        //    return;
        //}

		SceneManager.LoadScene("StartLevel");

    }
	
	public void Quit() {
		Application.Quit();
	}
}
