using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement2 : MonoBehaviour
{
    private PushDownAttack _pushDownAttack;

    private SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
    public float jumpforce;
    [SerializeField] Rigidbody2D rb;
    public bool isGrounded { get; private set; }
    [SerializeField] Rigidbody2D gravity;
    public bool redmode { get; set; }
    [SerializeField] public float speed;


    // Start is called before the first frame update
    void Start()
    {
        redmode = true;

        _pushDownAttack = FindObjectOfType<PushDownAttack>();

        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1

    }

    // Update is called once per frame
    void Update()
    {
        sidewayy();

        if (redmode == true)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.position += new Vector3(0, 1, 0) * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.position += new Vector3(0, -1, 0) * speed * Time.deltaTime;
            }

        }

        if (redmode == false)
        {

            if (Input.GetKeyDown(KeyCode.W) && isGrounded)
            {
                rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);
                isGrounded = false;
                Debug.Log("Jumped");
                //jump mech
            }

        }



      //  if (Input.GetKeyDown(KeyCode.P) || _pushDownAttack._movementUpdate)
        {
            Debug.Log("a");
            if (redmode == false)
            {
                spriteRenderer.sprite = sprite1;
                Debug.Log("Blue mode");
                spriteswap();
                redmode = true;
                gravity.velocity = new Vector2(0, 0);
                gravity.angularDrag = 0;
                gravity.gravityScale = 0;


              //  _pushDownAttack._movementUpdate = false;
            }

            else if (redmode == true)
            {
                spriteRenderer.sprite = sprite2;
                Debug.Log("Normal");
                redmode = false;
                gravity.angularDrag = 0.05f;
                  if (_pushDownAttack._movementUpdate == false)
                  {
                      gravity.gravityScale = 1;
                  }

                  _pushDownAttack._movementUpdate = false; 
            }



        }



    }



    void sidewayy()
    {
        if (Input.GetKey(KeyCode.A))
        {

            transform.position += new Vector3(-1, 0, 0) * speed * Time.deltaTime;


        }


        if (Input.GetKey(KeyCode.D))
        {

            transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;

        }
    }
    public void spriteswap()
    {

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Border")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Border")
        {
            isGrounded = false;
        }
    }
}