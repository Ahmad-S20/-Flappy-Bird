using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject pipe;
    public float spawnRate = 2;
    private float spawnTime = 0;
    public float hieghtOffset = 6;
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < spawnRate)
        {
            spawnTime += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            spawnTime = 0;
        }
           
    }
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - hieghtOffset;
        float highestPoint = transform.position.y + hieghtOffset;
        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation);
    }
}
