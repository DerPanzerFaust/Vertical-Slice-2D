using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;
public class player : MonoBehaviour
{
   // private static System.Timers.Timer aTimer;
    public float maxhp = 920;
    public float currenthp;
    public hpbar healthbar;


    public bool damagetaker;


    public float delay;
    //private float timer;
    public float psnmxhp = 920;
    public float poisonDamage = 5;
    public hpbar psnbar;
    public float psnhp;
    bool poisonEffect;
    public float poisontickdmg = 5;

    // public int poisontimer = 10;


    // Start is called before the first frame update
    void Start()
    {
        currenthp = maxhp;
        healthbar.Setmaxhealth(maxhp);


        psnhp = psnmxhp;
        psnbar.SetMaxpsnHP(psnmxhp);
       // timer = 0;

    }

    // Update is called once per frame
    void Update()
    {

        if (damagetaker == true)
        {


        }

        if (poisonEffect == true)
        {
            //poisen activafte
        }

        if (damagetaker == true && currenthp > 1)
        {
            Debug.Log("weerkt");
            alwdmg();


        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            damagetaker = false;
            poisonEffect = false;
            Debug.Log("ayo");
        }
        if (damagetaker == true)
        {
            Debug.Log("test");
        }

        if (currenthp == psnhp)
        {
            damagetaker = false;
            poisonEffect = false;
            StopCoroutine("poisoning");
            StopAllCoroutines();


        }
        if(psnhp == currenthp)
        {
            damagetaker = false;
            poisonEffect = false;
            StopCoroutine("poisoning");
            StopAllCoroutines();

        }

        Debug.Log(psnhp);

        alwdmg();
        dead();
    }

     void FixedUpdate()
    {
        if (poisonEffect == true)
        {
            StartCoroutine("poisoning");
            // psncontroll();
        }
    }

    void dead()
    {

        if (currenthp == 0)
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

    void psndmg(float psndamage)
    {
        psnhp -= psndamage;
        psnbar.SetpsnHealth(psnhp);
    }




    IEnumerator poisoning()
     {
         psnhp -= poisontickdmg;
         psnbar.SetpsnHealth(psnhp);
         poisonEffect = false;
         yield return new WaitForSeconds(0.6f);
         poisonEffect = true;
         poisoning();

     }


   /* public void psncontroll()
    {
        if (poisonEffect == true)
        {
            Debug.LogError("kutshitfucku");

            timer += Time.deltaTime;
            if (timer > delay)
            {
                //do iets
                timer = 0;
                psnhp -= poisontickdmg;
                psnbar.SetpsnHealth(psnhp);

                poisonEffect = true;
            }


            aTimer = new System.Timers.Timer(1000);




        }
    }

    */

    void alwdmg()
    {
        if (currenthp > 1)
        {

            if (Input.GetKey(KeyCode.O))
            {
                Takedmg(2f);
                //Takedmg(1f);
                // Debug.Log(currenthp);
                poisonEffect = true;
                damagetaker = true;
            }

        }
        else if (currenthp == 1)
        {
            Debug.Log("working");
            if (Input.GetKey(KeyCode.O))
            {
                psndmg(2f);
                //psndmg(1f);

            }

        }

    }

}
