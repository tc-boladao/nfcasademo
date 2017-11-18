using System.Collections;
using UnityEngine;

public class CheckKey : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GameManager.instance.haveKey.Equals(true))
        {
            gameObject.SetActive(false);
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
