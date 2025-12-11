using UnityEngine;

public class CheckpointController : MonoBehaviour
{
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("checkpoint reached");
        if (collision.gameObject.tag.Equals("Player"))
        {
            collision.gameObject.GetComponent<playercontroller>().spawnPoint = transform;
            Debug.Log("checkpoint set");

        }
    }
}
