using UnityEngine;

public class playershott : MonoBehaviour 
{
    public float bulletspeed = 500f;
    public GameObject bulletPrefab;
    public Transform firePoint;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.F)) 
        {
            
            shoot();

        }

        void shoot() 
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

            if (rb != null) 
            {
                rb.linearVelocity = firePoint.right * bulletspeed;
                Debug.Log("shooting");
            }
            Destroy(bullet, 2f);
        }
    }
}