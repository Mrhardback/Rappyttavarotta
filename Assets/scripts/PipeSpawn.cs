using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate) 
        {
            timer = timer + Time.deltaTime;
        } else 
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe() 
    {
        float lowestPoint = transform.position.y - heightoffset;
        float highestPoint = transform.position.y + heightoffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint),0), transform.rotation); 
    }
 
}
