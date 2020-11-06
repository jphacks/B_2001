using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class komatiController : MonoBehaviour
{
    private Animator animator;
    public AudioClip sound1, sound2;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
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

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //transform.position += transform.forward * 0.01f;
            animator.SetBool("sp_kg", true);
            audioSource.clip = sound2;
            audioSource.Play();//audioSource.PlayOneShot(sound1);
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