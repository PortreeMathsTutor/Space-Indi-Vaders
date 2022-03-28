using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WholeGameTimer : MonoBehaviour
{
    public static float wholeGameTimer;
    public float timeCheck = 50;
    // Start is called before the first frame update
    void Start()
    {
        wholeGameTimer = timeCheck;
    }

    // Update is called once per frame
    void Update()
    {
        wholeGameTimer += 0.03f* Time.deltaTime;
        timeCheck = wholeGameTimer;
    }
}
