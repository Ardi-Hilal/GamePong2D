    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour
{
    private Rigidbody2D player;
    public float speed;
    private Animator anim;
    public string axis = "Vertical";

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    } 

    // Update is called once per frame
    void Update()
    {
        if(axis =="Vertical2" && GameData.instance.isSinglePlayer)
        {
            return; 
        }
 

        float v = Input.GetAxis(axis);
        player.velocity = new Vector2(0, v)*speed;

        if (transform.position.y > 2f)
        {
            transform.position = new Vector2(transform.position.x, 2);
        }
        if (transform.position.y < -2f)
        {
            transform.position = new Vector2(transform.position.x, -2f);
        }
    }


    private void OnCollisionEnter2D(Collision2D coll) {
        if(coll.gameObject.tag == "Ball")
        {
            anim.SetTrigger("Shoot");
        }
    }

}
