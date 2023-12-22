using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2 ������������ ��� UI � TMpro text
using UnityEngine.UI;
using TMPro;
public class PlayerUi : MonoBehaviour
{
    //���� �������� ������� �������
    public Slider healthBar;
    // ���� ������ � ����������� �����
    public TMPro.TextMeshProUGUI CoinsCounter;
    //���� ������� ������
    public Player player;
    void Start()
    {
        healthBar.maxValue = player.maxHealth;
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coins;
    }
    void Update()
    {
        healthBar.value = player.health;
        CoinsCounter.text = "coins:" + player.coins;
    }
}