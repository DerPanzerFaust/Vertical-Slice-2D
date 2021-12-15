using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fight_Button : MonoBehaviour
{
    [SerializeField] Button button;
    void Start()
    {
        button = GetComponent<Button>();
        button.Select();
    }
}
