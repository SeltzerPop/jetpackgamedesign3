using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce;
    public float speed;
    public bool flight;
    public bool burst;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        Vector3 newScale = transform.localScale;
        float currentScale = Mathf.Abs(transform.localScale.x);

        Vector2 vel = new Vector2(0,rb.linearVelocity.y);

        if ((Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow)) && burst == false)
        {
            vel = new Vector2(rb.linearVelocity.x, jumpForce);
            flight = true;
        }
        else
        {
            flight = false;
        }

        if ((Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) && flight == false)
        {
            vel.x = -speed;
            burst = true;
        }
        

        else if ((Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow)) && flight == false)
        {
            vel.x = speed;
            burst = true;
        }
        else
        {
            burst = false;
        }

        rb.linearVelocity = vel;
       
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("deadly"))
        {
            Debug.Log("died");
            transform.position = new Vector3 (0,0,-10);
        }
   }
}
