using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEnv : MonoBehaviour
{
    public BoxCollider2D collider;
    public Rigidbody2D rb;

    private float width;

    private float scrollSpeed = -2f;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();

        width = collider.size.x;
        collider.enabled = false;

        rb.velocity = new Vector2(scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -width)
        {
            Vector2 resetPosition = new Vector2(width * 50, 0);
            transform.position = (Vector2)transform.position + resetPosition;
        }
    }
}
