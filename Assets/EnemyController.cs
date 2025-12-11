using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Transform player;
    public float ChaseSpeed;
    public float AggroRange;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        if (distance > AggroRange) return;


            transform.position = Vector2.MoveTowards(transform.position, player.position, ChaseSpeed * Time.deltaTime);
    }
}
