using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bushscript : MonoBehaviour
{
    float nilaiRandom;
    // Start is called before the first frame update
    void Start()
    {
       nilaiRandom = Random.Range(40,-50);
       transform.position = new Vector3(nilaiRandom,transform.position.y,nilaiRandom);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Vector3.left * 1000, Time.deltaTime *60);
    }
}
