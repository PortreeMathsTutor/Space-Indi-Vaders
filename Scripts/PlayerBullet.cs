using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public bool cantBeDestroyed;
    public float speed, timer;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Barrier")
        {

            Destroy(col.gameObject);
            Destroy(gameObject);

        }
        if (col.gameObject.tag == "Enemy")
        {
            score = score + 1;
            Debug.Log("Enemy Dead");
            Destroy(col.gameObject);
            if (!cantBeDestroyed)
            { Destroy(gameObject); }
           
        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up  * speed * Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (!cantBeDestroyed)
            { Destroy(gameObject); }
        }
    }
}
