using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOnTrigger : MonoBehaviour {

    public GameController GameController;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
            GameController.EndGame();
    }
}
