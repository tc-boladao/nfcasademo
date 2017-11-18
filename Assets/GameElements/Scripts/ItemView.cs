using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemView : MonoBehaviour {


    // Use this for initialization
    void Start () {
        ViewKey();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ViewKey() {
        if (GameManager.instance.haveKey.Equals(false))
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }

    }
}
