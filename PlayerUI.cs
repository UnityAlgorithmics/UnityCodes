using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI coinscounterUI;
    public Slider healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.maxValue = player.maxHealth;
        healthbar.value = player.health;

        coinscounterUI.text = player.coins.ToString();
    }
}
