using UnityEngine;
using System.Collections;

public class SlideMenuScript : MonoBehaviour
{

    //refrence for the pause menu panel in the hierarchy
    public GameObject menuPanel;
    //animator reference
    private Animator anim;
    //variable for checking if the game is paused 
    private bool IsSlide = false;
    // Use this for initialization
    void Start()
    {
        //unpause the game on start
        Time.timeScale = 1;
        //get the animator component
        anim = menuPanel.GetComponent<Animator>();
        //disable it on start to stop it from playing the default animation
        anim.enabled = false;
    }


    //function to pause the game
    public void SlideIn()
    {
        //enable the animator component
        anim.enabled = true;
        //play the Slidein animation
        anim.Play("MenuSlideIn");
        //set the IsSlide flag to true to indicate that the game is paused
        IsSlide = true;
        //freeze the timescale
        Time.timeScale = 0;
    }
    //function to unpause the game
    public void SlideOut()
    {
        //set the IsSlide flag to false to indicate that the game is not paused
        IsSlide = false;
        //play the SlideOut animation
        anim.Play("MenuSlideOut");
        //set back the time scale to normal time scale
        Time.timeScale = 1;
    }

}