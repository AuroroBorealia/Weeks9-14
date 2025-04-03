using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    SpriteRenderer sr;
    Animator animator;
    public float speed = 2;
    public bool canRUn = true;
    public AudioSource audioSource;
    public AudioClip clip;

    public CinemachineImpulseSource impulseSource;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Horizontal");

        sr.flipX = (direction < 0);
        animator.SetFloat("movement", Mathf.Abs(direction));

        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Attack");
            canRUn = false;
            
        }

        if(canRUn == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }

    }

    public void AttackHasFinished()
    {
        Debug.Log("The attack animation has just finished!");
        canRUn = true;
    }

    public void footLanded()
    {
        if (audioSource.isPlaying == false)
        {
            audioSource.PlayOneShot(clip);
        }
        impulseSource.GenerateImpulse();

    }
}
