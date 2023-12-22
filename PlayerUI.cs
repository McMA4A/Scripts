using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//2 пространства имён UI и TMpro text
using UnityEngine.UI;
using TMPro;
public class PlayerUi : MonoBehaviour
{
    //Поле игрового объекта слайдер
    public Slider healthBar;
    // поле текста с количеством монет
    public TMPro.TextMeshProUGUI CoinsCounter;
    //Поле скрипта игрока
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