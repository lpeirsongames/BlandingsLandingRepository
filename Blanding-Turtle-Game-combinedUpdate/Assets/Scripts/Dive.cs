using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dive : MonoBehaviour
    // WORK IN PROGRESS
{
    public GameObject turtle;
    private Collider2D coli;
    private float diveLength = 5f;
    public AudioSource diveSound;
    public AudioSource resurface;
    private Animation anim;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            turtle.GetComponent<Collider2D>().enabled = false;
            StartCoroutine(PowerupCountdownRoutine());
            diveSound.Play();
        }
 
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(diveLength);
        turtle.GetComponent<Collider2D>().enabled = true;
        resurface.Play();
    }
}
