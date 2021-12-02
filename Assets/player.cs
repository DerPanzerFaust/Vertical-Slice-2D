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


    public bool damagetaker;
    public Text texts;

    public bool nrmlhpdmg = true;
    public bool psnhpdmg = false;

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
        if(poisonEffect == false)
        {
            texts.GetComponent<Text>().color = Color.white;
        }


      

      

        if (damagetaker == true && currenthp > 1)
        {
            Debug.Log("dmg is toegestaan");
            alwdmg();


        }

        if (Input.GetKeyUp(KeyCode.O))
        {
            damagetaker = false;
            poisonEffect = false;
            Debug.Log("dmg has stopped");
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
        if(poisonEffect == true)
        {
            texts.color = Color.magenta;
        }
       

        alwdmg();
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
        // poisonEffect = false;
         yield return new WaitForSeconds(0.6f);
         poisonEffect = true;
         poisoning();

     }


   

    void alwdmg()
    {
        if (currenthp > 1)
        {

            if (Input.GetKey(KeyCode.O))
            {
                Takedmg(1f);
                
                poisonEffect = true;
                damagetaker = true;
            }

        }
        

    }

}
