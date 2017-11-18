using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{

    private Animator animator;


    // Use this for initialization
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {   
            if (GameManager.instance.haveKey.Equals(true))
            {
                animator.SetBool("Key", true);
                GetComponent<BoxCollider2D>().enabled = false;
            }
            
        }
    }
}


