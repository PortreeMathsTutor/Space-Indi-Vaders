using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpaceShipMovement : MonoBehaviour
{
    public Canvas canvas;
    public AudioClip death;
    public AudioSource _audioSource;


    float mx;
    public float movementSpeed = 5;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
   
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mx = Input.GetAxisRaw("Horizontal");
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            StartCoroutine(Death());

        }
    }
    private void FixedUpdate()
    {
     
        Vector2 movment = new Vector2(mx * movementSpeed, rb.velocity.y);
        rb.velocity = movment;
    }
    IEnumerator Death()
    {
        canvas.enabled = true;
        AudioSource.PlayClipAtPoint(death, transform.position);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(26);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
