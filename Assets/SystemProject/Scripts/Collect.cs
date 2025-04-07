using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{

    //variables for everything
    public UnityEvent isCollected;
    public UnityEvent isClicked;
    public Slider slider;
    float t;
    public Coroutine Stop;

    // Start is called before the first frame update
    void Start()
    {

    }

    //Using a coroutine to fill up the collection bar
    IEnumerator CollectAnimal()
    {
        while (t < 1)
        {
            t += Time.deltaTime;
            slider.value = t;

            yield return null;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(t >= 1)
        {
            //Use a variable so there's a way to stop the coroutine
            StopCoroutine(Stop);
            isCollected.Invoke();
        }
        
    }

    //makes it so that the bar only fills when the cat is clicked!
    public void beClicked()
    {
        
        Stop = StartCoroutine(CollectAnimal());
        
        Debug.Log("I've been clicked!");
    }

    public void hasBeenCollected()
    {
        
        Debug.Log("Collected!");
        
    }
}
