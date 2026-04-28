using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    private Rigidbody enemyRb;
    private GameObject player;
    public bool Activated = false;

    public float killZone = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Activated)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRb.AddForce(lookDirection * speed);

            
        }

        // Kill code
            if (transform.position.y < -killZone)
            {
                Destroy(gameObject);
            }

            if (transform.position.y > killZone)
            {
                Destroy(gameObject);
            }

            if (transform.position.x < -killZone * 2)
            {
                Destroy(gameObject);
            }

            if (transform.position.x > killZone * 2)
            {
                Destroy(gameObject);
            }

            if (transform.position.z < -killZone * 2)
            {
                Destroy(gameObject);
            }

            if (transform.position.z > killZone * 2)
            {
                Destroy(gameObject);
            }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Activated = true;
        }
    }
}
