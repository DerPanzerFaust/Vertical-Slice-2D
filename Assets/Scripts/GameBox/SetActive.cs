using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    [Header("Rescaling")]
    [SerializeField] private GameObject _rescale;
    public GameObject _rescaleText;
    [Header("Boxes")]
    [SerializeField] private GameObject _PlayerAttackBox;
    [SerializeField] private GameObject _minigameBox;
    [Header("Button")]
    [SerializeField] private GameObject _Buttons;
    [SerializeField] private GameObject _fakeButtons;
    [Header("Player")]
    [SerializeField] private GameObject _playerHeart;

    public void ActivateRescale()
    {
        _minigameBox.SetActive(false);
        _playerHeart.SetActive(false);

        _rescale.SetActive(true);
        StartCoroutine(_rescaleTextWait());

        _fakeButtons.SetActive(false);
        _Buttons.SetActive(true);

    }

    public void AcivatePlayerAttack()
    {
        _rescale.SetActive(false);
        _PlayerAttackBox.SetActive(true);

        _fakeButtons.SetActive(true);
        _Buttons.SetActive(false);
    }

    public void ActivateMinigameBox()
    {
        _minigameBox.SetActive(true);
        _playerHeart.SetActive(true);

        _fakeButtons.SetActive(true);
        _Buttons.SetActive(false);
    }


    IEnumerator _rescaleTextWait()
    {
        yield return new WaitForSeconds(1);
        _rescaleText.SetActive(true);
    }
}
