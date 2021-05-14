using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatMoveAway : MonoBehaviour
{
    Rigidbody2D rb;
    public float distancePerSecond = 0.5f;
    public bool outsideHouse;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        outsideHouse = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ((rb.position.x >= -1 && rb.position.x <= 1) && (rb.position.y >= -1 && rb.position.y <= 1)) {
            outsideHouse = false;
        }

        if (outsideHouse) {
            GameObject p = GameObject.FindWithTag("Player");    // p = player
            if (p == null) return;

            Rigidbody2D prb = p.GetComponent<Rigidbody2D>();    // prb = player Rigidbody

            Vector2 delta = prb.position - rb.position;
            delta.Normalize();

            rb.position -= delta * distancePerSecond * Time.deltaTime;
        }
            
        
    }
}
