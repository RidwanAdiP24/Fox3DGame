using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerak : MonoBehaviour
{
    public float kecepatan;
    public float loncat;
    public float gravitasi;
    public CharacterController Ch;
    Vector3 turun;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 gerak = transform.right * x + transform.forward * y;

        Ch.Move(gerak * kecepatan * Time.deltaTime);

        turun.y -= gravitasi * Time.deltaTime;
        Ch.Move(turun * Time.deltaTime);

        if (Ch.isGrounded)
        {
        if(Input.GetKey(KeyCode.Space))
        {
            turun.y += loncat;
        }            
        }
    


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("bush"))
        {

            Destroy(gameObject);            
            Time.timeScale = 0;
        }
    }
}