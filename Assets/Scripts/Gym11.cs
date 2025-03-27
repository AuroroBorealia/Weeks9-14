using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gym11 : MonoBehaviour
{

    public float t;
    public AnimationCurve curve;
    [Range(0, 1)]

    float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        
        pos.y = curve.Evaluate(t);

        Vector2 planetInScreen = Camera.main.WorldToScreenPoint(pos);

        if (planetInScreen.x > Screen.width || planetInScreen.x < -10)
        {
            speed = speed *= -1;
        }

        transform.position = pos;
    }

}
