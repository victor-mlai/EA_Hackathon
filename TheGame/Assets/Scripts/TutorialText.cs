using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialText : MonoBehaviour {

    [SerializeField]
    private Text tutorialText;

    [SerializeField]
    private Canvas canvas;

    [SerializeField]
    private Text chooseText;

    // Use this for initialization
    void Start () {
        canvas.enabled = true;
        tutorialText.text = "A, D, Space to move";
        chooseText.text = "Choose a way to finish the level";
        Invoke("HideText", 5);
	}

    void HideText()
    {
        canvas.enabled = false;
    }
}
