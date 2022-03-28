using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBarrierRight : MonoBehaviour
{
    private Vector3 stageDimensions;

    // Start is called before the first frame update
    void Start()
    {
    stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        transform.position = transform.position + new Vector3(stageDimensions.x, 0, 0);
    }

}
