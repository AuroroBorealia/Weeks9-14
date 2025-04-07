using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour
{

    public Slider slider;
    float t;

    // Start is called before the first frame update
    void Start()
    {

    }

    IEnumerator CollectAnimal()
    {
        while (Input.GetMouseButton(0))
        {
            t += Time.deltaTime;
            slider.value = t % slider.maxValue;

            yield return null;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CollectAnimal());

    }
}
