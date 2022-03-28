using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyBullet : MonoBehaviour
{
    public AudioClip death;
    public AudioSource _audioSource;
    public Canvas canvas;
    public float speed, timer;
 

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
        if (col.gameObject.tag == "Player")
        {

            Destroy(col.gameObject);
            StartCoroutine(Death());

        }
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * - speed * Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer <= 0) { Destroy(gameObject); }
    }
    IEnumerator Death()
    {
        canvas.enabled = true;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
 AudioSource.PlayClipAtPoint(death, transform.position);
        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(26);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
