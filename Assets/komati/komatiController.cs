using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class komatiController : MonoBehaviour
{
    private Animator animator;
    public AudioClip sound1, sound2,sound3;
    AudioSource audioSource;

    public int start_A;
    int B = 0;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        Debug.Log(start_A);
    }

    // Update is called once per frame
    void Update()
    {
        start_A = Start_image.start_a;
        if(start_A == 1&&B==0)
        {
            //朝
            if (DateTime.Now.Hour >= 4 && DateTime.Now.Hour <= 11)
            {
                animator.SetBool("speaking", true);
                audioSource.clip = sound1;
                //audioSource.Play();
                audioSource.PlayOneShot(sound1);
            }
            //昼
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 19)
            {
                animator.SetBool("sp_kon", true);
                audioSource.clip = sound2;
                //audioSource.Play();
                audioSource.PlayOneShot(sound2);
            }
            //夜
            else if (DateTime.Now.Hour >= 20 || DateTime.Now.Hour >= 0&& DateTime.Now.Hour <= 3)
            {
                animator.SetBool("sp_yoo", true);
                audioSource.clip = sound3;
                //audioSource.Play();
                audioSource.PlayOneShot(sound3);
            }

            //transform.position += transform.forward * 0.01f;
            

            B = 1;
            Debug.Log(start_A);
           // animator.SetBool("speaking", false);
        }
        
    /*
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //transform.position += transform.forward * 0.01f;
            animator.SetBool("speaking", true);
            audioSource.clip = sound1;
            audioSource.Play();//audioSource.PlayOneShot(sound1);
        }
        else
        {
            animator.SetBool("speaking", false);
        }
    */
        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.position += transform.forward * 0.01f;
            animator.SetBool("sp_kg", true);
            audioSource.clip = sound2;
            //audioSource.Play();//audioSource.PlayOneShot(sound1);
        }
        else
        {
            animator.SetBool("sp_kg", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //transform.Rotate(0.0f, 3.0f, 0.0f);
            //audioSource.clip = sound2;
            //audioSource.Play();
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //transform.Rotate(0.0f, -3.0f, 0.0f);
        }

    }
}