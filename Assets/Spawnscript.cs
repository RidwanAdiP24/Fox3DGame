using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnscript : MonoBehaviour
{
    float time = 0;
    float timer = 1;
    public GameObject bush;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time<=0)
        {
            Instantiate(bush, transform.position, Quaternion.identity);
            time = timer;
        }
        else
        {
            time -= Time.deltaTime;
        }
    }
}
