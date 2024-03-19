using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public int playerDamage = 1;
    public float tcurrent = 36.6f;
    public float tnormal = 36.6f;
    public float tcritical = 34f;
    public float fspeed = 0.05f;
    public float fdamagetimer = 1;
    public float fdamagedelay = 2;
    public int tcurrentAprox;

    void Update()
    {
        tcurrent -= fspeed*Time.deltaTime;
        tcurrentAprox = Mathf.RoundToInt(tcurrent);

        if(tcurrent <= tcritical)
        {
            if(fdamagetimer <= 0)
            {
                health.TakeDamage(playerDamage);
                fdamagetimer += fdamagedelay;
            }
            else
            {
                fdamagetimer -= Time.deltaTime;
            }
        }
        
    }


}
