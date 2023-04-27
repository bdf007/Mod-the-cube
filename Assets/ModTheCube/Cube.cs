using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    float timeCount;
    public float delayTime = 0.5f;
    
    void Start()
    {
        transform.position = new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(2.0f, 5.0f), Random.Range(-3.0f, 3.0f));
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    private void OnEnable()
    {
        timeCount = 0;
    }

    void Update()
    {

        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
        if (timeCount < delayTime)
        {
            timeCount += Time.deltaTime;
            return;
        }
        Material material = Renderer.material;
        material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.5f, 1.0f));
        transform.localScale = new Vector3(Random.Range(1.0f, 5.0f), Random.Range(1.0f, 5.0f), Random.Range(010f, 5.0f));
        transform.position = new Vector3(x: Random.Range(-2.5f, 2.5f), y: Random.Range(1.0f, 5.0f), z: Random.Range(-2.5f, 2.5f));

        
        timeCount = 0;


    }

  
}
