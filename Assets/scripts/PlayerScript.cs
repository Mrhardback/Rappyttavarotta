using System;
using UnityEngine;



public class PlayerScript : MonoBehaviour {
    public GameObject deathEffectPreFab;
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public LogicScript logic;
    public bool rottaIsAlive = true;








    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() {


        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();


    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && rottaIsAlive) {
            myRigidbody.linearVelocity = Vector3.up * flapStrenght;

            AudioManager.instance.PlaySFX("Jump");

        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision) {

        logic.gameOver();
        rottaIsAlive = false;
        AudioManager.instance.musicSource.Stop();
        AudioManager.instance.PlaySFX("Death");

        myRigidbody.bodyType = RigidbodyType2D.Static;
        
        Destroy(gameObject, 1);
        

    }

}

