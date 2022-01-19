using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fight_Button : MonoBehaviour
{
    public GameObject _text;

    private SetActive _setActive;

    private bool _pressOne = true;
    private bool _pressTwo = false;


    [SerializeField] Button button;
    void Start()
    {
        _setActive = FindObjectOfType<SetActive>();

        button = GetComponent<Button>();
        button.Select();
    }

    public void Buttonpress()
    {

        if (_pressTwo)
        {
            _setActive.AcivatePlayerAttack();
            _text.SetActive(false);
        }

        if (_pressOne)
        {
            _setActive._rescaleText.SetActive(false);
            _text.SetActive(true);

            _pressOne = false;
            _pressTwo = true;
            Debug.Log(_pressTwo);
        }
        else
        {
            _pressOne = true;
        }
    }
}
