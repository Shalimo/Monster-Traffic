using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
   

    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = Camera.main.ScreenWoWorldPoint(Input.GetTouch(0).position);
        //transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
        float hor = Input.GetAxisRaw("Horizontal");

        Vector3 dir = new Vector3(hor, 0, 0);
        transform.Translate(dir.normalized * Time.deltaTime * speed);
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Car")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            
        }
    }
}
