using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace movement2
{



     
    public class movement2 : MonoBehaviour
    {
        private SpriteRenderer spriteRenderer;
        public Sprite sprite1;
        public Sprite sprite2; 
        public float jumpforce;
        [SerializeField] Rigidbody2D rb;
        private bool isGrounded;
        [SerializeField] Rigidbody2D gravity;
        bool redmode = true;
        [SerializeField] public float speed;


        // Start is called before the first frame update
        void Start()
        {
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



            if (Input.GetKeyDown(KeyCode.P))
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


                }
                else if (redmode == true)
                {
                    spriteRenderer.sprite = sprite2;
                    Debug.Log("Normal");
                    redmode = false;
                    gravity.angularDrag = 0.05f;
                    gravity.gravityScale = 1;

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
            if(other.gameObject.tag == "Border")
            {
                isGrounded = true;
            }
        }
    }
}