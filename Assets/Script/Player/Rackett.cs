using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rackett : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed;
    

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    private void Update()
    {
        //ngambil Variabel dari Axing yang sudah diseting di unty input dengan (-1,1)
        float v = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(0,v)* speed;

        // Agar tidak keluar batas atas
        if (transform.position.y > 1f)
        {
            transform.position = new Vector2(transform.position.x, 1f);
        }

        if (transform.position.y < -1f)
        {
            transform.position = new Vector2(transform.position.x, -1f);
        }
    }
}
