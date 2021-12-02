using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Globalization;
public class textchange : MonoBehaviour
{
    public Text hpdate;
    public player player;
    private float hpee;
    public float hpee2;


    void Start()
    {
        //numbers = (string.Format(CultureInfo.InvariantCulture,"{0:0.00}", player.psnhp));
        
        


    }

    // Update is called once per frame
    void Update()
    {
        hpee = (player.psnhp / 10);
        nmbrlives();
        hpee2 = (Mathf.Ceil(hpee));
    }

    public void nmbrlives()
    {
        hpdate.text = "KR   " + hpee2  + " / 92";
    }
}
