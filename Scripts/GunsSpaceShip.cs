using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsSpaceShip : MonoBehaviour
{
    public float cooldownTimer = 0.5f;
    float timerLength;
    public GameObject bullet;
    public Transform gun1, gun2, gun3;
   public bool poweredUp;

    // Start is called before the first frame update
    void Start()
    {
        timerLength = cooldownTimer;
        cooldownTimer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0)&&cooldownTimer<=0)
        {
            if (poweredUp == true)
            {
             Instantiate(bullet, gun1.position, Quaternion.identity);
               Instantiate(bullet, gun2.position, Quaternion.identity);
            }
            if (poweredUp != true) { Instantiate(bullet, gun3.position, Quaternion.identity); }
            cooldownTimer = timerLength;
        }
        if (cooldownTimer>=0)
        {
            cooldownTimer -= Time.deltaTime;
        }
    }
}
