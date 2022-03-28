using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAtTopEightOfScreen : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Vector3 stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        transform.position = transform.position + new Vector3(-stageDimensions.x+1, stageDimensions.y-1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
