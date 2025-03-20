using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gym10Coroutine : MonoBehaviour
{

    public AnimationCurve size;
    [Range(0, 1)]
    public float t;
    
    void Start()
    {
        
    }

    void Update()
    {
        t += Time.deltaTime;
        Vector2 pos = transform.localScale;
        pos.x = size.Evaluate(t);
        pos.y = size.Evaluate(t);

        transform.localScale = pos;
    }
}
