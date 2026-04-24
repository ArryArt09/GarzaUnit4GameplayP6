using UnityEngine;

public class PowerUpKeep : MonoBehaviour
{

    public float killZone = 0.25f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < killZone)
        {
            transform.position = new Vector3(transform.position.x, killZone, transform.position.z);
        }
    }
}
