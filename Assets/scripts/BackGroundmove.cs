using UnityEngine;

public class BackGroundmove : MonoBehaviour {
    public float movespeed = 5;
    void Update() {
        transform.position = transform.position + (Vector3.left * movespeed) * Time.deltaTime;

        
    }
}
