using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class luffyscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float luffyspeed;
    public logicscript logic;
    public bool birdIsAlive=true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
        myrigidbody.velocity = Vector2.up * luffyspeed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
