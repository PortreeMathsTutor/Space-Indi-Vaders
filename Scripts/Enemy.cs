using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject playerPosition;
    Vector3 stageDimensions;
    public Transform gun;
    public float cooldownTimer = 0.5f;
    float timerLength;
    public float speed, howMuchDown;
    public GameObject bullet;
    private float _screenWidth;
   private SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
  public int timerInt;
    public float wholeGameTimer;
    // Start is called before the first frame update
    void Start()
    {playerPosition = GameObject.FindGameObjectWithTag("PlayerPosition");
        spriteRenderer = GetComponent<SpriteRenderer>();
        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        timerLength = cooldownTimer;
   
    }

    // Update is called once per frame
    void Update()
    {
        wholeGameTimer = WholeGameTimer.wholeGameTimer;
        timerInt += 1;
        if (timerInt % 100 == 0 )
        {
            transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        
        }
        if (timerInt%100==0 && timerInt % 200 != 0) { 
            spriteRenderer.sprite = sprite1;
        }
        if (timerInt % 200 == 0)
        {
        
            spriteRenderer.sprite = sprite2;
        }

        if (cooldownTimer <= 0)
        {
                Instantiate(bullet, gun.position, Quaternion.identity);
                     cooldownTimer = timerLength;
        }
        if (cooldownTimer >= 0)
        {
            cooldownTimer -= Time.deltaTime;
        }

        if ((transform.position.x) >= stageDimensions.x)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            GoDownAndTurn();
        }

        if (transform.position.x <= -stageDimensions.x)
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0, 0);
            GoDownAndTurn();
        }
        if (transform.position.y <= playerPosition.transform.position.y)
        {
  Destroy(gameObject);
        }
    }
    void GoDownAndTurn()
    {
        speed = -speed;
        if (speed<0) { speed = -wholeGameTimer; }
        if (speed > 0) { speed = wholeGameTimer; }
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
        transform.position = transform.position + new Vector3(0,-howMuchDown,0);
     
    }
    void ChangeSprite()
    {
        if (spriteRenderer.sprite == sprite2)
        {
            spriteRenderer.sprite = sprite1;
        }
        if (spriteRenderer.sprite == sprite1)
        {
            spriteRenderer.sprite = sprite2;
        }
    }
}
