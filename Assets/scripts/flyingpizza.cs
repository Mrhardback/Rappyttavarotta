using UnityEngine;

public class flyingpizza : MonoBehaviour
{
    public float movespeed = 5;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        
        BulletScript bullet = collision.GetComponent<BulletScript>();

        if (bullet) 
        {
           
            Destroy(gameObject);
            
        }
    }


}
