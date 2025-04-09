using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    SpriteRenderer sr;
    public float speed = 5;
    public Collect collc;
    public AudioSource audSrc;
    public AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
        collc.isCollected.AddListener(yippee);
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //directions for making the player move horizontally and vertically
        float directionX = Input.GetAxis("Horizontal");
        float directionY = Input.GetAxis("Vertical");

        //Make the player move right with the arrow key
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += transform.right * directionX * speed * Time.deltaTime;
        }

        //Make the player move left with the arrow key
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += transform.right * directionX * speed * Time.deltaTime;
        }

        //Make the player move up with the arrow key
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.up * directionY * speed * Time.deltaTime;
        }

        //make the player move down with the arrow key
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += transform.up * directionY * speed * Time.deltaTime;
        }

        

    }
    public void yippee()
    {
        Debug.Log("Collected!");
        if(audSrc.isPlaying == false)
        {
            audSrc.PlayOneShot(clip);
        }
    }
    

}
