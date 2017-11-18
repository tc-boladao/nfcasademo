using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

    [SerializeField] private GameObject guiObject;
    [SerializeField] private string loadLevel;
    [SerializeField] private int initialNumeberLevel;
    [SerializeField] private int endNumberLevel;

	// Use this for initialization
	void Start () {
        guiObject.SetActive(false);	
	}

    public void RandomScene()
    {
        int index = Random.Range(initialNumeberLevel, endNumberLevel + 1);
        string map = loadLevel + index;
        SceneManager.LoadScene(map);
    }

    public void DefiniteScene() {
        SceneManager.LoadScene(loadLevel);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        guiObject.SetActive(false);
    }
}
