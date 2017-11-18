using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemView : MonoBehaviour {
    private int index = 0;
    private GameObject[] itemList;

    // Use this for initialization
    void Start () {
        index = PlayerPrefs.GetInt("ItemList", index);
        itemList = new GameObject[transform.childCount];
        transform.GetChild(0).gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
        ViewKey();
    }

    public void ViewKey() {
            itemList[0] = transform.GetChild(0).gameObject;
            if (GameManager.instance.haveKey.Equals(true))
            {
                itemList[0].SetActive(true);
            }
        

    }
}
