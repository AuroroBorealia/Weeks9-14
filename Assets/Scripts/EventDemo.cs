using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDemo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public RectTransform banana;

    public UnityEvent OnTimerHasFinished;
    public float timerLength = 3;
    public float t;

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(t > timerLength)
        {
            t = 0;
            OnTimerHasFinished.Invoke();
        }
    }

    public void MouseJustEnteredImage()
    {
        Debug.Log("Mouse Just Entered Me!");
        banana.localScale = Vector3.one * 1.2f;
    }

    public void MouseJustLeftTheImage()
    {
        Debug.Log("Mouse Just Left Me!");
        banana.localScale = Vector3.one;
    }
}
