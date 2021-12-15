using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackInitiator : MonoBehaviour
{
    [SerializeField]
    private GameObject BoneWave;
    [SerializeField]
    private GameObject BoneUp;

    [SerializeField]
    private GameObject BlasterSides;
    [SerializeField]
    private GameObject BlasterCorner;
    [SerializeField]
    private GameObject BlasterDubble;

    public int WhatAttack;

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Keypad1) || WhatAttack == 1) && BoneUp != null)
        {
            instansiateBoneUp();
            WhatAttack = 0;
        }
        if ((Input.GetKeyDown(KeyCode.Keypad2) || WhatAttack == 2) && BoneWave != null)
        {
            instansiateBoneWave();
            WhatAttack = 0;
        }
        if ((Input.GetKeyDown(KeyCode.Keypad4) || WhatAttack == 3) && BlasterSides != null)
        {
            instansiateBlaster(BlasterSides);
            WhatAttack = 0;
        }
        if ((Input.GetKeyDown(KeyCode.Keypad5) || WhatAttack == 4) && BlasterCorner != null)
        {
            instansiateBlaster(BlasterCorner);
            WhatAttack = 0;
        }
        if ((Input.GetKeyDown(KeyCode.Keypad6) || WhatAttack == 5) && BlasterDubble != null)
        {
            instansiateBlaster(BlasterDubble);
            WhatAttack = 0;
        }
    }

    public void instansiateBoneWave()
    {
        GameObject boneWave = Instantiate(BoneWave, transform.position, transform.rotation);
        Destroy(boneWave, 5f);
    }
    public void instansiateBoneUp()
    {
        GameObject boneUp = Instantiate(BoneUp, transform.position, transform.rotation);
        Destroy(boneUp, 15f);
    }

    public void instansiateBlaster(GameObject blaster)
    {
        GameObject blasters = Instantiate(blaster, transform.position, transform.rotation);
        Destroy(blasters, 3f);
    }
}
