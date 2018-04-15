using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakBox : MonoBehaviour {

    private Rigidbody2D rb;

    public Sprite brokenBox;

    public GameObject spawnObject;

    public GameController gc;

    private bool spawned = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (rb.velocity.y < -4.0f)
        {
            BlackBox();
        }
    }
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (rb.velocity.y < -12.0f)
        {
            BlackBox();
        }
    }

    void BlackBox() // Breaks the Box and spawns a dangerous object
    {
        if (spawned)
            return;

        // Change sprite to the broken one
        GetComponent<SpriteRenderer>().sprite = brokenBox;

        // Create the obj from the box
        GameObject obj = Instantiate(spawnObject, gameObject.transform.position, Quaternion.identity);

        // set new objs' GameController
        obj.GetComponent<PlayerOnTrigger>().GameController = gc;

        // Play breakBox Audio
        GetComponent<AudioSource>().Play();

        // Disable RigidBody
        Invoke("DisableRigidBody", 2.0f);

        Debug.Log(gc.name);
        spawned = true;
    }

    void DisableRigidBody()
    {
        GetComponent<Rigidbody2D>().simulated = false;
    }
}
