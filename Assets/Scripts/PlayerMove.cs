using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public float distancePerSecond = 2f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dx = 0;
        float dy = 0;

        if (Input.GetKey (KeyCode.UpArrow)) {
            dy = distancePerSecond * Time.deltaTime;
        }
        if (Input.GetKey (KeyCode.DownArrow)) {
            dy = -distancePerSecond * Time.deltaTime;
        }
        if (Input.GetKey (KeyCode.LeftArrow)) {
            dx = -distancePerSecond * Time.deltaTime;
        }
        if (Input.GetKey (KeyCode.RightArrow)) {
            dx = distancePerSecond * Time.deltaTime;
        }
        
        rb.position += new Vector2(dx, dy);
    }
}
