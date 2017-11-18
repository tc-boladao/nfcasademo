using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int index = 0;

    private void Start()
    {
        index = PlayerPrefs.GetInt("CharacterSelected", index);
        characterList = new GameObject[transform.childCount];

        //Fill the array with our models
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        //We toggle off their render
        foreach (GameObject go in characterList)
        {
            go.SetActive(false);
        }

        //We toggle on the selected charcter
        if (characterList[index])
        {
            characterList[index].SetActive(true);
        }
    }

    public void ToggleLeft()
    {
        //Toggle off the current model
        characterList[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = characterList.Length - 1;
        }
        //Toggle on the new model
        characterList[index].SetActive(true);

    }

    public void ToggleRight()
    {
        //Toggle off the current model
        characterList[index].SetActive(false);
        index++;
        if (index == characterList.Length)
        {
            index = 0;
        }
        //Toggle on the new model
        characterList[index].SetActive(true);

    }

    public void ConfirmButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("LetsStart");
    }
}
