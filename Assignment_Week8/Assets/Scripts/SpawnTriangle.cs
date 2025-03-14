using UnityEngine;

public class SpawnTriangle : MonoBehaviour
{
    public GameObject triangle;
    void Start()
    {
        
    }


    void Update()
    {
        if(Random.Range(0, 100) < 1)
        {
            Instantiate(triangle, new Vector3(Random.Range(-10, 10), Random.Range(-7, 7), 0), Quaternion.identity);
        }
    }
}
