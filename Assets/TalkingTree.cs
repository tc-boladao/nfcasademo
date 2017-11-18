using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkingTree : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}

    // On talking tree player collides
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player in interation area");
        }
    }
}
