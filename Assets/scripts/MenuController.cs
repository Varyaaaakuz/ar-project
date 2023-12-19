using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    [SerializeField] private PlayerMoney playerMoney;
    [SerializeField] private TextMeshPro _titleMoney;

    private void Update()
    {
        _titleMoney.text = "количество монет: " + Convert.ToString(playerMoney._moneyAmount);
    }
}
