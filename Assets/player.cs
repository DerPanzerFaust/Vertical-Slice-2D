using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
using UnityEngine.UI;
public class player : MonoBehaviour
{
    // private static System.Timers.Timer aTimer;
    public float maxhp = 920;
    public float currenthp;
    public hpbar healthbar;

    public bool psneffect2;
    public bool damagetaker;
    public Text texts;

    public bool nrmlhpdmg = true;
    public bool psnhpdmg = false;

    public float delay;
    //private float timer;
    public float psnmxhp = 920;
    public float poisonDamage = 1;
    public hpbar psnbar;
    public float psnhp;
    bool poisonEffect;
    float poisontickdmg = 5;
    

    // public int poisontimer = 10;


    // Start is called before the first frame update
    void Start()
    {
        currenthp = maxhp;
        healthbar.Setmaxhealth(maxhp);


        psnhp = psnmxhp;
        psnbar.SetMaxpsnHP(psnmxhp);
        // timer = 0;

        /*

        Transform bones = Instantiate(Bonesprefab) as Transform;
        Physics.IgnoreCollision(bones.GetComponent<Collider>(), GetComponent<Collider>());


        */

    }

    // Update is called once per frame
    void Update()
    {



       



        if (psnhp < currenthp && psnhp > 2)
        {
            
            damagetaker = false;
            poisonEffect = false;
            StopCoroutine("poisoning");
            StopAllCoroutines();
            psnhp += 1;
            psneffect2 = false;
        }
        if (psneffect2 == false)
        {
            texts.GetComponent<Text>().color = Color.white;
        }
      
       
        if (damagetaker == false)
        {
            poisontickdmg = 2;
        }
        /* if(psnhp > currenthp)
         {
             psnhp = currenthp;
             Debug.LogError("psn > hp");
         }
        */
       





        if (damagetaker == true && currenthp > 1)
        {
            Debug.Log("dmg is toegestaan");
            //alwdmg();


        }



        if (currenthp == psnhp)
        {
            damagetaker = false;
            poisonEffect = false;
            StopCoroutine("poisoning");
            StopAllCoroutines();
            poisontickdmg = 0;
            psneffect2 = false;




        }
        if (psnhp == currenthp)
        {
            damagetaker = false;
            poisonEffect = false;
            StopCoroutine("poisoning");
            StopAllCoroutines();
            poisontickdmg = 0;
            psneffect2 = false;



        }
        if (psneffect2 == true)
        {
            texts.color = Color.magenta;
        }

        if (psnhp == 0)
        {
            Debug.Log("died");
        }



        dead();
    }

    void FixedUpdate()
    {
        if (poisonEffect == true)
        {
            Debug.Log("poison has started");

            StartCoroutine("poisoning");
            // psncontroll();
        }


    }

    void dead()
    {

        if (psnhp <= 0)
        {
            Debug.Log("died");
        }
    }
    void Takedmg(float damage)
    {
        damagetaker = true;
        currenthp -= damage;
        healthbar.SetHealth(currenthp);
    }

    void psndmging(float psndamage)
    {
        damagetaker = true;
        psnhp -= psndamage;
        psnbar.SetpsnHealth(psnhp);




    }




    IEnumerator poisoning()
    {

        psnhp -= poisontickdmg;
        psnbar.SetpsnHealth(psnhp);

        poisonEffect = false;
        yield return new WaitForSeconds(0.1f);
        psneffect2 = true;
        poisonEffect = true;


    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Bones"))
        {
            damagetaker = false;
            poisonEffect = false;
            Debug.Log("dmg has stopped");
        }
    }

    private void OnTriggerStay(Collider other)
    {


        if (other.gameObject.CompareTag("Bones"))
        {
            Debug.Log("LES FUCKIN GOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
            if (currenthp > 1)
            {

                Takedmg(1f);
                psndmging(0.45f);
                poisonEffect = true;
                damagetaker = true;
                
            }
            else if(currenthp == 1)
            {
                if (currenthp == 1)
                {
                    psndmging(1);
                    Debug.Log("poop");

                }

            }



            /*

            void alwdmg()
            {

                 if (currenthp > 1)
            {




                {
                    Takedmg(1f);
                    psndmging(0.45f);
                    poisonEffect = true;
                    damagetaker = true;

                }

            }








                    if (Input.GetKey(KeyCode.O))
                    {
                        Takedmg(1f);
                        psndmging(0.45f);
                        poisonEffect = true;
                        damagetaker = true;

                    }

                }


            }
            */


        }
    }
}