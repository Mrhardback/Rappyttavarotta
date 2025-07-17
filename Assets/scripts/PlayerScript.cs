using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrenght;
    public LogicScript logic;
    public bool rottaIsAlive = true;
            
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rottaIsAlive) 
        {
            myRigidbody.linearVelocity = Vector3.up * flapStrenght;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        logic.gameOver();
        rottaIsAlive = false;
    }
}
