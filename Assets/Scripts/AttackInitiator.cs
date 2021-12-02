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
    private GameObject BoneUpWarning;

    [SerializeField]
    private GameObject BlasterSides;
    [SerializeField]
    private GameObject BlasterCorner;
    [SerializeField]
    private GameObject BlasterDubble;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad2) && BoneWave != null)
        {
            instansiateBoneWave();
        }

        if (Input.GetKeyDown(KeyCode.Keypad1) && BoneUp != null)
        {
            instansiateWarning();
        }

        if (Input.GetKeyDown(KeyCode.Keypad4) && BlasterSides != null)
        {
            instansiateBlaster(BlasterSides);
        }

        if (Input.GetKeyDown(KeyCode.Keypad5) && BlasterCorner != null)
        {
            instansiateBlaster(BlasterCorner);
        }

        if (Input.GetKeyDown(KeyCode.Keypad6) && BlasterDubble != null)
        {
            instansiateBlaster(BlasterDubble);
        }
    }

    public void instansiateBoneWave()
    {
        GameObject boneWave = Instantiate(BoneWave, transform.position, transform.rotation);
        Destroy(boneWave, 5f);
    }
    public void instansiateWarning()
    {
        GameObject boneUpWarning = Instantiate(BoneUpWarning, transform.position, transform.rotation);
        Destroy(boneUpWarning, 0.5f);

        Invoke("instansiateBoneUp", .2f);
    }
    void instansiateBoneUp()
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
