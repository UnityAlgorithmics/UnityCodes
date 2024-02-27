using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerUI : MonoBehaviour
{
    public CoinsCounter coinscounter;
    public Health healths;
    public TextMeshProUGUI coinscounterUI;
    public Slider healthbar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.maxValue = healths.maxHealth;
        healthbar.value = healths.health;

        coinscounterUI.text = coinscounter.coins.ToString();
    }
}
