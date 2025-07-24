using UnityEngine;


public class BulletScript : MonoBehaviour
{
    
    public LogicScript logic;
    private void Start() 
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        flyingpizza pizza = collision.GetComponent<flyingpizza>();
        if (pizza) 
        {
            logic.addscore(1);
            Destroy(gameObject);
            AudioManager.instance.PlaySFX("eat");
        }
    }
}
