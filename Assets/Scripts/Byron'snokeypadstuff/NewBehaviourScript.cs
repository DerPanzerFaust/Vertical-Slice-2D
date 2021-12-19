using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
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
    

    void Start()
    {

      
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L) && BoneWave != null)
        {
            instansiateBoneWave();
            
        }
        if (Input.GetKeyDown(KeyCode.M) && BoneUp != null)
        {
            instansiateBoneUp();
        }
        if (Input.GetKeyDown(KeyCode.N) && BlasterSides != null)
        {
            instansiateBlaster(BlasterSides);
         
        }
        if (Input.GetKeyDown(KeyCode.K) && BlasterCorner != null)
        {
            instansiateBlaster(BlasterCorner);
          
        }
        if (Input.GetKeyDown(KeyCode.J) && BlasterDubble != null)
        {
            instansiateBlaster(BlasterDubble);
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
        Destroy(boneUp, 2.5f);
    }

    public void instansiateBlaster(GameObject blaster)
    {
        GameObject blasters = Instantiate(blaster, transform.position, transform.rotation);
        Destroy(blasters, 3f);
    }

    

}
