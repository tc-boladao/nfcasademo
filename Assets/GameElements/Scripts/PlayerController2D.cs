using UnityEngine;
using System.Collections;


public class PlayerController2D : MonoBehaviour
{

    private Animator animator;      //Aniamtor attach to the character

   // public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    private bool key = false;

    //Player movement speed
    public float movementSpeed = 10.0f;

    //Player height
    public float height = 0.5f;

    //LIXO
    public float speed = 10f;
    private Vector3 targetPosition;
    private bool isMoving;
    public GameObject clickAnimation;



    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Animator component so that we can access it.
        animator = this.GetComponent<Animator>();
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();

        key = GameManager.instance.haveKey;


    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        MoveCharacterMouse();

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Key"))
        {
            key = true;
            other.gameObject.SetActive(false);
            GameManager.instance.haveKey = key;
        }
    }

    //LIXO
    public void MoveCharacterMouse() {
        if (Input.GetMouseButtonUp(0))
        {
            targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPosition.z = transform.position.z;

            CharacterAnimation();
            if (isMoving == false)
            {
                isMoving = true;
                Instantiate(clickAnimation, targetPosition, Quaternion.identity);
            }
            
        }
        if (isMoving == true)
        {

            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        if (targetPosition == transform.position)
        {
            isMoving = false;
            Destroy(GameObject.Find("Click Animation(Clone)"));
        }

    }


    private void CharacterAnimation()
    {
        //TODO:Arrumar ainda nao esta ideal & ainda nao para
        Vector2 characterPosition = gameObject.transform.position;
        Vector2 touchPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (touchPosition.x < touchPosition.y)
        {
            if (touchPosition.x < characterPosition.x)
            {
                animator.SetInteger("Direction", 1);
            }
            else
            {
                animator.SetInteger("Direction", 3);
            }
        }
        else
        {
            if (touchPosition.y < characterPosition.y)
            {
                animator.SetInteger("Direction", 0);
            }
            else
            {
                animator.SetInteger("Direction", 2);
            }
        }
    }

}
