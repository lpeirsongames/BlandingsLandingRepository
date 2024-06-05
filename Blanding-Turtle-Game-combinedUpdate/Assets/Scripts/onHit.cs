using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onHit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
        gameObject.GetComponent<Collider2D>().isTrigger = true;
        Invoke(nameof(ResetEffect),3f);
    }
    private void ResetEffect()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.green;
        gameObject.GetComponent<Collider2D>().isTrigger = false;



    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
