﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 15f;
    Vector3 position;
    public AudioManager am;
    public UIManager ui;

    void Start()
    {
        am.carSound.Play();
        position = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = Camera.main.ScreenWoWorldPoint(Input.GetTouch(0).position);
        //transform.position = new Vector3(pos.x, transform.position.y, transform.position.z);
        //float hor = Input.GetAxisRaw("Horizontal");

        //Vector3 dir = new Vector3(hor, 0, 0);
        //transform.Translate(dir.normalized * Time.deltaTime * speed);

        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);
        transform.position = position;

        float temp = Input.acceleration.x;
        position.x += temp * speed * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);
        transform.position = position;

        if (Time.timeScale == 0)
        {
            am.carSound.Pause();
        }
        else
        {
            am.carSound.UnPause();
        }
    }
    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Car")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            ui.gameOverActivated();
            am.carSound.Stop();
            am.carCrash.Play();
           


        }
    }
}
