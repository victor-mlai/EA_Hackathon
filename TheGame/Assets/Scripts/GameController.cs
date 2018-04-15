using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

    private bool game_end;

    [SerializeField]
    private Text gameOverText;

    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private Text continueText;

    [SerializeField]
    private string nextScene;

    private AudioSource level_complete_sound;

    [SerializeField]
    private UnityStandardAssets._2D.PlatformerCharacter2D Player;

    // Use this for initialization
    void Start () {
        game_end = false;
        canvas.enabled = false;
        level_complete_sound = GetComponent<AudioSource>();
        //gameOverText.text = "";
        //continueText.text = "";
    }
	
	// Update is called once per frame
	void Update () {
        if (game_end)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                SceneManager.LoadScene(nextScene);
            }
        }
    }

    public void EndGame()
    {
        game_end = true;
        canvas.enabled = true;
        Player.isDead = true;
        level_complete_sound.Play();

        gameOverText.text = "Level Cleared!";
        continueText.text = "Press Enter to Continue";
    }
}
